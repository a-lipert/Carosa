using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carosa.Core.Migrations
{
    public partial class addcustaddrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomeAddressId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceAddressId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "InvoiceAddressSameAsHome",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_HomeAddressId",
                table: "Customers",
                column: "HomeAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_InvoiceAddressId",
                table: "Customers",
                column: "InvoiceAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Address_HomeAddressId",
                table: "Customers",
                column: "HomeAddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Address_InvoiceAddressId",
                table: "Customers",
                column: "InvoiceAddressId",
                principalTable: "Address",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Address_HomeAddressId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Address_InvoiceAddressId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_HomeAddressId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_InvoiceAddressId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HomeAddressId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "InvoiceAddressId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "InvoiceAddressSameAsHome",
                table: "Customers");
        }
    }
}
