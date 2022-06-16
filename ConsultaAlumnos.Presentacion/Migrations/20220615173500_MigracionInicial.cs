using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultaAlumnos.API.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Cuatrimestre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    NombreUsuario = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlumnoMateria",
                columns: table => new
                {
                    AlumnosId = table.Column<int>(type: "INTEGER", nullable: false),
                    MateriasEnCursoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlumnoMateria", x => new { x.AlumnosId, x.MateriasEnCursoId });
                    table.ForeignKey(
                        name: "FK_AlumnoMateria_Materias_MateriasEnCursoId",
                        column: x => x.MateriasEnCursoId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlumnoMateria_Usuario_AlumnosId",
                        column: x => x.AlumnosId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    IdProfesor = table.Column<int>(type: "INTEGER", nullable: false),
                    IdAlumnoCreador = table.Column<int>(type: "INTEGER", nullable: false),
                    IdMateria = table.Column<int>(type: "INTEGER", nullable: false),
                    EstadoConsulta = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FechaUltimaModificacion = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultas_Materias_IdMateria",
                        column: x => x.IdMateria,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Usuario_IdAlumnoCreador",
                        column: x => x.IdAlumnoCreador,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Usuario_IdProfesor",
                        column: x => x.IdProfesor,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MateriaProfesor",
                columns: table => new
                {
                    MateriasAsignadasId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfesoresId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaProfesor", x => new { x.MateriasAsignadasId, x.ProfesoresId });
                    table.ForeignKey(
                        name: "FK_MateriaProfesor_Materias_MateriasAsignadasId",
                        column: x => x.MateriasAsignadasId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MateriaProfesor_Usuario_ProfesoresId",
                        column: x => x.ProfesoresId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mensaje = table.Column<string>(type: "TEXT", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IdCreador = table.Column<int>(type: "INTEGER", nullable: false),
                    IdConsulta = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Consultas_IdConsulta",
                        column: x => x.IdConsulta,
                        principalTable: "Consultas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Usuario_IdCreador",
                        column: x => x.IdCreador,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "Id", "Cuatrimestre", "Nombre" },
                values: new object[] { 1, "Tercer", "Programación 3" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Apellido", "Discriminator", "Email", "Nombre", "NombreUsuario", "Password" },
                values: new object[] { 1, "Bologna", "Alumno", "nbologna31@gmail.com", "Nicolas", "nbologna_alumno", "123456" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Apellido", "Discriminator", "Email", "Nombre", "NombreUsuario", "Password" },
                values: new object[] { 2, "Perez", "Alumno", "Jperez@gmail.com", "Juan", "jperez", "123456" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Apellido", "Discriminator", "Email", "Nombre", "NombreUsuario", "Password" },
                values: new object[] { 3, "Garcia", "Alumno", "pgarcia@gmail.com", "Pedro", "pgarcia", "123456" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Apellido", "Discriminator", "Email", "Nombre", "NombreUsuario", "Password" },
                values: new object[] { 4, "Bologna", "Profesor", "nbologna31@gmail.com", "Nicolas", "nbologna_profesor", "123456" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Apellido", "Discriminator", "Email", "Nombre", "NombreUsuario", "Password" },
                values: new object[] { 5, "Paez", "Profesor", "ppaez@gmail.com", "Pablo", "ppaez", "123456" });

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoMateria_MateriasEnCursoId",
                table: "AlumnoMateria",
                column: "MateriasEnCursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_IdAlumnoCreador",
                table: "Consultas",
                column: "IdAlumnoCreador");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_IdMateria",
                table: "Consultas",
                column: "IdMateria");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_IdProfesor",
                table: "Consultas",
                column: "IdProfesor");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaProfesor_ProfesoresId",
                table: "MateriaProfesor",
                column: "ProfesoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_IdConsulta",
                table: "Posts",
                column: "IdConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_IdCreador",
                table: "Posts",
                column: "IdCreador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlumnoMateria");

            migrationBuilder.DropTable(
                name: "MateriaProfesor");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
