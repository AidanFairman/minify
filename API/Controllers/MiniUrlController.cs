using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MiniUrlController : ControllerBase
    {
        public MiniUrlController()
        {
        }

        [HttpGet]
        public void Get()
        {
            
        }
    }
}
