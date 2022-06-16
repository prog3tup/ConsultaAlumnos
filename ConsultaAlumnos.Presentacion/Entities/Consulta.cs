﻿using ConsultaAlumnos.Presentacion.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultaAlumnos.API.Entities
{
    public class Consulta
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        [ForeignKey("IdProfesor")]
        public Profesor ProfesorAsignado { get; set; }
        public int IdProfesor { get; set; }
        [ForeignKey("IdAlumnoCreador")]
        public Alumno Alumno { get; set; }
        public int IdAlumnoCreador { get; set; }
        [ForeignKey("IdMateria")]
        public Materia Materia { get; set; }
        public int IdMateria { get; set; }
        //public ICollection<Alumno> Seguidores { get; set; } = new List<Alumno>();
        public ICollection<Respuesta> Posts { get; set; } = new List<Respuesta>();
        public EstadoConsulta EstadoConsulta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public DateTime? FechaUltimaModificacion { get; set; }
    }
}
