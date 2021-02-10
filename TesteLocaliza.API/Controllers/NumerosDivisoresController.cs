using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TesteLocaliza.Business;
using TesteLocaliza.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteLocaliza.API.Controllers
{
    [Route("Divisores")]
    [ApiController]
    public class NumerosDivisoresController : BaseController
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();

        }

        // GET api/<ValuesController>/5
        [HttpGet("{numero}")]
        public NumerosDivisoresDTO Get(int numero)
        {
            var retorno = NumerosDivisoresBusiness.GetDivisores(numero);

            retorno.PrintDivisores = PrintBusiness.PrintDivisores(retorno.NumerosDivisores);

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
