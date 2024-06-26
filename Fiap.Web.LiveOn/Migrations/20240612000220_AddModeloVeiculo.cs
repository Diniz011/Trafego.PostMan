using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Web.LiveOn.Migrations
{
    /// <inheritdoc />
    public partial class AddAcidentes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACIDENTES",
                columns: table => new
                {
                    AvenidaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Acidentes = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Congestionamentos = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    FarolQuebrado = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CamerasdaAvenida = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACIDENTES", x => x.AvenidaId);
                    table.ForeignKey(
                        name: "FK_ACIDENTES_TRAFEGO_AvenidaId",
                        column: x => x.AvenidaId,
                        principalTable: "ACIDENTES",
                        principalColumn: "AvenidaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ACIDENTES_AvenidaId",
                table: "ACIDENTES",
                column: "AvenidaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACIDENTES");
        }
    }
}
