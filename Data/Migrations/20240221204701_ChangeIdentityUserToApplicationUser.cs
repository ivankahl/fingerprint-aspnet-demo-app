using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FingerprintAspNetCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeIdentityUserToApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fingerprint",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fingerprint",
                table: "AspNetUsers");
        }
    }
}
