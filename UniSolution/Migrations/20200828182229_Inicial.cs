using Microsoft.EntityFrameworkCore.Migrations;

namespace UniSolution.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tanque",
                columns: table => new
                {
                    Deposito = table.Column<string>(nullable: false),
                    Capacidade = table.Column<decimal>(nullable: false),
                    TipoDeProduto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanque", x => x.Deposito);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tanque");
        }
    }
}
