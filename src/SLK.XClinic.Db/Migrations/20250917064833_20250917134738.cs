using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLK.XClinic.Db.Migrations
{
    /// <inheritdoc />
    public partial class _20250917134738 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "VETERNAY_CUSTOMER",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CitizenID",
                table: "VETERNAY_CUSTOMER",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "VETERNAY_CUSTOMER",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "VETERNAY_CUSTOMER");

            migrationBuilder.DropColumn(
                name: "CitizenID",
                table: "VETERNAY_CUSTOMER");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "VETERNAY_CUSTOMER");
        }
    }
}
