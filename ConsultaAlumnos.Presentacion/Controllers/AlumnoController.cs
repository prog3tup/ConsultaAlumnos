using ConsultaAlumnos.API.Services;
using ConsultaAlumnos.Presentacion.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConsultaAlumnos.API.Controllers
{
    [Route("api/alumno")]
    [ApiController]
    [Authorize]
    public class AlumnoController : ControllerBase
    {
        private readonly IAlumnoService _alumnoService;

        public AlumnoController(IAlumnoService alumnoService)
        {
            this._alumnoService = alumnoService;
        }
        [HttpGet("materias")]
        public ActionResult<ICollection<MateriaDto>> GetMaterias()
        {
            var user = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            return _alumnoService.GetMateriasDelAlumno(int.Parse(user)).ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
