using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using minify.Services;

namespace minify.Controllers
{
    [ApiController]
    public class MiniUrlController : ControllerBase
    {
        private RedirectAddressService redirectService;

        public MiniUrlController(RedirectAddressService _redirectService)
        {
            redirectService = _redirectService;
        }

        [HttpGet("{minifiedTail}")]
        public RedirectResult GetFullSite(string minifiedTail)
        {
            string newUrl = redirectService.getRedirectAddress(minifiedTail);
            return Redirect(newUrl);
        }

        [HttpPost("new")]
        public string AddNewMapping([FromBody] string fullUrl)
        {
            return redirectService.addRedirectAddress(fullUrl);
        }
    }
}
