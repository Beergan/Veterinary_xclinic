using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLK.XClinic.Db.Migrations
{
    /// <inheritdoc />
    public partial class _20251006165421 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VETERNAY_MEDICATION_ATTRIBUTE");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "VETERNAY_MEDICATION",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ImportPrice",
                table: "VETERNAY_MEDICATION",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "MedicationCode",
                table: "VETERNAY_MEDICATION",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecommendedDosage",
                table: "VETERNAY_MEDICATION",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StockQuantity",
                table: "VETERNAY_MEDICATION",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UnitType",
                table: "VETERNAY_MEDICATION",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VETERNAY_MEDICATION_CATEGORY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserModified = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VETERNAY_MEDICATION_CATEGORY", x => x.Id);
                    table.UniqueConstraint("AK_VETERNAY_MEDICATION_CATEGORY_Guid", x => x.Guid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VETERNAY_MEDICATION_CategoryId",
                table: "VETERNAY_MEDICATION",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_VETERNAY_MEDICATION_VETERNAY_MEDICATION_CATEGORY_CategoryId",
                table: "VETERNAY_MEDICATION",
                column: "CategoryId",
                principalTable: "VETERNAY_MEDICATION_CATEGORY",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VETERNAY_MEDICATION_VETERNAY_MEDICATION_CATEGORY_CategoryId",
                table: "VETERNAY_MEDICATION");

            migrationBuilder.DropTable(
                name: "VETERNAY_MEDICATION_CATEGORY");

            migrationBuilder.DropIndex(
                name: "IX_VETERNAY_MEDICATION_CategoryId",
                table: "VETERNAY_MEDICATION");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "VETERNAY_MEDICATION");

            migrationBuilder.DropColumn(
                name: "ImportPrice",
                table: "VETERNAY_MEDICATION");

            migrationBuilder.DropColumn(
                name: "MedicationCode",
                table: "VETERNAY_MEDICATION");

            migrationBuilder.DropColumn(
                name: "RecommendedDosage",
                table: "VETERNAY_MEDICATION");

            migrationBuilder.DropColumn(
                name: "StockQuantity",
                table: "VETERNAY_MEDICATION");

            migrationBuilder.DropColumn(
                name: "UnitType",
                table: "VETERNAY_MEDICATION");

            migrationBuilder.CreateTable(
                name: "VETERNAY_MEDICATION_ATTRIBUTE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicationId = table.Column<int>(type: "int", nullable: false),
                    AttributeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AttributeValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Stock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserModified = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VETERNAY_MEDICATION_ATTRIBUTE", x => x.Id);
                    table.UniqueConstraint("AK_VETERNAY_MEDICATION_ATTRIBUTE_Guid", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_VETERNAY_MEDICATION_ATTRIBUTE_VETERNAY_MEDICATION_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "VETERNAY_MEDICATION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VETERNAY_MEDICATION_ATTRIBUTE_MedicationId",
                table: "VETERNAY_MEDICATION_ATTRIBUTE",
                column: "MedicationId");
        }
    }
}
