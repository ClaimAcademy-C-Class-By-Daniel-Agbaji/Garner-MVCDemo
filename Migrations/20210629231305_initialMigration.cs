using Microsoft.EntityFrameworkCore.Migrations;

namespace AudioMVC.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAudioDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Amps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Headphones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAudioDevices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAudioDevices");
        }
    }
}
