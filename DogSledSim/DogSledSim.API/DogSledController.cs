using DogSledSim.Data;
using DogSledSim.Model;
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
        [Route("")]
        public IHttpActionResult Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("{id:int}", Name="GetSledById")]
        public IHttpActionResult GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
