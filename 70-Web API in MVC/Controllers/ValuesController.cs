using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _70_Web_API_in_MVC.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/BoxAction/{id}")]
        public IHttpActionResult Get([FromUri]int id)
        {
            if (id > 5)
            {
                return Ok(1);
            }
            else
            {
                return NotFound();
            }
           
        }
    }
}
