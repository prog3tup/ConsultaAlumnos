using ConsultaAlumnos.API.Entities;
using InformacionCiudades.API.DBContexts;
using Microsoft.EntityFrameworkCore;

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
            return _context.Questions
                .Include(q => q.AssignedProfessor)
                .Include(q => q.Student)
                .FirstOrDefault(c => c.Id == questionId);
        }

        public bool IsQuestionIdValid(int questionId)
        {
            return _context.Questions.Any(q => q.Id == questionId);
        }
    }
}
