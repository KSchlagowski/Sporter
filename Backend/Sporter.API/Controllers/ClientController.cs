using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sporter.Application.Interfaces;
using Sporter.Application.Services;
using Sporter.Application.Validators.Json;
using Sporter.Application.ViewModels.Client;
using System.Web;

namespace Sporter.API.Controllers
{
    public class ClientController : Controller
    {
        private readonly ILogger<ItemController> _logger;
        private readonly IClientService _clientService;

        public ClientController(ILogger<ItemController> logger, IClientService clientService)
        {
            _logger = logger;
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult GetClient(int clientId)
        {
            var client = _clientService.GetClient(clientId);
            return View(client);
        }

        [HttpGet]
        public IActionResult GetAllClients()
        {
            var clients = _clientService.GetAllClients();
            return new JsonResult(clients);
        }

        [HttpGet]
        public IActionResult GetAllClients(int pageSize, int pageNo, string searchString)
        {
            var clients = _clientService.GetAllClients(pageSize, pageNo, searchString);
            return new JsonResult(clients);
        }

        [HttpGet]
        public IActionResult GetClientDetails(int clientId)
        {
            var clientDetails = _clientService.GetClientDetails(clientId);
            return new JsonResult(clientDetails);
        }

        [HttpGet]
        public IActionResult AddClient()
        {
            return new JsonResult(new NewClientVm());
        }

        [HttpPost]
        public IActionResult AddClient([FromBody] NewClientVm model)
        {
            if (ModelState.IsValid)
            {
                var id = _clientService.AddClient(model);

                return new JsonResult(id);
            }
            
            return new JsonResult("Invalid model");
        }

        [HttpGet]
        public IActionResult AddClientContactInformation()
        {
            return new JsonResult(new NewClientContactInformationVm());
        }

        [HttpPost]
        public IActionResult AddClientContactInformation([FromBody] NewClientContactInformationVm model)
        {
            var id = _clientService.AddClientContactInformation(model);
            return new JsonResult(id);
        }

        [HttpGet]
        public IActionResult AddAddress()
        {
            return View(new NewAddressVm());
        }

        [HttpPost]
        public IActionResult AddAddress([FromBody] NewAddressVm model)
        {
            var id = _clientService.AddAddress(model);
            return new JsonResult(id);
        }

        [HttpGet]
        public IActionResult EditClient(int id)
        {
            var client = _clientService.GetClientForEdit(id);
            return new JsonResult(client);
        }

        [HttpPost]
        public IActionResult EditClient([FromBody] NewClientVm model)
        {
            if (ModelState.IsValid)
            {
                _clientService.UpdateClient(model);
            }

            return new JsonResult(model);
        }

        [HttpGet]
        public IActionResult EditClientContactInformation(int id)
        {
            var contact = _clientService.GetClientContactInformationForEdit(id);
            return new JsonResult(contact);
        }
        
        [HttpPost]
        public IActionResult EditClientContactInformation([FromBody] NewClientContactInformationVm model)
        {
            if (ModelState.IsValid)
            {
                _clientService.UpdateClientContactInformation(model);
            }

            return new JsonResult(model);
        }

        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var address = _clientService.GetAddressForEdit(id);
            return new JsonResult(address);
        }

        [HttpPost]
        public IActionResult EditAddress([FromBody] NewAddressVm model)
        {
            if (ModelState.IsValid)
            {
                _clientService.UpdateAddress(model);
            }

            return new JsonResult(model);
        }
        
        [HttpDelete]
        public IActionResult DeleteClient(int clientId)
        {
            _clientService.DeleteClient(clientId);
            return new JsonResult(clientId);
        }

        [HttpDelete]
        public IActionResult DeleteClientAbsolute(int clientId)
        {
            _clientService.DeleteClientAbsolute(clientId);
            return new JsonResult(clientId);
        }

        [HttpDelete]
        public IActionResult DeleteClientContactInformation(int contactInformationId)
        {
            _clientService.DeleteClientContactInformation(contactInformationId);
            return new JsonResult(contactInformationId);
        }

        [HttpDelete]
        public IActionResult DeleteAddress(int addressId)
        {
            _clientService.DeleteAddress(addressId);
            return new JsonResult(addressId);
        }       
    }
}