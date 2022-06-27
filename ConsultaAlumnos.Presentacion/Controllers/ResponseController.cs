using ConsultaAlumnos.API.Models.Responses;
using ConsultaAlumnos.API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ConsultaAlumnos.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/question/{questionId}/response")]
    public class ResponseController : ControllerBase
    {
        private readonly IResponseService _responseService;
        private readonly IQuestionService _questionService;

        public ResponseController(IResponseService responseService, IQuestionService questionService)
        {
            _responseService = responseService;
            this._questionService = questionService;
        }

        [HttpGet("{responseId}", Name = "GetResponse")]
        public ActionResult<ResponseDto> GetQuestion(int responseId)
        {
            var response = _responseService.GetResponse(responseId);

            if (response is null)
                return NotFound();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateResponse(int questionId, ResponseForCreationDto newResponseForCreation)
        {
            if (!_questionService.IsQuestionIdValid(questionId))
                return NotFound($"Question Id not found: {questionId.ToString()}");
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var userId = int.Parse(userIdClaim);

            var newResponse = _responseService.CreateResponse(newResponseForCreation, questionId, userId);

            return CreatedAtRoute(
                "GetResponse",
                new { questionId = questionId, responseId = newResponse.Id },
                newResponse);
        }
    }
}
