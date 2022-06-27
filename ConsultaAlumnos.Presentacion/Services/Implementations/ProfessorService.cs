using AutoMapper;
using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.API.Models.Question;
using ConsultaAlumnos.API.Services.Interfaces;

namespace ConsultaAlumnos.API.Services.Implementations
{
    public class ProfessorService : IProfessorService
    {
        private readonly IMapper _mapper;
        private readonly IProfessorRepository _professorRepository;

        public ProfessorService(IMapper mapper, IProfessorRepository professorRepository)
        {
            _mapper = mapper;
            _professorRepository = professorRepository;
        }
        public ICollection<QuestionDto> GetPendingQuestions(int userId, bool withResponses)
        {
            var questions = _professorRepository.GetPendingQuestions(userId, withResponses);
            return _mapper.Map<List<QuestionDto>>(questions);
        }
    }
}
