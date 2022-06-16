using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaAlumnos.API.Controllers
{
    [Route("api/materia")]
    [ApiController]
    [Authorize]
    public class MateriaController : ControllerBase
    {
    }
}
