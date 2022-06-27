using ConsultaAlumnos.API.Models.Consulta;
using ConsultaAlumnos.API.Models.Question;
using ConsultaAlumnos.Presentacion.Enums;

namespace ConsultaAlumnos.API.Services.Interfaces
{
    public interface IQuestionService
    {
        QuestionDto CreateQuestion(QuestionForCreationDto newQuestion, int userId);
        QuestionDto GetQuestion(int questionId);
        bool IsQuestionIdValid(int questionId);
        void ChangeQuestionStatus(int questionId, QuestionState status);
        void ChangeQuestionStatus(int questionIdd);
    }
}