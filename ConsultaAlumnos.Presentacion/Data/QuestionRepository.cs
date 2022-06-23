using ConsultaAlumnos.API.Entities;
using InformacionCiudades.API.DBContexts;

namespace ConsultaAlumnos.API.Data
{
    public class QuestionRepository : Repository, IQuestionRepository
    {
        public QuestionRepository(StudentsQuestionsContext context) : base(context)
        {
        }

        public void AddQuestion(Question newQuestion)
        {
            _context.Questions.Add(newQuestion);
        }

        public Question? GetQuestion(int questionId)
        {
            return _context.Questions.FirstOrDefault(c => c.Id == questionId);
        }
    }
}
