using Microsoft.EntityFrameworkCore.Migrations;

namespace WSClinica.Migrations
{
    public partial class tercercaso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEspecialidad",
                table: "Medicos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    IdEspecialidad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.IdEspecialidad);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_IdEspecialidad",
                table: "Medicos",
                column: "IdEspecialidad");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Especialidad_IdEspecialidad",
                table: "Medicos",
                column: "IdEspecialidad",
                principalTable: "Especialidad",
                principalColumn: "IdEspecialidad",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Especialidad_IdEspecialidad",
                table: "Medicos");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_IdEspecialidad",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "IdEspecialidad",
                table: "Medicos");
        }
    }
}
