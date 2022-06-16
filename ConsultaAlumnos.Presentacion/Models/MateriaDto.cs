namespace ConsultaAlumnos.Presentacion.Models
{
    public class MateriaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<ProfesorDto> Profesores { get; set; } = new List<ProfesorDto>();

    }
}
