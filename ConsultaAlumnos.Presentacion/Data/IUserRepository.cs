using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models;

namespace ConsultaAlumnos.API.Data
{
    public interface IUserRepository : IRepository
    {
        User? ValidateUser(AuthenticationRequestBody authenticationRequestBody);
        ICollection<Subject> GetStudentSubjects(int studentId);
        Student? GetStudentById(int userId);
        Professor? GetProfessorById(int userId);
    }
}