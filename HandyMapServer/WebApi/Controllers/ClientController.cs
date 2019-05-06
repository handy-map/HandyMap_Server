using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Logic;
using Newtonsoft.Json;
using Common;
using Common.Models;

namespace WebApplication1.Controllers
{
    public class ClientController : ApiController
    {
        private ClientLogic _clientLogic;
        public ClientController()
        {
            _clientLogic = new ClientLogic();
        }

        // GET: api/Client
        public IEnumerable<string> Get()
        {   
            return new string[] { "value1", "value2" };
        }

        // GET: api/Client/5
        public IHttpActionResult Get(int id)
        {
            ClientModel data = _clientLogic.LoadClient(id);

            //convert and return json

            var json = JsonConvert.SerializeObject(data);

            return Content(HttpStatusCode.OK, json);
        }

        // POST: api/Client
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Client/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
        }
    }
}
