using Microsoft.EntityFrameworkCore.Migrations;

namespace WSClinica.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitaciones_Clinicas_ID",
                table: "Habitaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Especialidad_IdEspecialidad",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Medicos_IdMedico",
                table: "Pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicos",
                table: "Medicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habitaciones",
                table: "Habitaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clinicas",
                table: "Clinicas");

            migrationBuilder.RenameTable(
                name: "Pacientes",
                newName: "Paciente");

            migrationBuilder.RenameTable(
                name: "Medicos",
                newName: "Medico");

            migrationBuilder.RenameTable(
                name: "Habitaciones",
                newName: "Habitacion");

            migrationBuilder.RenameTable(
                name: "Clinicas",
                newName: "Clinica");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_IdMedico",
                table: "Paciente",
                newName: "IX_Paciente_IdMedico");

            migrationBuilder.RenameIndex(
                name: "IX_Medicos_IdEspecialidad",
                table: "Medico",
                newName: "IX_Medico_IdEspecialidad");

            migrationBuilder.RenameIndex(
                name: "IX_Habitaciones_ID",
                table: "Habitacion",
                newName: "IX_Habitacion_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente",
                column: "IdPaciente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medico",
                table: "Medico",
                column: "IdMedico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habitacion",
                table: "Habitacion",
                column: "IdHabitacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clinica",
                table: "Clinica",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitacion_Clinica_ID",
                table: "Habitacion",
                column: "ID",
                principalTable: "Clinica",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medico_Especialidad_IdEspecialidad",
                table: "Medico",
                column: "IdEspecialidad",
                principalTable: "Especialidad",
                principalColumn: "IdEspecialidad",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Medico_IdMedico",
                table: "Paciente",
                column: "IdMedico",
                principalTable: "Medico",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitacion_Clinica_ID",
                table: "Habitacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Medico_Especialidad_IdEspecialidad",
                table: "Medico");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Medico_IdMedico",
                table: "Paciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medico",
                table: "Medico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habitacion",
                table: "Habitacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clinica",
                table: "Clinica");

            migrationBuilder.RenameTable(
                name: "Paciente",
                newName: "Pacientes");

            migrationBuilder.RenameTable(
                name: "Medico",
                newName: "Medicos");

            migrationBuilder.RenameTable(
                name: "Habitacion",
                newName: "Habitaciones");

            migrationBuilder.RenameTable(
                name: "Clinica",
                newName: "Clinicas");

            migrationBuilder.RenameIndex(
                name: "IX_Paciente_IdMedico",
                table: "Pacientes",
                newName: "IX_Pacientes_IdMedico");

            migrationBuilder.RenameIndex(
                name: "IX_Medico_IdEspecialidad",
                table: "Medicos",
                newName: "IX_Medicos_IdEspecialidad");

            migrationBuilder.RenameIndex(
                name: "IX_Habitacion_ID",
                table: "Habitaciones",
                newName: "IX_Habitaciones_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes",
                column: "IdPaciente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicos",
                table: "Medicos",
                column: "IdMedico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habitaciones",
                table: "Habitaciones",
                column: "IdHabitacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clinicas",
                table: "Clinicas",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitaciones_Clinicas_ID",
                table: "Habitaciones",
                column: "ID",
                principalTable: "Clinicas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Especialidad_IdEspecialidad",
                table: "Medicos",
                column: "IdEspecialidad",
                principalTable: "Especialidad",
                principalColumn: "IdEspecialidad",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Medicos_IdMedico",
                table: "Pacientes",
                column: "IdMedico",
                principalTable: "Medicos",
                principalColumn: "IdMedico",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
