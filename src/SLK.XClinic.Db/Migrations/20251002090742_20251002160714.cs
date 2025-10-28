using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLK.XClinic.Db.Migrations
{
    /// <inheritdoc />
    public partial class _20251002160714 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "VETERNAY_BOOKING",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VETERNAY_BOOKING_PetId",
                table: "VETERNAY_BOOKING",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_VETERNAY_BOOKING_VETERNAY_PET_PetId",
                table: "VETERNAY_BOOKING",
                column: "PetId",
                principalTable: "VETERNAY_PET",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VETERNAY_BOOKING_VETERNAY_PET_PetId",
                table: "VETERNAY_BOOKING");

            migrationBuilder.DropIndex(
                name: "IX_VETERNAY_BOOKING_PetId",
                table: "VETERNAY_BOOKING");

            migrationBuilder.DropColumn(
                name: "PetId",
                table: "VETERNAY_BOOKING");
        }
    }
}
