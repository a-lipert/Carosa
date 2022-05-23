using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carosa.Core.Migrations
{
    public partial class addvehiclereservationentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleUnitReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleUnitId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ReservedUntill = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ReservationFulfilled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleUnitReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleUnitReservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleUnitReservations_VehicleUnits_VehicleUnitId",
                        column: x => x.VehicleUnitId,
                        principalTable: "VehicleUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUnitReservations_CustomerId",
                table: "VehicleUnitReservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUnitReservations_VehicleUnitId",
                table: "VehicleUnitReservations",
                column: "VehicleUnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleUnitReservations");
        }
    }
}
