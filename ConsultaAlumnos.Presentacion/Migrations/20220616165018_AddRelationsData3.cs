using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultaAlumnos.API.Migrations
{
    public partial class AddRelationsData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MateriaProfesor",
                columns: new[] { "MateriasAsignadasId", "ProfesoresId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "MateriaProfesor",
                columns: new[] { "MateriasAsignadasId", "ProfesoresId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "MateriaProfesor",
                columns: new[] { "MateriasAsignadasId", "ProfesoresId" },
                values: new object[] { 2, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MateriaProfesor",
                keyColumns: new[] { "MateriasAsignadasId", "ProfesoresId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "MateriaProfesor",
                keyColumns: new[] { "MateriasAsignadasId", "ProfesoresId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "MateriaProfesor",
                keyColumns: new[] { "MateriasAsignadasId", "ProfesoresId" },
                keyValues: new object[] { 2, 4 });
        }
    }
}
