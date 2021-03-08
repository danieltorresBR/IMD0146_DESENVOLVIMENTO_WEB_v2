using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProConvenios.Domain;
using ProConvenios.Persistence.Contratos;
using ProConvenios.Persistence.Contexto;

namespace ProConvenios.Persistence
{
    public class ConvenioPersist : IConvenioPersist
    {
        private readonly ProConveniosContext _context;

        public ConvenioPersist(ProConveniosContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        }

        public async Task<Convenio[]> GetAllConveniosAsync()
        {
            IQueryable<Convenio> query = _context.Convenios;

            query = query.OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }

        // public async Task<Convenio[]> GetAllConvenioBydtInicioAsync(string dtInicio)
        // {
        //     IQueryable<Convenio> query = _context.Convenios;

        //     return await query.ToArrayAsync();
        // }
        public async Task<Convenio> GetConvenioByIdAsync(int Id)
        {
            IQueryable<Convenio> query = _context.Convenios;

            query = query.OrderBy(c => c.Id).Where(c => c.Id == Id);

            return await query.FirstOrDefaultAsync();
        }

    }
}