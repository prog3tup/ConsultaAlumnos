using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models;
using InformacionCiudades.API.DBContexts;

namespace ConsultaAlumnos.API.Data
{
    public class UserRepository : Repository, IUserRepository
    {
        public UserRepository(StudentsQuestionsContext context) : base(context)
        {
        }

        public User? ValidateUser(AuthenticationRequestBody authRequestBody)
        {
            if (authRequestBody.UserType == "alumno")
                return _context.Students.FirstOrDefault(p => p.UserName == authRequestBody.UserName && p.Password == authRequestBody.Password);
            return _context.Professors.FirstOrDefault(p => p.UserName == authRequestBody.UserName && p.Password == authRequestBody.Password);
        }

        public User? GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }
    }
}
