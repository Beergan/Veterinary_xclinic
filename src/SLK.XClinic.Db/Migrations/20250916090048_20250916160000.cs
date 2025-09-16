using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLK.XClinic.Db.Migrations
{
    /// <inheritdoc />
    public partial class _20250916160000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOB",
                table: "VETERNAY_PET");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "VETERNAY_PET",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "VETERNAY_PET");

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "VETERNAY_PET",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
