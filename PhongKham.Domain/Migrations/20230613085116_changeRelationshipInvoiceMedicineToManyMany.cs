using Microsoft.EntityFrameworkCore.Migrations;

namespace PhongKham.Infrastructure.Migrations
{
    public partial class changeRelationshipInvoiceMedicineToManyMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Invoices_InvoiceId",
                table: "Medicines");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_InvoiceId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Medicines");

            migrationBuilder.CreateTable(
                name: "InvoiceMedicine",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceMedicine", x => new { x.InvoiceId, x.MedicineId });
                    table.ForeignKey(
                        name: "FK_InvoiceMedicine_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceMedicine_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceMedicine_MedicineId",
                table: "InvoiceMedicine",
                column: "MedicineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceMedicine");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Medicines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_InvoiceId",
                table: "Medicines",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Invoices_InvoiceId",
                table: "Medicines",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
