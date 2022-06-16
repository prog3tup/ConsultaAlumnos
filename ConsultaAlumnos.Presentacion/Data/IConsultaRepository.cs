using ConsultaAlumnos.API.Entities;

namespace ConsultaAlumnos.API.Data
{
    public interface IConsultaRepository : IRepository
    {
        void AgregarConsulta(Consulta nuevaConsulta);
        Consulta? GetConsulta(int idConsulta);
    }
}