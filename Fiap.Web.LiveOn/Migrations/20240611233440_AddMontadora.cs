using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Web.LiveOn.Migrations
{
    /// <inheritdoc />
    public partial class AddTrafego : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TRAFEGO",
                columns: table => new
                {
                    AvenidaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Acidentes = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Congestionamentos = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRAFEGO", x => x.AvenidaId);
                });

            migrationBuilder.CreateIndex(
                name: "IDX_PAIS_ANO",
                table: "TRAFEGO",
                columns: new[] { "Acidentes", "Congestionamentos" });

            migrationBuilder.CreateIndex(
                name: "IX_TRAFEGO_Nome",
                table: "TRAFEGO",
                column: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TRAFEGO");
        }
    }
}
