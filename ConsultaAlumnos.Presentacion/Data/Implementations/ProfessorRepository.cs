using ConsultaAlumnos.API.Entities;
using InformacionCiudades.API.DBContexts;

namespace ConsultaAlumnos.API.Data
{
    public class ProfessorRepository : Repository, IProfessorRepository
    {
        public ProfessorRepository(StudentsQuestionsContext context) : base(context)
        {

        }

        public Professor? GetProfessorById(int userId) => _context.Professors.Find(userId);
    }
}
