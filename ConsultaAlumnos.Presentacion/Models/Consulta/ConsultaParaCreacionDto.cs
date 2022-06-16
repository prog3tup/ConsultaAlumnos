using System.ComponentModel.DataAnnotations;

namespace ConsultaAlumnos.API.Models.Consulta
{
    public class ConsultaParaCreacionDto
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int IdProfesor { get; set; }
        [Required]
        public int IdMateria { get; set; }
    }
}
