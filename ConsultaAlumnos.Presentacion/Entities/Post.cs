namespace ConsultaAlumnos.API.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public Usuario Creador { get; set; }
        public Consulta Consulta { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
