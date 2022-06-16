using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.Presentacion.Enums;

namespace ConsultaAlumnos.API.Models.Consulta
{
    public class ConsultaDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int IdProfesor { get; set; }
        public int IdAlumnoCreador { get; set; }
        public int IdMateria { get; set; }
        //public ICollection<Alumno> Seguidores { get; set; } = new List<Alumno>();
        public ICollection<Respuesta> Posts { get; set; } = new List<Respuesta>();
        public EstadoConsulta EstadoConsulta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public DateTime? FechaUltimaModificacion { get; set; }
    }
}
