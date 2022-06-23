using ConsultaAlumnos.API.Entities;

namespace ConsultaAlumnos.API.Data
{
    public interface IQuestionRepository : IRepository
    {
        void AddQuestion(Question newQuestion);
        Question? GetQuestion(int questionId);
    }
}