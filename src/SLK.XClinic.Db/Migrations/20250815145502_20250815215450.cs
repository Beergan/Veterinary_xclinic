using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLK.XClinic.Db.Migrations
{
    /// <inheritdoc />
    public partial class _20250815215450 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_SYSTEM_AUGDIT_LOG_Guid",
                table: "SYSTEM_AUGDIT_LOG",
                column: "Guid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_SYSTEM_AUGDIT_LOG_Guid",
                table: "SYSTEM_AUGDIT_LOG");
        }
    }
}
