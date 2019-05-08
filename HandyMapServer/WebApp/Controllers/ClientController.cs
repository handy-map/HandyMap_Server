using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Common.Models;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApp.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private ClientLogic _clientLogic;
        public ClientController()
        {
            _clientLogic = new ClientLogic();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _clientLogic.LoadClient(id);

            //convert and return json

            var json = JsonConvert.SerializeObject(result);

            return StatusCode((int)result.StatusCode, json);
        }

        // POST: api/Client
        [HttpPost]
        public async Task<IActionResult> AddClient([System.Web.Http.FromBody]ClientModel client)
        {
            var result = _clientLogic.SaveClient(client);

            return StatusCode((int)result.StatusCode, result.Messages);
        }

        // PUT: api/Client/5
        [HttpPut]
        public void UpdateClient(int id, [System.Web.Http.FromBody]ClientModel client)
        {
        }

        // DELETE: api/Client/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}