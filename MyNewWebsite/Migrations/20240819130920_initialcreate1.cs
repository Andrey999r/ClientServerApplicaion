using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyNewWebsite.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "User",
                newName: "Login");

            migrationBuilder.AddColumn<int>(
                name: "Password",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "User",
                newName: "Name");
        }
    }
}
