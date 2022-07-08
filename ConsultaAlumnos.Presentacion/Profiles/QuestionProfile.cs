using AutoMapper;
using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models.Consulta;
using ConsultaAlumnos.API.Models.Question;

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
