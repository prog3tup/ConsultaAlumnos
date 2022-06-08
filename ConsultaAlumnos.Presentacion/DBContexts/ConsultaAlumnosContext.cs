using ConsultaAlumnos.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace InformacionCiudades.API.DBContexts
{
    public class ConsultaAlumnosContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; } //lo que hagamos con LINQ sobre estos DbSets lo va a transformar en consultas SQL
        public DbSet<Profesor> Profesores { get; set; } //Los warnings los podemos obviar porque DbContext se encarga de eso.
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Materia> Materias { get; set; }


        public ConsultaAlumnosContext(DbContextOptions<ConsultaAlumnosContext> options) : base(options) //Acá estamos llamando al constructor de DbContext que es el que acepta las opciones
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
