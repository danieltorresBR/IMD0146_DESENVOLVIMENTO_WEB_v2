using System;
using System.Threading.Tasks;
using ProConvenios.Application.Contratos;
using ProConvenios.Domain;
using ProConvenios.Persistence.Contratos;

namespace ProConvenios.Application
{
    public class ConvenioService : IConvenioService
    {
        private readonly IGeralPersist _geralPersist;
        private readonly IConvenioPersist _convenioPersist;

        public ConvenioService(IGeralPersist geralPersist, IConvenioPersist convenioPersist)
        {
            _geralPersist = geralPersist;
            _convenioPersist = convenioPersist;
        }
        public async Task<Convenio> AddConvenios(Convenio model)
        {
            try
            {
                _geralPersist.Add<Convenio>(model);
                if (await _geralPersist.SaveChangesAsync()) {
                    return await _convenioPersist.GetConvenioByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteConvenio(int convenioId)
        {
            try
            {
                var convenio = await _convenioPersist.GetConvenioByIdAsync(convenioId);
                if (convenio == null) throw new Exception("Convenio para delete não encontrado");

                _geralPersist.Delete<Convenio>(convenio);
                return await _geralPersist.SaveChangesAsync();
            }
            catch (Exception ex) 
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Convenio[]> GetAllConveniosAsync()
        {
            try
            {
                var convenios = await _convenioPersist.GetAllConveniosAsync();
                if (convenios == null)
                {
                    return null;
                }
                return convenios;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Convenio> GetConvenioByIdAsync(int convenioId)
        {
            try
            {
                var convenio = await _convenioPersist.GetConvenioByIdAsync(convenioId);
                if (convenio == null)
                {
                    return null;
                }
                return convenio;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Convenio> UpdateConvenio(int convenioId, Convenio model)
        {
            try
            {
                var convenio = await _convenioPersist.GetConvenioByIdAsync(convenioId);
                if (convenio == null) return null;

                model.Id = convenio.Id;

                _geralPersist.Update(model);
                if (await _geralPersist.SaveChangesAsync()) {
                    return await _convenioPersist.GetConvenioByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex) 
            {
                
                throw new Exception(ex.Message);
            }
        }
    }
}