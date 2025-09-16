using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLK.XClinic.Db.Migrations
{
    /// <inheritdoc />
    public partial class _20250915175116 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VETERNAY_CUSTOMER",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserModified = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VETERNAY_CUSTOMER", x => x.Id);
                    table.UniqueConstraint("AK_VETERNAY_CUSTOMER_Guid", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "VETERNAY_SERVICES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidServices = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserModified = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VETERNAY_SERVICES", x => x.Id);
                    table.UniqueConstraint("AK_VETERNAY_SERVICES_Guid", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "VETERNAY_PET",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidPet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Microchip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    EntityVeternayCustomerId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserModified = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VETERNAY_PET", x => x.Id);
                    table.UniqueConstraint("AK_VETERNAY_PET_Guid", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_VETERNAY_PET_VETERNAY_CUSTOMER_EntityVeternayCustomerId",
                        column: x => x.EntityVeternayCustomerId,
                        principalTable: "VETERNAY_CUSTOMER",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VETERNAY_BOOKING",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidBooking = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    GuidPet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicesId = table.Column<int>(type: "int", nullable: true),
                    GuidVisit = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidEmployee = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserModified = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VETERNAY_BOOKING", x => x.Id);
                    table.UniqueConstraint("AK_VETERNAY_BOOKING_Guid", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_VETERNAY_BOOKING_VETERNAY_CUSTOMER_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "VETERNAY_CUSTOMER",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VETERNAY_BOOKING_VETERNAY_SERVICES_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "VETERNAY_SERVICES",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VETERNAY_VISIT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidVisit = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidBooking = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Treatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFollowUpNeeded = table.Column<bool>(type: "bit", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    EntityVeternayBookingId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserModified = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VETERNAY_VISIT", x => x.Id);
                    table.UniqueConstraint("AK_VETERNAY_VISIT_Guid", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_VETERNAY_VISIT_VETERNAY_BOOKING_EntityVeternayBookingId",
                        column: x => x.EntityVeternayBookingId,
                        principalTable: "VETERNAY_BOOKING",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VETERNAY_BOOKING_CustomerId",
                table: "VETERNAY_BOOKING",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_VETERNAY_BOOKING_ServicesId",
                table: "VETERNAY_BOOKING",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_VETERNAY_PET_EntityVeternayCustomerId",
                table: "VETERNAY_PET",
                column: "EntityVeternayCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_VETERNAY_VISIT_EntityVeternayBookingId",
                table: "VETERNAY_VISIT",
                column: "EntityVeternayBookingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VETERNAY_PET");

            migrationBuilder.DropTable(
                name: "VETERNAY_VISIT");

            migrationBuilder.DropTable(
                name: "VETERNAY_BOOKING");

            migrationBuilder.DropTable(
                name: "VETERNAY_CUSTOMER");

            migrationBuilder.DropTable(
                name: "VETERNAY_SERVICES");
        }
    }
}
