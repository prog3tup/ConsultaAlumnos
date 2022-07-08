using ConsultaAlumnos.API.Entities;
using InformacionCiudades.API.DBContexts;

namespace ConsultaAlumnos.API.Data
{
    public class ResponseRepository : Repository, IResponseRepository
    {
        public ResponseRepository(StudentsQuestionsContext context) : base(context)
        {
        }

        public void AddResponse(Response newResponse)
        {
            _context.Responses.Add(newResponse);
        }

        public Response? GetResponse(int responseId)
        {
            return _context.Responses.Find(responseId);
        }
    }
}
