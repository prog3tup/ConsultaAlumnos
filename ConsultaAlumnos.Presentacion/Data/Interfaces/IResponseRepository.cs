using ConsultaAlumnos.API.Entities;

namespace ConsultaAlumnos.API.Data
{
    public interface IResponseRepository : IRepository
    {
        void AddResponse(Response newResponse);
        Response? GetResponse(int responseId);
    }
}