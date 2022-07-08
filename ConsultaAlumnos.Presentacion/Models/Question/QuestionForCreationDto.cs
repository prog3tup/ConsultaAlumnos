using System.ComponentModel.DataAnnotations;

namespace ConsultaAlumnos.API.Models.Consulta
{
    public class QuestionForCreationDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int ProfessorId { get; set; }
        [Required]
        public int SubjectId { get; set; }
    }
}
