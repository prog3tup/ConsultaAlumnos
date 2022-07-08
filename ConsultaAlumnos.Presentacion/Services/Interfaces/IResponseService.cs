using ConsultaAlumnos.API.Models.Responses;

namespace ConsultaAlumnos.API.Services.Interfaces
{
    public interface IResponseService
    {
        ResponseDto CreateResponse(ResponseForCreationDto newResponse, int questionId, int userId);
        ResponseDto? GetResponse(int responseId);
    }
}