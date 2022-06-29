using ConsultaAlumnos.API.Entities;

namespace ConsultaAlumnos.API.Data
{
    public interface IProfessorRepository
    {
        Professor? GetProfessorById(int userId);
    }
}