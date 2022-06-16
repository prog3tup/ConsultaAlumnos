using AutoMapper;
using ConsultaAlumnos.Presentacion.Models;

namespace ConsultaAlumnos.API.Profiles
{
    public class MateriaProfile : Profile
    {
        public MateriaProfile()
        {
            CreateMap<Entities.Materia, MateriaDto>();
        }
    }
}
