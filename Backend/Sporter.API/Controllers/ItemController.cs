using Microsoft.AspNetCore.Mvc;
using Sporter.Application.Interfaces;
using Sporter.Application.Services;
using Sporter.Application.Validators.Json;
using System.Web;

namespace Sporter.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult JsonResult()
        {
            var jsonS = new JsonService(new JsonValidator());
            var a = jsonS.SerializeToJson(new Domain.Models.Item());
            return new JsonResult(a);
        }

        [HttpGet]
        [Route("value")]
        public IActionResult GetItem()
        {
            return new JsonResult(_itemService.GetJsonTEST());
        }

        [HttpGet]
        [Route("index")]
        public void Index() 
        { 
            _itemService.DeleteItem(2); 
        } 

        
        [Route("additem/{itemJson}")]
        [HttpPost]
        public int AddItem([FromHeader] string itemJson) 
        { 
            return _itemService.AddItem(itemJson); 
        } 
    }
}