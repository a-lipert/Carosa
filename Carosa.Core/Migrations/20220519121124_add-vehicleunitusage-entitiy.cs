using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carosa.Core.Migrations
{
    public partial class addvehicleunitusageentitiy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleUnitUsages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    UsageEndedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    KilometersRun = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleUnitUsages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleUnitUsages_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleUnitUsages_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUnitUsages_CustomerId",
                table: "VehicleUnitUsages",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUnitUsages_VehicleId",
                table: "VehicleUnitUsages",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleUnitUsages");
        }
    }
}
