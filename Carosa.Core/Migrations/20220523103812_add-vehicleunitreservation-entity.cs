using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carosa.Core.Migrations
{
    public partial class addvehicleunitreservationentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VehicleUnitReservations_VehicleUnitId",
                table: "VehicleUnitReservations");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUnitReservations_VehicleUnitId",
                table: "VehicleUnitReservations",
                column: "VehicleUnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VehicleUnitReservations_VehicleUnitId",
                table: "VehicleUnitReservations");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUnitReservations_VehicleUnitId",
                table: "VehicleUnitReservations",
                column: "VehicleUnitId",
                unique: true);
        }
    }
}
