using System.Threading.Tasks;
using ProConvenios.Domain;

namespace ProConvenios.Persistence.Contratos
{
    public interface IConvenioPersist
    {
        //CONVENIOS
        //Task<Convenio[]> GetAllConvenioBydtInicioAsync(string dtInicio);
        Task<Convenio[]> GetAllConveniosAsync();
        Task<Convenio> GetConvenioByIdAsync(int convenioId);
        
    }
}