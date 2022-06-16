namespace ConsultaAlumnos.Presentacion.Models
{
    public class ProfesorDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto { get => Nombre + " " + Apellido; }
    }
}