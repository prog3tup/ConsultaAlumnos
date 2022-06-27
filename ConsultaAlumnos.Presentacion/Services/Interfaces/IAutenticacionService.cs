using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models;

namespace ConsultaAlumnos.API.Services.Interfaces
{
    public interface ICustomAuthenticationService
    {
        User? ValidateUser(AuthenticationRequestBody authenticationRequestBody);
    }
}