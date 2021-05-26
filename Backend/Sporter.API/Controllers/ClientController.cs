using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sporter.Application.Interfaces;
using Sporter.Application.Services;
using Sporter.Application.Validators.Json;
using System.Web;

namespace Sporter.API.Controllers
{
    public class ClientController : Controller
    {
        private readonly ILogger<ItemController> _logger;
        private readonly IClientJsonService _clientJsonService;

        public ClientController(ILogger<ItemController> logger, IClientJsonService clientJsonService)
        {
            _logger = logger;
            _clientJsonService = clientJsonService;
        }

        [HttpGet]
        public IActionResult GetClientInJson(int clientId)
        {
            var json = _clientJsonService.GetClientInJson(clientId);
            return new JsonResult(json);
        }

        // public IActionResult GetAllClientsInJson()
        // {
            
        // }

        // public IActionResult GetAllClientsInJson(int pageSize, int pageNo, string searchString)
        // {

        // }
        // public IActionResult GetClientContactInformationInJson(int contactInformationId)
        // {

        // }
        // public IActionResult GetAddressInJson(int addressId)
        // {

        // }
        // public IActionResult AddClientInJson(string clientJson)
        // {

        // }
        // public IActionResult AddClientContactInforamtionInJson(string contactJson)
        // {

        // }
        // public IActionResult AddAddressInJson(string addressJson)
        // {

        // }
        // public IActionResult UpdateClientInJson(string clientJson)
        // {

        // }
        // public IActionResult UpdateClientContactInformationInJson(string contactInformationJson)
        // {

        // }
        // public IActionResult UpdateAddressInJson(string addressJson)
        // {

        // }
    }
}