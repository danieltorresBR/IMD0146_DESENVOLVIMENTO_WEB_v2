using System.Threading.Tasks;
using ProConvenios.Domain;

namespace ProConvenios.Application.Contratos
{
    public interface IConvenioService
    {
        Task<Convenio> AddConvenios(Convenio model);

        Task<Convenio> UpdateConvenio(int convenioId, Convenio model);
        Task<bool> DeleteConvenio(int convenioId);

        Task<Convenio[]> GetAllConveniosAsync();
        Task<Convenio> GetConvenioByIdAsync(int ConvenioId);
    }
}