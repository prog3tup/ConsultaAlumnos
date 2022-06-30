using ConsultaAlumnos.API.Models.Responses;
using ConsultaAlumnos.Presentacion.Enums;

namespace ConsultaAlumnos.API.Models.Question
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProfessorId { get; set; }
        public int CreatorStudentId { get; set; }
        public int SubjectId { get; set; }
        public ICollection<ResponseDto> Responses { get; set; } = new List<ResponseDto>();
        public QuestionState QuestionState { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastModificationDate { get; set; }
    }
}
