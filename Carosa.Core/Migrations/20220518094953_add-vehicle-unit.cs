using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carosa.Core.Migrations
{
    public partial class addvehicleunit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleUnit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    FirstUsageAt = table.Column<int>(type: "int", nullable: false),
                    CurrentLatitude = table.Column<double>(type: "float", nullable: false),
                    CurrentLongitude = table.Column<double>(type: "float", nullable: false),
                    NextService = table.Column<int>(type: "int", nullable: false),
                    ReportedBroken = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleUnit", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleUnit");
        }
    }
}
