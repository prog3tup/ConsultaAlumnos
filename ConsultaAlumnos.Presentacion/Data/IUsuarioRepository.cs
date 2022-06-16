using ConsultaAlumnos.API.Entities;
using static ConsultaAlumnos.API.Controllers.AutenticacionController;

namespace ConsultaAlumnos.API.Data
{
    public interface IUsuarioRepository : IRepository
    {
        Usuario? ValidarUsuario(AuthenticationRequestBody authenticationRequestBody);
        ICollection<Materia> GetMateriasDelAlumno(int idAlumno);
    }
}