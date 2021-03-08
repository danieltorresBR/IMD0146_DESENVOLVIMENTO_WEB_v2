using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProConvenios.Persistence;
using ProConvenios.Domain;
using ProConvenios.Persistence.Contexto;
using ProConvenios.Application.Contratos;
using Microsoft.AspNetCore.Http;

namespace ProConvenios.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConveniosController : ControllerBase
    {
        private readonly IConvenioService _convenioService;

        public ConveniosController(IConvenioService convenioService)
        {
            _convenioService = convenioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var convenios = await _convenioService.GetAllConveniosAsync();
                if (convenios == null)
                {
                    return NotFound("Nenhum convenio encontrado.");
                }
                return Ok(convenios);
            }
            catch (Exception ex)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar convenios. Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var convenio = await _convenioService.GetConvenioByIdAsync(id);
                if (convenio == null)
                {
                    return NotFound("Nenhum convenio encontrado.");
                }
                return Ok(convenio);
            }
            catch (Exception ex)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar convenios. Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Convenio model)
        {
            try
            {
                var convenio = await _convenioService.AddConvenios(model);
                if (convenio == null)
                {
                    return BadRequest("Erro ao tentar adicionar convenio.");
                }
                return Ok(convenio);
            }
            catch (Exception ex)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar convenios. Erro: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Convenio model)
        {
            try
            {
                var convenio = await _convenioService.UpdateConvenio(id, model);
                if (convenio == null)
                {
                    return BadRequest("Erro ao tentar adicionar convenio.");
                }
                return Ok(convenio);
            }
            catch (Exception ex)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar atualizar convenios. Erro: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (await _convenioService.DeleteConvenio(id))
                {
                    return Ok("Deletado");
                }
                else
                {
                    return BadRequest("Convênio não deletado");
                }
            }
            catch (Exception ex)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar deletar convenios. Erro: {ex.Message}");
            }
        }

    }
}
