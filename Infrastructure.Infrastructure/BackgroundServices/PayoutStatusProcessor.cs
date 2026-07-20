using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;
using ReelsCommerceSystem.Domain.Enums.Finance;
using System.Text.Json;

namespace ReelsCommerceSystem.Infrastructure.BackgroundServices;

public class PayoutStatusProcessor : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<PayoutStatusProcessor> _logger;
    private static readonly TimeSpan PollingInterval = TimeSpan.FromMinutes(5);
    private static readonly int MaxRetries = 10;

    public PayoutStatusProcessor(IServiceProvider serviceProvider, ILogger<PayoutStatusProcessor> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("PayoutStatusProcessor started");

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var scope = _serviceProvider.CreateScope();
                var brandSettlementRepo = scope.ServiceProvider.GetRequiredService<IBrandSettlementRepository>();
                var auditLogRepo = scope.ServiceProvider.GetRequiredService<IFinancialAuditLogRepository>();
                var payoutProvider = scope.ServiceProvider.GetRequiredService<IPayoutProvider>();

                var pendingTransfers = await brandSettlementRepo.GetPendingTransferAsync(MaxRetries);

                if (pendingTransfers.Count > 0)
                {
                    _logger.LogInformation("Processing {Count} pending payout transfers", pendingTransfers.Count);

                    var batchSize = 50;
                    for (var i = 0; i < pendingTransfers.Count; i += batchSize)
                    {
                        var batch = pendingTransfers.Skip(i).Take(batchSize).ToList();

                        foreach (var settlement in batch)
                        {
                            if (string.IsNullOrEmpty(settlement.TransferId))
                            {
                                settlement.RetryCount++;
                                settlement.Notes = "Missing TransferId, marking as failed";
                                settlement.Status = SettlementStatus.Failed;
                                brandSettlementRepo.Update(settlement);
                                continue;
                            }

                            try
                            {
                                var status = await payoutProvider.CheckTransferStatusAsync(settlement.TransferId, stoppingToken);

                                switch (status.DisbursementStatus)
                                {
                                    case "success":
                                        settlement.Status = SettlementStatus.Paid;
                                        settlement.PaidAt = DateTime.UtcNow;
                                        settlement.PaymentReference = settlement.TransferId;
                                        _logger.LogInformation(
                                            "Transfer {TransferId} for settlement {SettlementId} succeeded",
                                            settlement.TransferId, settlement.Id);
                                        break;

                                    case "failed":
                                        settlement.RetryCount++;
                                        settlement.Status = settlement.RetryCount >= MaxRetries
                                            ? SettlementStatus.Failed
                                            : SettlementStatus.TransferInitiated;
                                        settlement.Notes = $"Paymob status: {status.StatusDescription}";
                                        _logger.LogWarning(
                                            "Transfer {TransferId} for settlement {SettlementId} failed: {StatusDescription}",
                                            settlement.TransferId, settlement.Id, status.StatusDescription);
                                        break;

                                    case "pending":
                                        settlement.Status = SettlementStatus.Processing;
                                        _logger.LogInformation(
                                            "Transfer {TransferId} for settlement {SettlementId} still processing",
                                            settlement.TransferId, settlement.Id);
                                        break;
                                }

                                brandSettlementRepo.Update(settlement);
                            }
                            catch (Exception ex)
                            {
                                _logger.LogError(ex,
                                    "Error checking transfer {TransferId} for settlement {SettlementId}",
                                    settlement.TransferId, settlement.Id);
                            }
                        }

                        await brandSettlementRepo.SaveChangesAsync();

                        await auditLogRepo.AddAsync(new FinancialAuditLog
                        {
                            Action = "PayoutStatusPolling",
                            EntityType = "BrandSettlement",
                            EntityId = batch.First().Id,
                            NewValues = JsonSerializer.Serialize(new
                            {
                                processedCount = batch.Count,
                                transferIds = batch.Select(s => s.TransferId).ToList()
                            }),
                            PerformedBy = "System",
                            Notes = $"Polled status for {batch.Count} settlements"
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in PayoutStatusProcessor");
            }

            await Task.Delay(PollingInterval, stoppingToken);
        }

        _logger.LogInformation("PayoutStatusProcessor stopped");
    }
}
