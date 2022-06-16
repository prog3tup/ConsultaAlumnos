using InformacionCiudades.API.DBContexts;

namespace ConsultaAlumnos.API.Data
{
    public class Repository : IRepository
    {
        internal readonly ConsultaAlumnosContext _context;

        public Repository(ConsultaAlumnosContext context)
        {
            this._context = context;
        }

        public bool GuardarCambios()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
