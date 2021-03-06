using Microsoft.EntityFrameworkCore.Migrations;
using ProConvenios.Persistence.Contexto;


namespace ProConvenios.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Convenios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DtInicio = table.Column<string>(type: "TEXT", nullable: true),
                    DtFim = table.Column<string>(type: "TEXT", nullable: true),
                    ProcessoTCE = table.Column<string>(type: "TEXT", nullable: true),
                    LinkRedmine = table.Column<string>(type: "TEXT", nullable: true),
                    ObjetoAcordo = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convenios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Convenios");
        }
    }
}
