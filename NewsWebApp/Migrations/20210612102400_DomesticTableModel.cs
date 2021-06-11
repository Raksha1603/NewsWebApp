using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsWebApp.Migrations
{
    public partial class DomesticTableModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "domestics",
                columns: table => new
                {
                    DId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_domestics", x => x.DId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "domestics");
        }
    }
}
