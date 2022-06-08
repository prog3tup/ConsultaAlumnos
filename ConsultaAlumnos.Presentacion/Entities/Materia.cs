namespace ConsultaAlumnos.API.Entities
{
    public class Materia
    {
        public int Id { get; set; }
        public ICollection<Materia> Profesores { get; set; } = new List<Materia>();
        public ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();
    }
}
