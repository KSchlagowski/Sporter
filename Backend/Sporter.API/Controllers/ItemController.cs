using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sporter.Application.Interfaces;
using Sporter.Application.Services;
using Sporter.Application.Validators.Json;
using System.Web;

namespace Sporter.API.Controllers
{
    // [ApiController]
    // [Route("api/[controller]")]
    public class ItemController : Controller
    {
        private readonly ILogger<ItemController> _logger;
        private readonly IItemService _itemService;

        public ItemController(ILogger<ItemController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        [HttpGet]
        public void Index() 
        { 
            _logger.LogInformation("I am in Index");
        } 



        [HttpGet]
        public IActionResult GetItem()
        {
            return new JsonResult(_itemService.GetJsonTEST());
        }

        // [HttpGet]
        // public IActionResult GetAllItems()
        // {

        //}



        
        //[Route("additem/{itemJson}")]
        [HttpPost]
        public int AddItem([FromHeader] string itemJson) 
        { 
            return _itemService.AddItemInJson(itemJson); 
        } 

        //Action for front-end developers
        public IActionResult GetSampleJsonOfItem()
        {
            var jsonS = new JsonService(new JsonValidator());
            var a = jsonS.SerializeToJson(new Domain.Models.Item());
            return new JsonResult(a);
        }
    }
}