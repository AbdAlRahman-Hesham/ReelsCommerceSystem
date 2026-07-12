using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Common;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;
using ReelsCommerceSystem.Application.DTOs.Response.Finance;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.ShippingCompanyEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Domain.Enums.Finance;
using ReelsCommerceSystem.Domain.Services.Finance;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;
using System.Text.Json;

namespace ReelsCommerceSystem.Infrastructure.Services.Finance;

public class FinanceService : IFinanceService
{
    private readonly AppDbContext _context;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IBrandSettlementRepository _brandSettlementRepo;
    private readonly IShippingSettlementRepository _shippingSettlementRepo;
    private readonly IWithdrawalRequestRepository _withdrawalRequestRepo;
    private readonly IFinancialAuditLogRepository _auditLogRepo;
    private readonly IPayoutProvider _payoutProvider;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public FinanceService(
        AppDbContext context,
        IUnitOfWork unitOfWork,
        IBrandSettlementRepository brandSettlementRepo,
        IShippingSettlementRepository shippingSettlementRepo,
        IWithdrawalRequestRepository withdrawalRequestRepo,
        IFinancialAuditLogRepository auditLogRepo,
        IPayoutProvider payoutProvider,
        IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _unitOfWork = unitOfWork;
        _brandSettlementRepo = brandSettlementRepo;
        _shippingSettlementRepo = shippingSettlementRepo;
        _withdrawalRequestRepo = withdrawalRequestRepo;
        _auditLogRepo = auditLogRepo;
        _payoutProvider = payoutProvider;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task CalculateAndCreateSettlementsAsync(Order order)
    {
        if (order.IsFinancialCalculated)
            return;

        if (order.PaymentStatus != PaymentStatus.Paid)
            return;

        if (order.OrderProducts == null || !order.OrderProducts.Any())
        {
            var loaded = await _context.Entry(order)
                .Collection(o => o.OrderProducts)
                .Query()
                .ToListAsync();

            if (loaded == null || !loaded.Any())
                return;
        }

        var productSubtotal = order.OrderProducts.Sum(p => p.FinalPrice * p.Quantity);

        var (commission, brandAmount, shippingAmount) = FinancialCalculator.Calculate(
            productSubtotal, order.ShippingFee);

        order.ProductSubtotal = productSubtotal;
        order.ShippingFee = shippingAmount;
        order.PlatformCommission = commission;
        order.BrandAmount = brandAmount;
        order.ShippingCompanyAmount = shippingAmount;
        order.FinancialCalculatedAt = DateTime.UtcNow;
        order.IsFinancialCalculated = true;

        var brandIds = order.OrderProducts
            .Select(p => p.BrandId)
            .Distinct()
            .ToList();

        var brandCount = brandIds.Count;
        var brandCommissionSplit = commission / brandCount;

        foreach (var brandId in brandIds)
        {
            var brandProductTotal = order.OrderProducts
                .Where(p => p.BrandId == brandId)
                .Sum(p => p.FinalPrice * p.Quantity);

            var brandComm = Math.Round(brandProductTotal * FinancialCalculator.PlatformCommissionRate, 2);
            var brandNet = Math.Round(brandProductTotal - brandComm, 2);

            var settlement = new BrandSettlement
            {
                BrandId = brandId,
                OrderId = order.Id,
                GrossAmount = brandProductTotal,
                PlatformCommission = brandComm,
                NetAmount = brandNet,
                Status = SettlementStatus.Pending
            };

            await _brandSettlementRepo.AddAsync(settlement);

            await _auditLogRepo.AddAsync(new FinancialAuditLog
            {
                Action = "SettlementCreated",
                EntityType = "BrandSettlement",
                EntityId = settlement.Id,
                NewValues = JsonSerializer.Serialize(new
                {
                    brandId, orderId = order.Id, brandProductTotal, brandComm, brandNet
                }),
                PerformedBy = "System",
                Notes = $"Brand settlement created for order {order.Id}"
            });
        }

        var shippingSettlement = new ShippingSettlement
        {
            ShippingCompanyId = 1,
            OrderId = order.Id,
            Amount = order.ShippingFee,
            Status = ShippingSettlementStatus.Pending
        };
        await _shippingSettlementRepo.AddAsync(shippingSettlement);

        await _auditLogRepo.AddAsync(new FinancialAuditLog
        {
            Action = "SettlementCreated",
            EntityType = "ShippingSettlement",
            EntityId = shippingSettlement.Id,
            NewValues = JsonSerializer.Serialize(new
            {
                shippingCompanyId = 1, orderId = order.Id, amount = order.ShippingFee
            }),
            PerformedBy = "System",
            Notes = $"Shipping settlement created for order {order.Id}"
        });

        await _unitOfWork.SaveChangesAsync();
    }

    public async Task UpdateSettlementsOnDeliveryAsync(int orderId)
    {
        var brandSettlements = await _brandSettlementRepo.GetByOrderIdAsync(orderId);
        foreach (var s in brandSettlements.Where(s => s.Status == SettlementStatus.Pending))
        {
            s.Status = SettlementStatus.ReadyForWithdrawal;
            s.AvailableAt = DateTime.UtcNow;
            _brandSettlementRepo.Update(s);

            await _auditLogRepo.AddAsync(new FinancialAuditLog
            {
                Action = "SettlementStatusUpdated",
                EntityType = "BrandSettlement",
                EntityId = s.Id,
                OldValues = SettlementStatus.Pending.ToString(),
                NewValues = SettlementStatus.ReadyForWithdrawal.ToString(),
                PerformedBy = "System",
                Notes = $"Brand settlement {s.Id} set to ReadyForWithdrawal on order delivery"
            });
        }

        var shippingSettlements = await _shippingSettlementRepo.GetByOrderIdAsync(orderId);
        foreach (var s in shippingSettlements.Where(s => s.Status == ShippingSettlementStatus.Pending))
        {
            s.Status = ShippingSettlementStatus.ReadyToPay;
            _shippingSettlementRepo.Update(s);

            await _auditLogRepo.AddAsync(new FinancialAuditLog
            {
                Action = "SettlementStatusUpdated",
                EntityType = "ShippingSettlement",
                EntityId = s.Id,
                OldValues = ShippingSettlementStatus.Pending.ToString(),
                NewValues = ShippingSettlementStatus.ReadyToPay.ToString(),
                PerformedBy = "System",
                Notes = $"Shipping settlement {s.Id} set to ReadyToPay on order delivery"
            });
        }

        await _unitOfWork.SaveChangesAsync();
    }

    public async Task<BrandWalletSummaryDto> GetBrandWalletSummaryAsync(int brandId)
    {
        var pending = await _brandSettlementRepo.GetSumByBrandAndStatusAsync(brandId, SettlementStatus.Pending);
        var available = await _brandSettlementRepo.GetSumByBrandAndStatusAsync(brandId, SettlementStatus.ReadyForWithdrawal);
        var requested = await _brandSettlementRepo.GetSumByBrandAndStatusAsync(brandId, SettlementStatus.WithdrawalRequested);
        var paid = await _brandSettlementRepo.GetSumByBrandAndStatusAsync(brandId, SettlementStatus.Paid);

        var totalLifetime = pending + available + requested + paid;

        return new BrandWalletSummaryDto
        {
            PendingBalance = pending,
            AvailableBalance = available,
            RequestedBalance = requested,
            PaidBalance = paid,
            TotalLifetimeEarnings = totalLifetime
        };
    }

    public async Task<PagedResult<BrandSettlementDto>> GetBrandSettlementsAsync(int brandId, SettlementFilterDto filter)
    {
        var settlements = await _brandSettlementRepo.GetByBrandIdAsync(brandId, filter);

        var items = settlements.Select(MapToBrandSettlementDto).ToList();
        var totalCount = items.Count;

        var pagedItems = items
            .Skip((filter.PageIndex - 1) * filter.PageSize)
            .Take(filter.PageSize)
            .ToList();

        return new PagedResult<BrandSettlementDto>
        {
            Items = pagedItems,
            TotalCount = totalCount,
            PageIndex = filter.PageIndex,
            PageSize = filter.PageSize
        };
    }

    public async Task<WithdrawalRequestDto> CreateWithdrawalRequestAsync(int brandId, CreateWithdrawalReqDto request)
    {
        var available = await _brandSettlementRepo.GetSumByBrandAndStatusAsync(brandId, SettlementStatus.ReadyForWithdrawal);

        if (request.Amount > available)
            throw new BadRequestException("Insufficient available balance");

        if (request.Amount < FinancialCalculator.MinimumWithdrawalAmount)
            throw new BadRequestException($"Minimum withdrawal amount is {FinancialCalculator.MinimumWithdrawalAmount}");

        var withdrawalRequest = new WithdrawalRequest
        {
            BrandId = brandId,
            RequestedAmount = request.Amount,
            Status = WithdrawalRequestStatus.Pending
        };

        await _withdrawalRequestRepo.AddAsync(withdrawalRequest);

        var settlements = await _brandSettlementRepo.GetByBrandIdAsync(brandId,
            new SettlementFilterDto { Status = SettlementStatus.ReadyForWithdrawal });

        var remainingToWithdraw = request.Amount;
        foreach (var settlement in settlements.OrderBy(s => s.CreatedAt))
        {
            if (remainingToWithdraw <= 0) break;

            if (settlement.NetAmount <= remainingToWithdraw)
            {
                settlement.Status = SettlementStatus.WithdrawalRequested;
                settlement.Notes = $"Included in withdrawal request #{withdrawalRequest.Id}";
                _brandSettlementRepo.Update(settlement);
                remainingToWithdraw -= settlement.NetAmount;
            }
        }

        await _auditLogRepo.AddAsync(new FinancialAuditLog
        {
            Action = "WithdrawalRequested",
            EntityType = "WithdrawalRequest",
            EntityId = withdrawalRequest.Id,
            NewValues = JsonSerializer.Serialize(new { brandId, amount = request.Amount }),
            PerformedBy = brandId.ToString(),
            Notes = $"Withdrawal request for {request.Amount} EGP"
        });

        await _unitOfWork.SaveChangesAsync();

        return new WithdrawalRequestDto
        {
            Id = withdrawalRequest.Id,
            RequestedAmount = withdrawalRequest.RequestedAmount,
            Status = withdrawalRequest.Status,
            CreatedAt = withdrawalRequest.CreatedAt
        };
    }

    public async Task<List<WithdrawalRequestDto>> GetBrandWithdrawalHistoryAsync(int brandId)
    {
        var requests = await _withdrawalRequestRepo.GetByBrandIdAsync(brandId);
        return requests.Select(r => new WithdrawalRequestDto
        {
            Id = r.Id,
            RequestedAmount = r.RequestedAmount,
            Status = r.Status,
            CreatedAt = r.CreatedAt,
            ApprovedAt = r.ApprovedAt,
            PaidAt = r.PaidAt,
            PaymobTransferId = r.PaymobTransferId,
            Notes = r.Notes
        }).ToList();
    }

    public async Task<BrandPolicyDto> GetBrandPolicyAsync()
    {
        return new BrandPolicyDto
        {
            PlatformCommissionPercentage = FinancialCalculator.PlatformCommissionRate * 100,
            MinimumWithdrawalAmount = FinancialCalculator.MinimumWithdrawalAmount,
            WithdrawalRules = "Brands can request withdrawal once orders are delivered. Minimum withdrawal amount applies.",
            SettlementConditions = "Money becomes available only after orders are delivered.",
            WithdrawalProcessingTime = "Wallet transfers: instant. Bank transfers: 1-2 working days.",
            PaymentProvider = "Paymob",
            SupportContact = "support@paymob.com"
        };
    }

    public async Task<ShippingWalletSummaryDto> GetShippingWalletSummaryAsync(int shippingCompanyId)
    {
        var pending = await _shippingSettlementRepo.GetSumByCompanyAndStatusAsync(shippingCompanyId, ShippingSettlementStatus.Pending);
        var available = await _shippingSettlementRepo.GetSumByCompanyAndStatusAsync(shippingCompanyId, ShippingSettlementStatus.ReadyToPay);
        var paid = await _shippingSettlementRepo.GetSumByCompanyAndStatusAsync(shippingCompanyId, ShippingSettlementStatus.Paid);

        return new ShippingWalletSummaryDto
        {
            PendingBalance = pending,
            AvailableBalance = available,
            PaidBalance = paid,
            TotalLifetimeEarnings = pending + available + paid
        };
    }

    public async Task<List<ShippingSettlementDto>> GetShippingSettlementsAsync(int shippingCompanyId, SettlementFilterDto filter)
    {
        var settlements = await _shippingSettlementRepo.GetByCompanyIdAsync(shippingCompanyId, filter);
        return settlements.Select(s => new ShippingSettlementDto
        {
            Id = s.Id,
            OrderId = s.OrderId,
            OrderReference = s.Order?.Id.ToString() ?? "",
            Amount = s.Amount,
            Status = s.Status,
            PaidAt = s.PaidAt,
            PaymentReference = s.PaymentReference,
            Notes = s.Notes,
            CreatedAt = s.CreatedAt
        }).ToList();
    }

    public async Task<ShippingPolicyDto> GetShippingPolicyAsync()
    {
        return new ShippingPolicyDto
        {
            PaymentSchedule = "Payments are processed after successful delivery confirmation.",
            SettlementRules = "Shipping fees are settled in full after delivery.",
            DeliveryRequirements = "Order must be marked as Delivered for settlement to become available.",
            PaymentProcessingTime = "Wallet transfers: instant. Bank transfers: 1-2 working days.",
            SupportedPaymentMethod = "Bank transfer, Mobile wallet",
            SupportContact = "support@paymob.com"
        };
    }

    public async Task<AdminDashboardDto> GetAdminDashboardAsync()
    {
        var totalPendingBrand = await _context.BrandSettlements
            .Where(s => s.Status == SettlementStatus.Pending)
            .SumAsync(s => s.NetAmount);

        var totalAvailableBrand = await _context.BrandSettlements
            .Where(s => s.Status == SettlementStatus.ReadyForWithdrawal)
            .SumAsync(s => s.NetAmount);

        var totalPaidBrand = await _context.BrandSettlements
            .Where(s => s.Status == SettlementStatus.Paid)
            .SumAsync(s => s.NetAmount);

        var totalPendingShipping = await _context.ShippingSettlements
            .Where(s => s.Status == ShippingSettlementStatus.Pending)
            .SumAsync(s => s.Amount);

        var totalPaidShipping = await _context.ShippingSettlements
            .Where(s => s.Status == ShippingSettlementStatus.Paid)
            .SumAsync(s => s.Amount);

        var totalCommission = await _context.Orders
            .Where(o => o.IsFinancialCalculated)
            .SumAsync(o => o.PlatformCommission);

        var ordersWaitingSettlement = await _context.Orders
            .Where(o => o.PaymentStatus == PaymentStatus.Paid && !o.IsFinancialCalculated)
            .CountAsync();

        return new AdminDashboardDto
        {
            TotalPendingBrandBalance = totalPendingBrand,
            TotalAvailableBrandBalance = totalAvailableBrand,
            TotalPaidBrandBalance = totalPaidBrand,
            TotalPendingShippingBalance = totalPendingShipping,
            TotalPaidShippingBalance = totalPaidShipping,
            PlatformTotalCommission = totalCommission,
            OrdersWaitingSettlement = ordersWaitingSettlement
        };
    }

    public async Task<List<AdminBrandFinanceSummaryDto>> GetAdminBrandFinanceSummaryAsync()
    {
        var brands = await _context.Brands.ToListAsync();
        var result = new List<AdminBrandFinanceSummaryDto>();

        foreach (var brand in brands)
        {
            var pending = await _brandSettlementRepo.GetSumByBrandAndStatusAsync(brand.Id, SettlementStatus.Pending);
            var available = await _brandSettlementRepo.GetSumByBrandAndStatusAsync(brand.Id, SettlementStatus.ReadyForWithdrawal);
            var paid = await _brandSettlementRepo.GetSumByBrandAndStatusAsync(brand.Id, SettlementStatus.Paid);

            result.Add(new AdminBrandFinanceSummaryDto
            {
                BrandId = brand.Id,
                BrandName = brand.DisplayName,
                PendingBalance = pending,
                AvailableBalance = available,
                PaidBalance = paid,
                TotalLifetime = pending + available + paid
            });
        }

        return result;
    }

    public async Task<AdminBrandFinanceDetailDto> GetAdminBrandFinanceDetailAsync(int brandId)
    {
        var settlements = await _brandSettlementRepo.GetByBrandIdAsync(brandId);
        var withdrawals = await _withdrawalRequestRepo.GetByBrandIdAsync(brandId);

        var summary = (await GetAdminBrandFinanceSummaryAsync()).FirstOrDefault(x => x.BrandId == brandId)
            ?? new AdminBrandFinanceSummaryDto { BrandId = brandId, BrandName = "Unknown" };

        return new AdminBrandFinanceDetailDto
        {
            Summary = summary,
            Settlements = settlements.Select(MapToBrandSettlementDto).ToList(),
            WithdrawalHistory = withdrawals.Select(w => new WithdrawalRequestDto
            {
                Id = w.Id,
                RequestedAmount = w.RequestedAmount,
                Status = w.Status,
                CreatedAt = w.CreatedAt,
                ApprovedAt = w.ApprovedAt,
                PaidAt = w.PaidAt,
                PaymobTransferId = w.PaymobTransferId,
                Notes = w.Notes
            }).ToList()
        };
    }

    public async Task<List<AdminShippingFinanceSummaryDto>> GetAdminShippingFinanceSummaryAsync()
    {
        var companies = await _context.ShippingCompanies.ToListAsync();
        var result = new List<AdminShippingFinanceSummaryDto>();

        foreach (var company in companies)
        {
            var pending = await _shippingSettlementRepo.GetSumByCompanyAndStatusAsync(company.Id, ShippingSettlementStatus.Pending);
            var available = await _shippingSettlementRepo.GetSumByCompanyAndStatusAsync(company.Id, ShippingSettlementStatus.ReadyToPay);
            var paid = await _shippingSettlementRepo.GetSumByCompanyAndStatusAsync(company.Id, ShippingSettlementStatus.Paid);

            result.Add(new AdminShippingFinanceSummaryDto
            {
                ShippingCompanyId = company.Id,
                ShippingCompanyName = company.Name,
                PendingBalance = pending,
                AvailableBalance = available,
                PaidBalance = paid,
                TotalLifetime = pending + available + paid
            });
        }

        return result;
    }

    public async Task<AdminShippingFinanceDetailDto> GetAdminShippingFinanceDetailAsync(int companyId)
    {
        var settlements = await _shippingSettlementRepo.GetByCompanyIdAsync(companyId);

        var summary = (await GetAdminShippingFinanceSummaryAsync()).FirstOrDefault(x => x.ShippingCompanyId == companyId)
            ?? new AdminShippingFinanceSummaryDto { ShippingCompanyId = companyId, ShippingCompanyName = "Unknown" };

        return new AdminShippingFinanceDetailDto
        {
            Summary = summary,
            Settlements = settlements.Select(s => new ShippingSettlementDto
            {
                Id = s.Id,
                OrderId = s.OrderId,
                OrderReference = s.Order?.Id.ToString() ?? "",
                Amount = s.Amount,
                Status = s.Status,
                PaidAt = s.PaidAt,
                PaymentReference = s.PaymentReference,
                Notes = s.Notes,
                CreatedAt = s.CreatedAt
            }).ToList()
        };
    }

    public async Task PayBrandSettlementsAsync(string adminId, PayBrandSettlementsReqDto request, string? ipAddress = null)
    {
        IReadOnlyList<BrandSettlement> settlements;

        if (request.WithdrawalRequestId.HasValue)
        {
            var withdrawalRequest = await _withdrawalRequestRepo.GetByIdAsync(request.WithdrawalRequestId.Value);
            if (withdrawalRequest == null)
                throw new NotFoundException("Withdrawal request not found");

            if (withdrawalRequest.Status != WithdrawalRequestStatus.Pending && withdrawalRequest.Status != WithdrawalRequestStatus.Approved)
                throw new BadRequestException("Withdrawal request is not in a payable state");

            settlements = await _brandSettlementRepo.GetByBrandIdAsync(withdrawalRequest.BrandId,
                new SettlementFilterDto { Status = SettlementStatus.WithdrawalRequested });
        }
        else
        {
            settlements = await _brandSettlementRepo.GetByIdsAsync(request.SettlementIds);
        }

        if (settlements.Count == 0)
            throw new BadRequestException("No settlements found to pay");

        var invalidSettlements = settlements.Where(s => s.Status != SettlementStatus.ReadyForWithdrawal
                                                        && s.Status != SettlementStatus.WithdrawalRequested).ToList();
        if (invalidSettlements.Any())
            throw new BadRequestException($"Some settlements are not in a payable state. Invalid count: {invalidSettlements.Count}");

        var brandGroups = settlements.GroupBy(s => s.BrandId);

        foreach (var group in brandGroups)
        {
            var brand = await _context.Brands.FindAsync(group.Key);
            if (brand == null) continue;

            var totalNetAmount = group.Sum(s => s.NetAmount);

            if (!string.IsNullOrEmpty(brand.PayoutPhoneNumber))
            {
                var payoutRequest = new PayoutRequest
                {
                    Issuer = "vodafone",
                    Amount = totalNetAmount,
                    Msisdn = brand.PayoutPhoneNumber,
                    FullName = brand.DisplayName,
                    ClientReferenceId = Guid.NewGuid()
                };

                foreach (var settlement in group)
                {
                    settlement.Status = SettlementStatus.TransferInitiated;
                    settlement.LastTransferAttemptAt = DateTime.UtcNow;
                    settlement.PaidByAdminId = adminId;
                    _brandSettlementRepo.Update(settlement);
                }

                await _unitOfWork.SaveChangesAsync();

                var payoutResult = await _payoutProvider.CreateTransferAsync(payoutRequest);

                foreach (var settlement in group)
                {
                    settlement.TransferId = payoutResult.TransactionId;
                    settlement.TransferRawResponse = payoutResult.RawResponse;

                    if (payoutResult.Success)
                    {
                        if (payoutResult.DisbursementStatus == "success")
                        {
                            settlement.Status = SettlementStatus.Paid;
                            settlement.PaidAt = DateTime.UtcNow;
                            settlement.PaymentReference = payoutResult.TransactionId;
                        }
                        else if (payoutResult.DisbursementStatus == "pending")
                        {
                            settlement.Status = SettlementStatus.Processing;
                        }
                        else
                        {
                            settlement.Status = SettlementStatus.Failed;
                            settlement.RetryCount++;
                        }
                    }
                    else
                    {
                        settlement.Status = SettlementStatus.Failed;
                        settlement.RetryCount++;
                        settlement.Notes = payoutResult.StatusDescription;
                    }

                    _brandSettlementRepo.Update(settlement);
                }

                await _auditLogRepo.AddAsync(new FinancialAuditLog
                {
                    Action = "PayoutTransferInitiated",
                    EntityType = "BrandSettlement",
                    EntityId = group.Key,
                    NewValues = JsonSerializer.Serialize(new
                    {
                        brandId = group.Key,
                        amount = totalNetAmount,
                        transferId = payoutResult.TransactionId,
                        status = payoutResult.DisbursementStatus
                    }),
                    PerformedBy = adminId,
                    IpAddress = ipAddress,
                    Notes = $"Payout initiated for brand {brand.DisplayName}: {payoutResult.DisbursementStatus}"
                });
            }
            else
            {
                foreach (var settlement in group)
                {
                    settlement.Status = SettlementStatus.Paid;
                    settlement.PaidAt = DateTime.UtcNow;
                    settlement.PaidByAdminId = adminId;
                    settlement.PaymentReference = request.Reference ?? $"manual-{Guid.NewGuid():N}";
                    settlement.Notes = request.Notes;
                    _brandSettlementRepo.Update(settlement);
                }

                await _auditLogRepo.AddAsync(new FinancialAuditLog
                {
                    Action = "SettlementPaid",
                    EntityType = "BrandSettlement",
                    EntityId = group.Key,
                    NewValues = JsonSerializer.Serialize(new
                    {
                        brandId = group.Key,
                        amount = totalNetAmount,
                        reference = request.Reference
                    }),
                    PerformedBy = adminId,
                    IpAddress = ipAddress,
                    Notes = request.Notes ?? $"Manual payment for brand {brand.DisplayName}"
                });
            }
        }

        await _unitOfWork.SaveChangesAsync();
    }

    public async Task PayShippingSettlementsAsync(string adminId, PayShippingSettlementsReqDto request, string? ipAddress = null)
    {
        var settlements = await _shippingSettlementRepo.GetByIdsAsync(request.SettlementIds);

        if (settlements.Count == 0)
            throw new BadRequestException("No settlements found to pay");

        var invalidSettlements = settlements.Where(s => s.Status != ShippingSettlementStatus.ReadyToPay).ToList();
        if (invalidSettlements.Any())
            throw new BadRequestException("Some settlements are not ready to pay");

        foreach (var settlement in settlements)
        {
            settlement.Status = ShippingSettlementStatus.Paid;
            settlement.PaidAt = DateTime.UtcNow;
            settlement.PaidByAdminId = adminId;
            settlement.PaymentReference = request.Reference ?? $"shipping-{Guid.NewGuid():N}";
            settlement.Notes = request.Notes;
            _shippingSettlementRepo.Update(settlement);
        }

        await _auditLogRepo.AddAsync(new FinancialAuditLog
        {
            Action = "ShippingSettlementPaid",
            EntityType = "ShippingSettlement",
            EntityId = settlements.First().Id,
            NewValues = JsonSerializer.Serialize(new
            {
                settlementIds = request.SettlementIds,
                reference = request.Reference
            }),
            PerformedBy = adminId,
            IpAddress = ipAddress,
            Notes = request.Notes ?? $"Paid {settlements.Count} shipping settlements"
        });

        await _unitOfWork.SaveChangesAsync();
    }

    public async Task<AdminPolicyDto> GetAdminPolicyAsync()
    {
        return new AdminPolicyDto
        {
            CurrentCommission = FinancialCalculator.PlatformCommissionRate * 100,
            SettlementWorkflow = "Settlements are created automatically when an order is paid. Status changes to Ready on delivery.",
            WithdrawalWorkflow = "Brand requests withdrawal → Admin approves → Payment is processed via Paymob Payouts.",
            ShippingWorkflow = "Shipping settlements are created on order payment. Paid on delivery confirmation."
        };
    }

    private static BrandSettlementDto MapToBrandSettlementDto(BrandSettlement s)
    {
        return new BrandSettlementDto
        {
            Id = s.Id,
            OrderId = s.OrderId,
            OrderReference = s.Order?.Id.ToString() ?? "",
            GrossAmount = s.GrossAmount,
            PlatformCommission = s.PlatformCommission,
            NetAmount = s.NetAmount,
            Status = s.Status,
            AvailableAt = s.AvailableAt,
            PaidAt = s.PaidAt,
            TransferId = s.TransferId,
            PaymentReference = s.PaymentReference,
            Notes = s.Notes,
            CreatedAt = s.CreatedAt
        };
    }
}
