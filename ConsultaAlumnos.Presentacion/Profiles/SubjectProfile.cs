using AutoMapper;
using ConsultaAlumnos.Presentacion.Models;

namespace ConsultaAlumnos.API.Profiles
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<Entities.Subject, SubjectDto>();
        }
    }
}
