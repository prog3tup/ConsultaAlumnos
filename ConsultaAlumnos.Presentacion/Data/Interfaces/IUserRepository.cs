using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models;

namespace ConsultaAlumnos.API.Data
{
    public interface IUserRepository : IRepository
    {
        User? ValidateUser(AuthenticationRequestBody authenticationRequestBody);
        User? GetUserById(int userId);
    }
}