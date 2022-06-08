namespace ConsultaAlumnos.Presentacion.Models
{
    public class MateriaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int AnioCursado { get; set; }
        public IList<DocenteDto> Docentes { get; set; } = new List<DocenteDto>();
    }
}
