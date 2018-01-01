using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayniteServices.Controllers.Patreon
{
    [Route("api/patreon/patrons")]
    public class PatronsController : Controller
    {
        [HttpGet]
        public ServicesResponse<List<string>> Get()
        {
            


            return new ServicesResponse<List<string>>(null, string.Empty);
        }
    }
}
