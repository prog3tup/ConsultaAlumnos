using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaAlumnos.API.Controllers
{
    [Route("api/subject")]
    [ApiController]
    [Authorize]
    public class SubjectController : ControllerBase
    {
    }
}
