using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReelsCommerceSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddFinanceModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BrandAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinancialCalculatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinancialCalculated",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "PlatformCommission",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProductSubtotal",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingCompanyAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingFee",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "BankAccountNumber",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankCode",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PayoutPhoneNumber",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BrandSettlements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    GrossAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlatformCommission = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AvailableAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaidAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaidByAdminId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentReference = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TransferId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TransferRawResponse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetryCount = table.Column<int>(type: "int", nullable: false),
                    LastTransferAttemptAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandSettlements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrandSettlements_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BrandSettlements_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FinancialAuditLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerformedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialAuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WithdrawalRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    RequestedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ApprovedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaidAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymobTransferId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawalRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WithdrawalRequests_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShippingSettlements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingCompanyId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PaidAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaidByAdminId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentReference = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingSettlements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingSettlements_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShippingSettlements_ShippingCompanies_ShippingCompanyId",
                        column: x => x.ShippingCompanyId,
                        principalTable: "ShippingCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BankAccountNumber", "BankCode", "PayoutPhoneNumber" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BankAccountNumber", "BankCode", "PayoutPhoneNumber" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BankAccountNumber", "BankCode", "PayoutPhoneNumber" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BankAccountNumber", "BankCode", "PayoutPhoneNumber" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BankAccountNumber", "BankCode", "PayoutPhoneNumber" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BankAccountNumber", "BankCode", "PayoutPhoneNumber" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BankAccountNumber", "BankCode", "PayoutPhoneNumber" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BankAccountNumber", "BankCode", "PayoutPhoneNumber" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BankAccountNumber", "BankCode", "PayoutPhoneNumber" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BankAccountNumber", "BankCode", "PayoutPhoneNumber" },
                values: new object[] { null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_BrandSettlements_BrandId_Status",
                table: "BrandSettlements",
                columns: new[] { "BrandId", "Status" });

            migrationBuilder.CreateIndex(
                name: "IX_BrandSettlements_OrderId",
                table: "BrandSettlements",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialAuditLogs_Action",
                table: "FinancialAuditLogs",
                column: "Action");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialAuditLogs_CreatedAt",
                table: "FinancialAuditLogs",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialAuditLogs_EntityType_EntityId",
                table: "FinancialAuditLogs",
                columns: new[] { "EntityType", "EntityId" });

            migrationBuilder.CreateIndex(
                name: "IX_ShippingCompanies_UserId",
                table: "ShippingCompanies",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingSettlements_OrderId",
                table: "ShippingSettlements",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingSettlements_ShippingCompanyId_Status",
                table: "ShippingSettlements",
                columns: new[] { "ShippingCompanyId", "Status" });

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawalRequests_BrandId_Status",
                table: "WithdrawalRequests",
                columns: new[] { "BrandId", "Status" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandSettlements");

            migrationBuilder.DropTable(
                name: "FinancialAuditLogs");

            migrationBuilder.DropTable(
                name: "ShippingSettlements");

            migrationBuilder.DropTable(
                name: "WithdrawalRequests");

            migrationBuilder.DropTable(
                name: "ShippingCompanies");

            migrationBuilder.DropColumn(
                name: "BrandAmount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FinancialCalculatedAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsFinancialCalculated",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PlatformCommission",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductSubtotal",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingCompanyAmount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingFee",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BankAccountNumber",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "BankCode",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "PayoutPhoneNumber",
                table: "Brands");
        }
    }
}
