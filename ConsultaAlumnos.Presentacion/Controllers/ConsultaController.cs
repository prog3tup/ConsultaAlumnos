using ConsultaAlumnos.API.Models.Consulta;
using ConsultaAlumnos.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ConsultaAlumnos.API.Controllers
{
    [Route("api/consulta")]
    [ApiController]
    [Authorize]
    public class ConsultaController : ControllerBase
    {
        private readonly IConsultaService _consultaService;

        public ConsultaController(IConsultaService consultaService)
        {
            this._consultaService = consultaService;
        }

        [HttpGet("{idConsulta}", Name = "GetConsulta")]
        public ActionResult<ConsultaDto> GetConsulta(int idConsulta)
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
            {
                return Unauthorized();
            }

            var consulta = _consultaService.GetConsulta(idConsulta);

            if (consulta is null)
                return NotFound();

            if (consulta.IdAlumnoCreador != userId)
                return Forbid();

            return Ok(consulta);
        }

        [HttpPost]
        public ActionResult<ConsultaDto> CrearConsulta(ConsultaParaCreacionDto nuevaConsulta)
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (!int.TryParse(userIdClaim, out int userId))
            {
                return Unauthorized();
            }

            var consultaCreada = _consultaService.CrearConsulta(nuevaConsulta, userId);

            return CreatedAtRoute(//CreatedAtRoute es para q devuelva 201, el 200 de post.
                "GetConsulta", //El primer parámetro es el Name del endpoint que hace el Get
                new //El segundo los parametros q necesita ese endpoint
                {
                    idConsulta = consultaCreada.Id
                },
                consultaCreada);//El tercero es el objeto creado. 
        }
    }
}
