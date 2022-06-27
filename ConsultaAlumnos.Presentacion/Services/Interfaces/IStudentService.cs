using ConsultaAlumnos.Presentacion.Models;

namespace ConsultaAlumnos.API.Services.Interfaces
{
    public interface IStudentService
    {
        ICollection<SubjectDto> GetSubjectsByStudent(int studentId);
    }
}