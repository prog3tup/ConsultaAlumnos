using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.Presentacion.Enums;
using InformacionCiudades.API.DBContexts;

namespace ConsultaAlumnos.API.Data
{
    public class ProfessorRepository : Repository, IProfessorRepository
    {
        public ProfessorRepository(StudentsQuestionsContext context) : base(context)
        {

        }

        public IOrderedQueryable<Question> GetPendingQuestions(int userId)
        {
            return _context.Questions.Where(q => q.ProfessorId == userId && q.QuestionState == QuestionState.WaitingProfessorAnwser).OrderBy(q => q.LastModificationDate);
        }
    }
}
