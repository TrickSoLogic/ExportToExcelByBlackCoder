using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExportToExcelByBlackCoder.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blackcoder",
                columns: table => new
                {
                    Test1 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Test2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Test3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Test4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Test5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Test6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Test7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Test8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Test9 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blackcoder", x => x.Test1);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blackcoder");
        }
    }
}
