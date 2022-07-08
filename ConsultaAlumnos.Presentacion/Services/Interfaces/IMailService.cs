namespace ConsultaAlumnos.API.Services.Interfaces
{
    public interface IMailService
    {
        void Send(string subject, string message, string mailTo);
    }
}