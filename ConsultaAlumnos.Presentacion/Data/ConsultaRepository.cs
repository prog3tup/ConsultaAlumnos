using ConsultaAlumnos.API.Entities;
using InformacionCiudades.API.DBContexts;

namespace ConsultaAlumnos.API.Data
{
    public class ConsultaRepository : Repository, IConsultaRepository
    {
        public ConsultaRepository(ConsultaAlumnosContext context) : base(context)
        {
        }

        public void AgregarConsulta(Consulta nuevaConsulta)
        {
            _context.Consultas.Add(nuevaConsulta);
        }

        public Consulta? GetConsulta(int idConsulta)
        {
            return _context.Consultas.FirstOrDefault(c => c.Id == idConsulta);
        }
    }
}
