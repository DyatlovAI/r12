using Microsoft.EntityFrameworkCore.Migrations;

namespace r12.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    number = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tovari",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(nullable: true),
                    Klient = table.Column<string>(nullable: true),
                    Tovar = table.Column<string>(nullable: true),
                    kolichestvo = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tovari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tovari_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tovari_UserId",
                table: "Tovari",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tovari");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
