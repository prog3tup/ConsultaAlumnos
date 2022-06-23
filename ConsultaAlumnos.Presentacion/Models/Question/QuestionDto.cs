using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.Presentacion.Enums;

namespace ConsultaAlumnos.API.Models.Consulta
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProfessorId { get; set; }
        public int CreatorStudentId { get; set; }
        public int SubjectId { get; set; }
        //public ICollection<Alumno> Seguidores { get; set; } = new List<Alumno>();
        public ICollection<Response> Responses { get; set; } = new List<Response>();
        public QuestionState QuestionState { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastModificationDate { get; set; }
    }
}
