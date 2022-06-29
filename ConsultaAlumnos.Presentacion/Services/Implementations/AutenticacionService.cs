using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models;
using ConsultaAlumnos.API.Services.Interfaces;

namespace ConsultaAlumnos.API.Services.Implementations
{
    public class AutenticacionService : ICustomAuthenticationService
    {
        private readonly IUserRepository _userRepository;

        public AutenticacionService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User? ValidateUser(AuthenticationRequestBody authenticationRequest)
        {
            if (string.IsNullOrEmpty(authenticationRequest.UserName) || string.IsNullOrEmpty(authenticationRequest.Password))
                return null;

            return _userRepository.ValidateUser(authenticationRequest);
        }
    }
}
