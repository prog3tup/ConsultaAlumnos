using AutoMapper;
using ConsultaAlumnos.API.Data;
using ConsultaAlumnos.API.Services.Interfaces;
using ConsultaAlumnos.Presentacion.Models;

namespace ConsultaAlumnos.API.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public StudentService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public ICollection<SubjectDto> GetSubjectsByStudent(int studentId)
        {
            var subjects = _userRepository.GetStudentSubjects(studentId);

            return _mapper.Map<ICollection<SubjectDto>>(subjects);
        }
    }
}
