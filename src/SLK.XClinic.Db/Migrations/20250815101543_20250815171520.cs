using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLK.XClinic.Db.Migrations
{
    /// <inheritdoc />
    public partial class _20250815171520 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_SYSTEM_AUGDIT_LOG_Guid",
                table: "SYSTEM_AUGDIT_LOG");

            migrationBuilder.DropColumn(
                name: "RecordId",
                table: "SYSTEM_AUGDIT_LOG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecordId",
                table: "SYSTEM_AUGDIT_LOG",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_SYSTEM_AUGDIT_LOG_Guid",
                table: "SYSTEM_AUGDIT_LOG",
                column: "Guid");
        }
    }
}
