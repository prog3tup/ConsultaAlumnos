using ConsultaAlumnos.API.Models.Consulta;

namespace ConsultaAlumnos.API.Services
{
    public interface IQuestionService
    {
        QuestionDto CreateQuestion(QuestionForCreationDto newQuestion, int userId);
        QuestionDto GetQuestion(int questionId);
    }
}