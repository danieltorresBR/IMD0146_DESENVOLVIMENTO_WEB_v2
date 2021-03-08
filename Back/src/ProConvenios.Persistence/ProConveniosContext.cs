using Microsoft.EntityFrameworkCore;
using ProConvenios.Domain;

namespace ProConvenios.Persistence
{
    public class ProConveniosContext : DbContext
    {
        public ProConveniosContext(DbContextOptions<ProConveniosContext> options) 
            : base (options) {}
    
        public DbSet<Convenio> Convenios { get; set; }
    }
}