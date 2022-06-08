using ConsultaAlumnos.Presentacion.Enums;

namespace ConsultaAlumnos.Presentacion.Models
{
    public class ConsultaDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "Sin título";
        public string Descripcion { get; set; } = "Sin descripción";
        public EstadoConsulta Estado { get; set; }
        public AlumnoDto Creador { get; set; }
        public DocenteDto DocenteAsignado { get; set; }
        public List<AlumnoDto> Seguidores { get; set; } = new List<AlumnoDto>();
    }
}
