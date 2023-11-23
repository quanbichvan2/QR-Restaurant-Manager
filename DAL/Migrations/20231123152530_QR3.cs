using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class QR3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ProductID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    RoleID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "tables",
                columns: table => new
                {
                    TableID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tables", x => x.TableID);
                });

            migrationBuilder.CreateTable(
                name: "voucherType",
                columns: table => new
                {
                    VoucherTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    VoucherName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voucherType", x => x.VoucherTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    RoleID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ProfileID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderHeader",
                columns: table => new
                {
                    OrderHeaderID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TableID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VAT = table.Column<double>(type: "float", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderHeader", x => x.OrderHeaderID);
                    table.ForeignKey(
                        name: "FK_orderHeader_tables_TableID",
                        column: x => x.TableID,
                        principalTable: "tables",
                        principalColumn: "TableID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "profiles",
                columns: table => new
                {
                    ProfileID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IdentifyCard = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    StaffShifts = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.ProfileID);
                    table.ForeignKey(
                        name: "FK_profiles_Accounts_ProfileID",
                        column: x => x.ProfileID,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderDetails",
                columns: table => new
                {
                    OrderDetailsID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProductID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    OrderHeaderID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderDetails", x => x.OrderDetailsID);
                    table.ForeignKey(
                        name: "FK_orderDetails_orderHeader_OrderHeaderID",
                        column: x => x.OrderHeaderID,
                        principalTable: "orderHeader",
                        principalColumn: "OrderHeaderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderDetails_products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "voucher",
                columns: table => new
                {
                    VoucherID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    VoucherTypeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    OrderHeaderID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voucher", x => x.VoucherID);
                    table.ForeignKey(
                        name: "FK_voucher_orderHeader_OrderHeaderID",
                        column: x => x.OrderHeaderID,
                        principalTable: "orderHeader",
                        principalColumn: "OrderHeaderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_voucher_voucherType_VoucherTypeID",
                        column: x => x.VoucherTypeID,
                        principalTable: "voucherType",
                        principalColumn: "VoucherTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_RoleID",
                table: "Accounts",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_OrderHeaderID",
                table: "orderDetails",
                column: "OrderHeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_ProductID",
                table: "orderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_orderHeader_TableID",
                table: "orderHeader",
                column: "TableID");

            migrationBuilder.CreateIndex(
                name: "IX_voucher_OrderHeaderID",
                table: "voucher",
                column: "OrderHeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_voucher_VoucherTypeID",
                table: "voucher",
                column: "VoucherTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderDetails");

            migrationBuilder.DropTable(
                name: "profiles");

            migrationBuilder.DropTable(
                name: "voucher");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "orderHeader");

            migrationBuilder.DropTable(
                name: "voucherType");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "tables");
        }
    }
}
