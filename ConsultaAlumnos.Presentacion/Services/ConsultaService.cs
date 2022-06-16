using AutoMapper;
using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.API.Models.Consulta;
using ConsultaAlumnos.Presentacion.Enums;

namespace ConsultaAlumnos.API.Services
{
    public class ConsultaService : IConsultaService
    {
        private readonly IMapper _mapper;
        private readonly IConsultaRepository _repository;

        public ConsultaService(IMapper mapper, IConsultaRepository repository)
        {
            this._mapper = mapper;
            this._repository = repository;
        }
        public ConsultaDto CrearConsulta(ConsultaParaCreacionDto consultaACrear, int userId)
        {
            var nuevaConsulta = _mapper.Map<Entities.Consulta>(consultaACrear);

            nuevaConsulta.EstadoConsulta = EstadoConsulta.EsperandoRespuestaProfesor;
            nuevaConsulta.FechaCreacion = DateTime.Now;
            nuevaConsulta.FechaUltimaModificacion = DateTime.Now;
            nuevaConsulta.IdAlumnoCreador = userId;

            _repository.AgregarConsulta(nuevaConsulta);
            _repository.GuardarCambios();

            return _mapper.Map<ConsultaDto>(nuevaConsulta);
        }

        public ConsultaDto? GetConsulta(int idConsulta)
        {
            var consulta = _repository.GetConsulta(idConsulta);
            return _mapper.Map<ConsultaDto?>(consulta);
        }
    }
}
