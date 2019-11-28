using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClientAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "consumer")]
    public class MainController : ControllerBase
    {
        private readonly IClientService clientService;

        public MainController(IClientService _clientService)
        {
            clientService = _clientService;
        }

        [HttpGet]
        public IEnumerable<Client.Model.Client> Get()
        {
            var clients = clientService.GetClients();
            return clients;
        }

        [HttpGet("{id}")]
        public Client.Model.Client GetClient(int id)
        {
            var clients = clientService.GetClient(id);
            return clients;
        }

        [HttpPost]
        public IActionResult AddClient(Client.Model.Client client) 
        {
            clientService.CreateClient(client);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateClient(Client.Model.Client client) 
        {
            clientService.UpdateClient(client);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteClient(int id) 
        {
            clientService.DeleteClient(id);
            return Ok();
        }

    }
}