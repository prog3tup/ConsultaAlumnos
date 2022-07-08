using ConsultaAlumnos.API.Models.Question;

namespace ConsultaAlumnos.API.Services.Interfaces
{
    public interface IProfessorService
    {
        ICollection<QuestionDto> GetPendingQuestions(int userId, bool withResponses);
    }
}
