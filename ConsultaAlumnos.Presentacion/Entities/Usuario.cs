namespace ConsultaAlumnos.API.Entities
{
    public abstract class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
    }
}
