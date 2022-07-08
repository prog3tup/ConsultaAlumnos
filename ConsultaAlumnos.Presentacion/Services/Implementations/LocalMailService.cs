using ConsultaAlumnos.API.Services.Interfaces;

namespace ConsultaAlumnos.API.Services.Implementations
{
    public class LocalMailService : IMailService
    {
        private readonly string _mailFrom = string.Empty;

        public LocalMailService(IConfiguration configuration)
        {
            _mailFrom = configuration["mailSettings:mailFromAddress"];
        }

        public void Send(string subject, string message, string mailTo)
        {
            Console.WriteLine($"Mail de {_mailFrom} a {mailTo}, " +
                $"con {nameof(LocalMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Mensaje: {message}");
        }
    }
}
