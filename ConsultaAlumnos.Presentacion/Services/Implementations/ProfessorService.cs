using AutoMapper;
using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.API.Models.Question;
using ConsultaAlumnos.API.Services.Interfaces;

namespace ConsultaAlumnos.API.Services.Implementations
{
    public class ProfessorService : IProfessorService
    {
        private readonly IMapper _mapper;
        private readonly IQuestionRepository _questionRepository;

        public ProfessorService(IMapper mapper, IQuestionRepository questionRepository)
        {
            _mapper = mapper;
            _questionRepository = questionRepository;
        }
        public ICollection<QuestionDto> GetPendingQuestions(int userId, bool withResponses)
        {
            var questions = _questionRepository.GetPendingQuestions(userId, withResponses);
            return _mapper.Map<List<QuestionDto>>(questions);
        }
    }
}
