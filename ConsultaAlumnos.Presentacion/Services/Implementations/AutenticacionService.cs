using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models;
using ConsultaAlumnos.API.Services.Interfaces;

namespace ConsultaAlumnos.API.Services.Implementations
{
    public class AutenticacionService : ICustomAuthenticationService
    {
        private readonly IUserRepository _profesorRepository;

        public AutenticacionService(IUserRepository profesorRepository)
        {
            _profesorRepository = profesorRepository;
        }

        public User? ValidateUser(AuthenticationRequestBody authenticationRequest)
        {
            if (string.IsNullOrEmpty(authenticationRequest.UserName) || string.IsNullOrEmpty(authenticationRequest.Password))
                return null;

            return _profesorRepository.ValidateUser(authenticationRequest);
        }
    }
}
