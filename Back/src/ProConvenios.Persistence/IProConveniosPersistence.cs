using System.Threading.Tasks;
using ProConvenios.Domain;

namespace ProConvenios.Persistence
{
    public interface IProConveniosPersistence
    {
        //GERAL
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteRange<T>(T entity) where T: class;

        Task<bool> SaveChangesAsync();

        //CONVENIOS
        //Task<Convenio[]> GetAllConvenioBydtInicioAsync(string dtInicio);
        Task<Convenio[]> GetAllConvenioByAsync(string dtInicio);
        Task<Convenio> GetConvenioByIdAsync(string ConveioId);
        
    }
}