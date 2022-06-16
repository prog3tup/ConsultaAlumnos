using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.API.Entities;
using static ConsultaAlumnos.API.Controllers.AutenticacionController;

namespace ConsultaAlumnos.API.Services
{
    public class AutenticacionService : IAutenticacionService
    {
        private readonly IUsuarioRepository _profesorRepository;

        public AutenticacionService(IUsuarioRepository profesorRepository)
        {
            this._profesorRepository = profesorRepository;
        }

        public Usuario? AutenticarUsuario(AuthenticationRequestBody authenticationRequest)
        {
            if (String.IsNullOrEmpty(authenticationRequest.UserName) || String.IsNullOrEmpty(authenticationRequest.Password))
                return null;

            return _profesorRepository.ValidarUsuario(authenticationRequest);
        }
    }
}
