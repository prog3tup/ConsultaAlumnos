using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.Presentacion.Enums;
using InformacionCiudades.API.DBContexts;
using Microsoft.EntityFrameworkCore;

namespace ConsultaAlumnos.API.Data
{
    public class ProfessorRepository : Repository, IProfessorRepository
    {
        public ProfessorRepository(StudentsQuestionsContext context) : base(context)
        {

        }

        public IOrderedQueryable<Question> GetPendingQuestions(int userId, bool withResponses)
        {
            if (withResponses)
                return _context.Questions
                    .Include(q => q.Responses)
                    .Where(q => q.ProfessorId == userId && q.QuestionState == QuestionState.WaitingProfessorAnwser)
                    .OrderBy(q => q.LastModificationDate);
            return _context.Questions
                .Where(q => q.ProfessorId == userId && q.QuestionState == QuestionState.WaitingProfessorAnwser)
                .OrderBy(q => q.LastModificationDate);
        }

        public Professor? GetProfessorById(int userId) => _context.Professors.Find(userId);
    }
}
