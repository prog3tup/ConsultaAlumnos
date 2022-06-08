﻿namespace ConsultaAlumnos.Presentacion.Models
{
    public class AlumnoDto
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellido;
            }
        }
        public IList<MateriaDto> MateriasEnCurso { get; set; } = new List<MateriaDto>();
    }
}