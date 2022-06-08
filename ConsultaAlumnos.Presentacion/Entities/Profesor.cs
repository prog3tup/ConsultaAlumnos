namespace ConsultaAlumnos.API.Entities
{
    public class Profesor : Usuario
    {
        public ICollection<Materia> MateriasAsignadas { get; set; } = new List<Materia>();

    }
}
