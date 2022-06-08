using ConsultaAlumnos.Presentacion.Enums;

namespace ConsultaAlumnos.API.Entities
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Profesor Profesor { get; set; }
        public Alumno Creador { get; set; }
        public ICollection<Alumno> Seguidores { get; set; } = new List<Alumno>();
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public EstadoConsulta EstadoConsulta { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
