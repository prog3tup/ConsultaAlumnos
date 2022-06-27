using AutoMapper;
using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.API.Models.Consulta;
using ConsultaAlumnos.API.Models.Question;
using ConsultaAlumnos.API.Services.Interfaces;

namespace ConsultaAlumnos.API.Services.Implementations
{
    public class QuestionService : IQuestionService
    {
        private readonly IMapper _mapper;
        private readonly IQuestionRepository _repository;
        private readonly IMailService _mailService;
        private readonly IUserRepository _userRepository;

        public QuestionService(IMapper mapper, IQuestionRepository repository, IMailService mailService, IUserRepository userRepository)
        {
            _mapper = mapper;
            _repository = repository;
            _mailService = mailService;
            _userRepository = userRepository;
        }
        public QuestionDto CreateQuestion(QuestionForCreationDto newQuestionDto, int userId)
        {
            var newQuestion = _mapper.Map<Entities.Question>(newQuestionDto);

            newQuestion.CreatorStudentId = userId;

            var student = _userRepository.GetStudentById(userId);
            var professor = _userRepository.GetProfessorById(newQuestionDto.ProfessorId);

            _repository.AddQuestion(newQuestion);
            if (_repository.SaveChanges())
                _mailService.Send("Se creó una nueva consulta",
                    $"Usted tiene una nueva consulta asignada por parte del alumno: {student.Name} {student.LastName} ",
                    professor.Email);

            return _mapper.Map<QuestionDto>(newQuestion);
        }

        public QuestionDto? GetQuestion(int idConsulta)
        {
            var consulta = _repository.GetQuestion(idConsulta);
            return _mapper.Map<QuestionDto?>(consulta);
        }
    }
}
