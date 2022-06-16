using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultaAlumnos.API.Migrations
{
    public partial class AddRelationsData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "Id", "Cuatrimestre", "Nombre" },
                values: new object[] { 2, "Tercer", "Programación 4" });

            migrationBuilder.InsertData(
                table: "AlumnoMateria",
                columns: new[] { "AlumnosId", "MateriasEnCursoId" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlumnoMateria",
                keyColumns: new[] { "AlumnosId", "MateriasEnCursoId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
