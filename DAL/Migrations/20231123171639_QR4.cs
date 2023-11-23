using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class QR4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_profiles_Accounts_ProfileID",
                table: "profiles");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ProfileID",
                table: "Accounts",
                column: "ProfileID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_profiles_ProfileID",
                table: "Accounts",
                column: "ProfileID",
                principalTable: "profiles",
                principalColumn: "ProfileID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_profiles_ProfileID",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_ProfileID",
                table: "Accounts");

            migrationBuilder.AddForeignKey(
                name: "FK_profiles_Accounts_ProfileID",
                table: "profiles",
                column: "ProfileID",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
