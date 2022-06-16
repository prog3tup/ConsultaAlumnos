using ConsultaAlumnos.API.Models.Consulta;

namespace ConsultaAlumnos.API.Services
{
    public interface IConsultaService
    {
        ConsultaDto CrearConsulta(ConsultaParaCreacionDto nuevaConsulta, int userId);
        ConsultaDto GetConsulta(int idConsulta);
    }
}