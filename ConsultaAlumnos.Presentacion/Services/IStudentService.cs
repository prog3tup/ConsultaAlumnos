using ConsultaAlumnos.Presentacion.Models;

namespace ConsultaAlumnos.API.Services
{
    public interface IStudentService
    {
        ICollection<SubjectDto> GetSubjectsByStudent(int studentId);
    }
}