using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProConvenios.Persistence;
using ProConvenios.Domain;

namespace ProConvenios.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConveniosController : ControllerBase
    {
        private readonly ProConveniosContext _context;

        public ConveniosController(ProConveniosContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Convenio> Get()
        {
            return _context.Convenios;
        }

        [HttpGet("{id}")]
        public Convenio GetById(int id)
        {
            return _context.Convenios.FirstOrDefault(convenio => convenio.Id == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }

    }
}
