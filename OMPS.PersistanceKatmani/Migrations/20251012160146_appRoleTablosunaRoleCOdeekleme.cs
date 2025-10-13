using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OMPS.PersistanceKatmani.Migrations
{
    /// <inheritdoc />
    public partial class appRoleTablosunaRoleCOdeekleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Roles");
        }
    }
}
