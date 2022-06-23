using AutoMapper;
using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.API.Models.Consulta;
using ConsultaAlumnos.Presentacion.Enums;

namespace ConsultaAlumnos.API.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IMapper _mapper;
        private readonly IQuestionRepository _repository;

        public QuestionService(IMapper mapper, IQuestionRepository repository)
        {
            this._mapper = mapper;
            this._repository = repository;
        }
        public QuestionDto CreateQuestion(QuestionForCreationDto newQuestionDto, int userId)
        {
            var newQuestion = _mapper.Map<Entities.Question>(newQuestionDto);

            newQuestion.QuestionState = QuestionState.WaitingProfessorAnwser;
            newQuestion.CreationDate = DateTime.Now;
            newQuestion.LastModificationDate = DateTime.Now;
            newQuestion.CreatorStudentId = userId;

            _repository.AddQuestion(newQuestion);
            _repository.SaveChanges();

            return _mapper.Map<QuestionDto>(newQuestion);
        }

        public QuestionDto? GetQuestion(int idConsulta)
        {
            var consulta = _repository.GetQuestion(idConsulta);
            return _mapper.Map<QuestionDto?>(consulta);
        }
    }
}
