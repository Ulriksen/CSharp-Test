using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace DogSledSim.API
{
    [RoutePrefix("api/dog-sled")]
    public class DogSledController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return null;
        }

        [HttpGet("{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            return null;
        }
    }
}
