using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteLocaliza.API.Controllers
{
    [Route("api/BaseController")]
    [ApiController]
    public class BaseController : ControllerBase
    {        
        public BaseController()
        {           
            
        }

    }
}
