using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLK.XClinic.Db.Migrations
{
    /// <inheritdoc />
    public partial class _20250815141831 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OldValues",
                table: "SYSTEM_AUGDIT_LOG",
                newName: "IpAddress");

            migrationBuilder.RenameColumn(
                name: "NewValues",
                table: "SYSTEM_AUGDIT_LOG",
                newName: "ChangeValues");

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeGuid",
                table: "SYSTEM_AUGDIT_LOG",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeGuid",
                table: "SYSTEM_AUGDIT_LOG");

            migrationBuilder.RenameColumn(
                name: "IpAddress",
                table: "SYSTEM_AUGDIT_LOG",
                newName: "OldValues");

            migrationBuilder.RenameColumn(
                name: "ChangeValues",
                table: "SYSTEM_AUGDIT_LOG",
                newName: "NewValues");
        }
    }
}
