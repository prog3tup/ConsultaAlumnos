namespace ConsultaAlumnos.API.Entities
{
    public class Alumno : Usuario
    {
        public ICollection<Materia> MateriasEnCurso { get; set; } = new List<Materia>();
    }
}
