using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models;
using InformacionCiudades.API.DBContexts;
using Microsoft.EntityFrameworkCore;

namespace ConsultaAlumnos.API.Data
{
    public class UserRepository : Repository, IUserRepository
    {
        public UserRepository(StudentsQuestionsContext context) : base(context)
        {
        }

        public ICollection<Subject> GetStudentSubjects(int studentId) =>
            _context.Students.Include(a => a.SubjectsAttended).ThenInclude(m => m.Professors).Where(a => a.Id == studentId)
            .Select(a => a.SubjectsAttended).FirstOrDefault() ?? new List<Subject>();

        public User? ValidateUser(AuthenticationRequestBody authenticationRequestBody)
        {
            if (authenticationRequestBody.UserType == "alumno")
                return _context.Students.FirstOrDefault(p => p.UserName == authenticationRequestBody.UserName && p.Password == authenticationRequestBody.Password);
            return _context.Professors.FirstOrDefault(p => p.UserName == authenticationRequestBody.UserName && p.Password == authenticationRequestBody.Password);
        }

        public Student? GetStudentById(int userId) => _context.Students.Find(userId);
        public Professor? GetProfessorById(int userId) => _context.Professors.Find(userId);
        public User? GetUserById(int userId)
        {
            User? user = GetGenericUser(userId);
            return user;
        }

        private User GetGenericUser(int userId)
        {
            var user = _context.Professors.Find(userId);
            if (user is null)
                return _context.Students.Find(userId);
            return user;
        }
    }
}
