using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpellCasters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellCasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MagicSpells",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Damage = table.Column<int>(nullable: false),
                    SpellCasterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicSpells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicSpells_SpellCasters_SpellCasterId",
                        column: x => x.SpellCasterId,
                        principalTable: "SpellCasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MagicSpells_SpellCasterId",
                table: "MagicSpells",
                column: "SpellCasterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MagicSpells");

            migrationBuilder.DropTable(
                name: "SpellCasters");
        }
    }
}
