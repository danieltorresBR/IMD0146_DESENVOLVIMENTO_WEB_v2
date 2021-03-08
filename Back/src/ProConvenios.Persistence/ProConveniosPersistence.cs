using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProConvenios.Domain;

namespace ProConvenios.Persistence
{
    public class ProConveniosPersistence : IProConveniosPersistence
    {
        private readonly ProConveniosContext _context;

        public ProConveniosPersistence(ProConveniosContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Convenio[]> GetAllConvenioByAsync(string dtInicio)
        {
            IQueryable<Convenio> query = _context.Convenios;

            return await query.ToArrayAsync();
        }

        // public async Task<Convenio[]> GetAllConvenioBydtInicioAsync(string dtInicio)
        // {
        //     IQueryable<Convenio> query = _context.Convenios;

        //     return await query.ToArrayAsync();
        // }
        public async Task<Convenio> GetConvenioByIdAsync(string ConveioId)
        {
            IQueryable<Convenio> query = _context.Convenios;

            //query = query.OrderBy(e => e.Id).Where(e => e.Id == ConveioId);

            return await query.FirstOrDefaultAsync();
        }

    }
}