using AutoMapper;
using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.Presentacion.Models;

namespace ConsultaAlumnos.API.Profiles
{
    public class ProfesorProfile : Profile
    {
        public ProfesorProfile()
        {
            CreateMap<Profesor, ProfesorDto>();
        }
    }
}
