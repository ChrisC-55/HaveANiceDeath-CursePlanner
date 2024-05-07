using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveANiceDeath.Data.Migrations
{
    /// <inheritdoc />
    public partial class curseModelAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curses",
                columns: table => new
                {
                    CurseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurseColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurseRarity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurseRank = table.Column<int>(type: "int", nullable: false),
                    CurseImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curses", x => x.CurseID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curses");
        }
    }
}
