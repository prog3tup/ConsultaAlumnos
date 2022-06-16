using ConsultaAlumnos.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace InformacionCiudades.API.DBContexts
{
    public class ConsultaAlumnosContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; } //lo que hagamos con LINQ sobre estos DbSets lo va a transformar en consultas SQL
        public DbSet<Profesor> Profesores { get; set; } //Los warnings los podemos obviar porque DbContext se encarga de eso.
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Respuesta> Posts { get; set; }
        public DbSet<Materia> Materias { get; set; }


        public ConsultaAlumnosContext(DbContextOptions<ConsultaAlumnosContext> options) : base(options) //Acá estamos llamando al constructor de DbContext que es el que acepta las opciones
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>().HasData(
                new Alumno
                {
                    Apellido = "Bologna",
                    Nombre = "Nicolas",
                    Email = "nbologna31@gmail.com",
                    NombreUsuario = "nbologna_alumno",
                    Password = "123456",
                    Id = 1
                },
                new Alumno
                {
                    Apellido = "Perez",
                    Nombre = "Juan",
                    Email = "Jperez@gmail.com",
                    NombreUsuario = "jperez",
                    Password = "123456",
                    Id = 2
                },
                new Alumno
                {
                    Apellido = "Garcia",
                    Nombre = "Pedro",
                    Email = "pgarcia@gmail.com",
                    NombreUsuario = "pgarcia",
                    Password = "123456",
                    Id = 3
                });

            modelBuilder.Entity<Profesor>().HasData(
                new Profesor
                {
                    Apellido = "Bologna",
                    Nombre = "Nicolas",
                    Email = "nbologna31@gmail.com",
                    NombreUsuario = "nbologna_profesor",
                    Password = "123456",
                    Id = 4
                },
                new Profesor
                {
                    Apellido = "Paez",
                    Nombre = "Pablo",
                    Email = "ppaez@gmail.com",
                    NombreUsuario = "ppaez",
                    Password = "123456",
                    Id = 5
                });

            modelBuilder.Entity<Materia>().HasData(
                new Materia
                {
                    Id = 1,
                    Nombre = "Programación 3",
                    Cuatrimestre = "Tercer"
                },
                new Materia
                {
                    Id = 2,
                    Nombre = "Programación 4",
                    Cuatrimestre = "Tercer"
                });

            modelBuilder.Entity<Materia>()
                .HasMany(x => x.Alumnos)
                .WithMany(x => x.MateriasEnCurso)
                .UsingEntity(j => j
                    .ToTable("AlumnoMateria")
                    .HasData(new[]
                        {
                            new { AlumnosId = 1, MateriasEnCursoId = 1},
                            new { AlumnosId = 1, MateriasEnCursoId = 2},
                        }
                    ));

            modelBuilder.Entity<Materia>()
                .HasMany(x => x.Profesores)
                .WithMany(x => x.MateriasAsignadas)
                .UsingEntity(j => j
                    .ToTable("MateriaProfesor")
                    .HasData(new[]
                        {
                            new { ProfesoresId = 4, MateriasAsignadasId = 1},
                            new { ProfesoresId = 5, MateriasAsignadasId = 1},
                            new { ProfesoresId = 4, MateriasAsignadasId = 2},
                        }
                    ));

            base.OnModelCreating(modelBuilder);
        }
    }
}
