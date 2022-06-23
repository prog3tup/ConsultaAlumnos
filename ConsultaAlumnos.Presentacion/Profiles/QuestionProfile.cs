using AutoMapper;
using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models.Consulta;

namespace ConsultaAlumnos.API.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<QuestionForCreationDto, Question>();
            CreateMap<Question, QuestionDto>();
        }
    }
}
