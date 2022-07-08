using ConsultaAlumnos.API.Entities;

namespace ConsultaAlumnos.API.Models.Responses
{
    public class ResponseDto
    {
        public int Id { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
        public User Creator { get; set; }
    }
}
