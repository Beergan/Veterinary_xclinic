using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SLK.XClinic.Db.Migrations
{
    /// <inheritdoc />
    public partial class _20250808214712 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdentityRole_CLAIM_AspNetRoles_RoleId",
                table: "IdentityRole_CLAIM");

            migrationBuilder.DropForeignKey(
                name: "FK_SA_USER_CLAIM_SA_USER_UserId",
                table: "SA_USER_CLAIM");

            migrationBuilder.DropForeignKey(
                name: "FK_SA_USER_LOGIN_SA_USER_UserId",
                table: "SA_USER_LOGIN");

            migrationBuilder.DropForeignKey(
                name: "FK_SA_USER_ROLE_AspNetRoles_RoleId",
                table: "SA_USER_ROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_SA_USER_ROLE_SA_USER_UserId",
                table: "SA_USER_ROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_SA_USER_TOKEN_SA_USER_UserId",
                table: "SA_USER_TOKEN");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SA_USER_TOKEN",
                table: "SA_USER_TOKEN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SA_USER_ROLE",
                table: "SA_USER_ROLE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SA_USER_LOGIN",
                table: "SA_USER_LOGIN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SA_USER_CLAIM",
                table: "SA_USER_CLAIM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SA_USER",
                table: "SA_USER");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityRole_CLAIM",
                table: "IdentityRole_CLAIM");

            migrationBuilder.RenameTable(
                name: "SA_USER_TOKEN",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "SA_USER_ROLE",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "SA_USER_LOGIN",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "SA_USER_CLAIM",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "SA_USER",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "IdentityRole_CLAIM",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_SA_USER_ROLE_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_SA_USER_LOGIN_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SA_USER_CLAIM_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityRole_CLAIM_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "SA_USER_TOKEN");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "SA_USER");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "SA_USER_ROLE");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "SA_USER_LOGIN");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "SA_USER_CLAIM");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "IdentityRole_CLAIM");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "SA_USER_ROLE",
                newName: "IX_SA_USER_ROLE_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "SA_USER_LOGIN",
                newName: "IX_SA_USER_LOGIN_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "SA_USER_CLAIM",
                newName: "IX_SA_USER_CLAIM_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "IdentityRole_CLAIM",
                newName: "IX_IdentityRole_CLAIM_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SA_USER_TOKEN",
                table: "SA_USER_TOKEN",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SA_USER",
                table: "SA_USER",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SA_USER_ROLE",
                table: "SA_USER_ROLE",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SA_USER_LOGIN",
                table: "SA_USER_LOGIN",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SA_USER_CLAIM",
                table: "SA_USER_CLAIM",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityRole_CLAIM",
                table: "IdentityRole_CLAIM",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRole_CLAIM_AspNetRoles_RoleId",
                table: "IdentityRole_CLAIM",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SA_USER_CLAIM_SA_USER_UserId",
                table: "SA_USER_CLAIM",
                column: "UserId",
                principalTable: "SA_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SA_USER_LOGIN_SA_USER_UserId",
                table: "SA_USER_LOGIN",
                column: "UserId",
                principalTable: "SA_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SA_USER_ROLE_AspNetRoles_RoleId",
                table: "SA_USER_ROLE",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SA_USER_ROLE_SA_USER_UserId",
                table: "SA_USER_ROLE",
                column: "UserId",
                principalTable: "SA_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SA_USER_TOKEN_SA_USER_UserId",
                table: "SA_USER_TOKEN",
                column: "UserId",
                principalTable: "SA_USER",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
