using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultaAlumnos.API.Migrations
{
    public partial class AddRelationsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AlumnoMateria",
                columns: new[] { "AlumnosId", "MateriasEnCursoId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlumnoMateria",
                keyColumns: new[] { "AlumnosId", "MateriasEnCursoId" },
                keyValues: new object[] { 1, 1 });
        }
    }
}
