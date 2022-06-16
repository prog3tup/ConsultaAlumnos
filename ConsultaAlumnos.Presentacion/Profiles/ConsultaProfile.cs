using AutoMapper;
using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models.Consulta;

namespace ConsultaAlumnos.API.Profiles
{
    public class ConsultaProfile : Profile
    {
        public ConsultaProfile()
        {
            CreateMap<ConsultaParaCreacionDto, Consulta>();
            CreateMap<Consulta, ConsultaDto>();
        }
    }
}
