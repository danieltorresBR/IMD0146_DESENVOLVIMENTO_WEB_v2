using System.Threading.Tasks;
using ProConvenios.Domain;

namespace ProConvenios.Application.Contratos
{
    public interface IConvenioService
    {
        Task<Convenio> AddConvenios(Convenio model);

        Task<Convenio> UpdateConvenio(int id, Convenio model);
        Task<bool> DeleteConvenio(int id);

        Task<Convenio[]> GetAllConveniosAsync();
        Task<Convenio> GetConvenioByIdAsync(int id);
    }
}