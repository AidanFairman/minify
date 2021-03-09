using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MiniUrlController : ControllerBase
    {

        MySqlClient client;

        public MiniUrlController(MySqlClient _client)
        {
            client = _client;
        }

        [HttpGet("{minifiedTail}")]
        public RedirectResult GetFullSite(string minifiedTail)  
        {  
            
            return Redirect();  
        }  
    }
}
