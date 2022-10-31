using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository_Test.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    employeeCode = table.Column<string>(nullable: true),
                    employeeName = table.Column<string>(nullable: true),
                    employeeDesignation = table.Column<string>(nullable: true),
                    employeeSalary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    productCode = table.Column<string>(nullable: true),
                    productName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "salesInvoiceMasters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(nullable: true),
                    Quantity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesInvoiceMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "salesInvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    productId = table.Column<int>(nullable: true),
                    salesInvoiceMasterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesInvoiceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_salesInvoiceDetails_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salesInvoiceDetails_salesInvoiceMasters_salesInvoiceMasterId",
                        column: x => x.salesInvoiceMasterId,
                        principalTable: "salesInvoiceMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_salesInvoiceDetails_productId",
                table: "salesInvoiceDetails",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_salesInvoiceDetails_salesInvoiceMasterId",
                table: "salesInvoiceDetails",
                column: "salesInvoiceMasterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "salesInvoiceDetails");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "salesInvoiceMasters");
        }
    }
}
