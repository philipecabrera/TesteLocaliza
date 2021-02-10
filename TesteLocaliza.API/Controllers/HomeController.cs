using Microsoft.AspNetCore.Mvc;

namespace TesteLocaliza.API.Controllers
{
    [Route("Home")]
        [ApiController]
        public class HomeController : BaseController
        {
            [HttpGet]
            public ActionResult<string> Get()
            {                
                return "Teste Localiza";
            }
        }
    

}
