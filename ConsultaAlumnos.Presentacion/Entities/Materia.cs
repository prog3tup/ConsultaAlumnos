using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultaAlumnos.API.Entities
{
    public class Materia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cuatrimestre { get; set; }
        public ICollection<Profesor> Profesores { get; set; } = new List<Profesor>();
        public ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();
        public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}
