using AutoMapper;
using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.Presentacion.Models;

namespace ConsultaAlumnos.API.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public AlumnoService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            this._usuarioRepository = usuarioRepository;
            this._mapper = mapper;
        }
        public ICollection<MateriaDto> GetMateriasDelAlumno(int idAlumno)
        {
            var materias = _usuarioRepository.GetMateriasDelAlumno(idAlumno);

            return _mapper.Map<ICollection<MateriaDto>>(materias);
        }
    }
}
