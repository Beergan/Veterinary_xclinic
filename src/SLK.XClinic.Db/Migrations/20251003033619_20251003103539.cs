using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLK.XClinic.Db.Migrations
{
    /// <inheritdoc />
    public partial class _20251003103539 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "VETERNAY_MEDICAL_RECORD",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "VETERNAY_BOOKING",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "VETERNAY_MEDICAL_RECORD");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "VETERNAY_BOOKING");
        }
    }
}
