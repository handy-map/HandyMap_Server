using Common.Models;
using Logic;
using Logic.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("Client")]
    public class ClientController : ApiController
    {
        // GET: api/Client
        private ClientLogic _clientLogic;
        public ClientController()
        {
            _clientLogic = new ClientLogic();
        }

        [HttpGet]
        [Route("Get/{id}")]
        public IHttpActionResult Get(int id)
        {
            var result = _clientLogic.LoadClient(id);

            return Json(result.Object);
        }

        // POST: api/Client
        [HttpPost]
        public IHttpActionResult AddClient([System.Web.Http.FromBody]ClientModel client)
        {
            var result = _clientLogic.SaveClient(client);
            return Ok(result);
        }

        // PUT: api/Client/5
        [HttpPut]
        public void UpdateClient(int id, [System.Web.Http.FromBody]ClientModel client)
        {
        }

        // DELETE: api/Client/5
        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
        }
    }
}
