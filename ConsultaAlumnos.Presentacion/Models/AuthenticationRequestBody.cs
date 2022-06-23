namespace ConsultaAlumnos.API.Models
{
    public class AuthenticationRequestBody
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? UserType { get; set; }
    }
}
