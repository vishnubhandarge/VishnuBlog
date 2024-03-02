using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VishnuBlog.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin");

            migrationBuilder.RenameTable(
                name: "UserLogin",
                newName: "Login");

            migrationBuilder.AddColumn<bool>(
                name: "RememberMe",
                table: "Login",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "RememberMe",
                table: "Login");

            migrationBuilder.RenameTable(
                name: "Login",
                newName: "UserLogin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin",
                column: "Email");
        }
    }
}
