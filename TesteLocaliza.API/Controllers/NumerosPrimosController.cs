using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TesteLocaliza.Business;
using TesteLocaliza.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteLocaliza.API.Controllers
{
    [Route("Primos")]
    [ApiController]
    public class NumerosPrimosController : BaseController
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public NumerosPrimosDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("GetPrimos")]
        public NumerosPrimosDTO GetPrimos(List<long> numeros)
        {
            var retorno = NumerosPrimosBusiness.GetPrimos(numeros);

            retorno.PrintPrimos = PrintBusiness.PrintPrimos(retorno.NumerosPrimos);

            return retorno;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
