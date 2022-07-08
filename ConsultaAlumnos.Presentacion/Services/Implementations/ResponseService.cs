using AutoMapper;
using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.API.Entities;
using ConsultaAlumnos.API.Models.Responses;
using ConsultaAlumnos.API.Services.Interfaces;

namespace ConsultaAlumnos.API.Services.Implementations
{
    public class ResponseService : IResponseService
    {
        private readonly IMapper _mapper;
        private readonly IResponseRepository _responseRepository;
        private readonly IQuestionService _questionService;

        public ResponseService(IMapper mapper, IResponseRepository responseRepository, IQuestionService questionService)
        {
            this._mapper = mapper;
            this._responseRepository = responseRepository;
            this._questionService = questionService;
        }
        public ResponseDto CreateResponse(ResponseForCreationDto newResponse, int questionId, int userId)
        {
            var response = _mapper.Map<Response>(newResponse);

            response.QuestionId = questionId;
            response.CreatorId = userId;

            _responseRepository.AddResponse(response);
            _responseRepository.SaveChanges();

            _questionService.ChangeQuestionStatus(questionId);

            return _mapper.Map<ResponseDto>(response);
        }

        public ResponseDto? GetResponse(int responseId)
        {
            var response = _responseRepository.GetResponse(responseId);
            return _mapper.Map<ResponseDto>(response);
        }
    }
}
