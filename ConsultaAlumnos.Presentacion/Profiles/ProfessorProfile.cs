using AutoMapper;
using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.Presentacion.Models;

namespace ConsultaAlumnos.API.Profiles
{
    public class ProfessorProfile : Profile
    {
        public ProfessorProfile()
        {
            CreateMap<Professor, ProfessorDto>();
        }
    }
}
