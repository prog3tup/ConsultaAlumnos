using ConsultaAlumnos.API.Entities;
using InformacionCiudades.API.DBContexts;
using Microsoft.EntityFrameworkCore;
using static ConsultaAlumnos.API.Controllers.AutenticacionController;

namespace ConsultaAlumnos.API.Data
{
    public class UsuarioRepository : Repository, IUsuarioRepository
    {

        public UsuarioRepository(ConsultaAlumnosContext context) : base(context)
        {
        }

        public ICollection<Materia> GetMateriasDelAlumno(int idAlumno) =>
            _context.Alumnos.Include(a => a.MateriasEnCurso).ThenInclude(m => m.Profesores).Where(a => a.Id == idAlumno)
            .Select(a => a.MateriasEnCurso).FirstOrDefault() ?? new List<Materia>();

        public Usuario? ValidarUsuario(AuthenticationRequestBody authenticationRequestBody)
        {
            if (authenticationRequestBody.TipoUsuario == "alumno")
                return _context.Alumnos.FirstOrDefault(p => p.NombreUsuario == authenticationRequestBody.UserName && p.Password == authenticationRequestBody.Password);
            return _context.Profesores.FirstOrDefault(p => p.NombreUsuario == authenticationRequestBody.UserName && p.Password == authenticationRequestBody.Password);
        }
    }
}
