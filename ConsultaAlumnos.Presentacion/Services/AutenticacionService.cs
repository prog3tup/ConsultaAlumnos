using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models;

namespace ConsultaAlumnos.API.Services
{
    public class AutenticacionService : ICustomAuthenticationService
    {
        private readonly IUserRepository _profesorRepository;

        public AutenticacionService(IUserRepository profesorRepository)
        {
            this._profesorRepository = profesorRepository;
        }

        public User? ValidateUser(AuthenticationRequestBody authenticationRequest)
        {
            if (String.IsNullOrEmpty(authenticationRequest.UserName) || String.IsNullOrEmpty(authenticationRequest.Password))
                return null;

            return _profesorRepository.ValidateUser(authenticationRequest);
        }
    }
}
