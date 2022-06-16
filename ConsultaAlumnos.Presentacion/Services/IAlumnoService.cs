using ConsultaAlumnos.Presentacion.Models;

namespace ConsultaAlumnos.API.Services
{
    public interface IAlumnoService
    {
        ICollection<MateriaDto> GetMateriasDelAlumno(int idAlumno);
    }
}