using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProConvenios.Domain;
using ProConvenios.Persistence.Contratos;
using ProConvenios.Persistence.Contexto;



namespace ProConvenios.Persistence
{
    public class GeralPersist : IGeralPersist
    {
        private readonly ProConveniosContext _context;

        public GeralPersist(ProConveniosContext context)
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

    }
}