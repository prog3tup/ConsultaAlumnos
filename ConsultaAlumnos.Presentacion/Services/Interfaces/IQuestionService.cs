using ConsultaAlumnos.API.Models.Consulta;
using ConsultaAlumnos.API.Models.Question;

namespace ConsultaAlumnos.API.Services.Interfaces
{
    public interface IQuestionService
    {
        QuestionDto CreateQuestion(QuestionForCreationDto newQuestion, int userId);
        QuestionDto GetQuestion(int questionId);
    }
}