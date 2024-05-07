using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveANiceDeath.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateCurseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurseName",
                table: "Curses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurseName",
                table: "Curses");
        }
    }
}
