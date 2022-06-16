using ConsultaAlumnos.API.Entities;
using static ConsultaAlumnos.API.Controllers.AutenticacionController;

namespace ConsultaAlumnos.API.Services
{
    public interface IAutenticacionService
    {
        Usuario? AutenticarUsuario(AuthenticationRequestBody authenticationRequestBody);
    }
}