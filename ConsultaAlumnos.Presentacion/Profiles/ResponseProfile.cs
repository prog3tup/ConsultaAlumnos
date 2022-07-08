using AutoMapper;
using ConsultaAlumnos.API.Models.Responses;

namespace ConsultaAlumnos.API.Profiles
{
    public class ResponseProfile : Profile
    {
        public ResponseProfile()
        {
            CreateMap<ResponseForCreationDto, Entities.Response>();
            CreateMap<Entities.Response, ResponseDto>();
        }
    }
}
