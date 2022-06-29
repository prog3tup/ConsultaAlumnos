using ConsultaAlumnos.API.Entities;

namespace ConsultaAlumnos.API.Data
{
    public interface IStudentRepository
    {
        Student? GetStudentById(int userId);
        ICollection<Subject> GetStudentSubjects(int studentId);
    }
}