using ConsultaAlumnos.API.Entities;
using InformacionCiudades.API.DBContexts;
using Microsoft.EntityFrameworkCore;

namespace ConsultaAlumnos.API.Data
{
    public class StudentRepository : Repository, IStudentRepository
    {
        public StudentRepository(StudentsQuestionsContext context) : base(context)
        {
        }

        public ICollection<Subject> GetStudentSubjects(int studentId) =>
            _context.Students.Include(a => a.SubjectsAttended).ThenInclude(m => m.Professors).Where(a => a.Id == studentId)
            .Select(a => a.SubjectsAttended).FirstOrDefault() ?? new List<Subject>();

        public Student? GetStudentById(int userId) => _context.Students.Find(userId);
    }
}
