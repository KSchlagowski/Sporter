using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sporter.Application.Interfaces;
using Sporter.Application.Services;
using Sporter.Application.Validators.Json;
using Sporter.Application.ViewModels.Item;
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
        public IActionResult GetItemById(int itemId)
        {
            var item = _itemService.GetItemById(itemId);
            return new JsonResult(item);
        }

        [HttpGet]
        public IActionResult GetItemByBuyerId(int buyerId)
        {
            var item = _itemService.GetItemByBuyerId(buyerId);
            return new JsonResult(item);
        }

        [HttpGet]
        public IActionResult GetAllItems()
        {
            var items = _itemService.GetAllItems();
            return new JsonResult(items);
        }

        [HttpGet]
        public IActionResult GetAllItems(int pageSize, int pageNo, string searchString)
        {
            var items = _itemService.GetAllItems(pageSize, pageNo, searchString);
            return new JsonResult(items);
        }

        [HttpGet]
        public IActionResult GetItemsByCategory(string category)
        {
            var items = _itemService.GetItemsByCategory(category);
            return new JsonResult(items);
        }

        [HttpGet]
        public IActionResult GetItemsByCountry(string country)
        {
            var items = _itemService.GetItemsByCountry(country);
            return new JsonResult(items);
        }

        [HttpGet]
        public IActionResult GetItemsByCity(string city)
        {
            var items = _itemService.GetItemsByCity(city);
            return new JsonResult(items);
        }

        [HttpGet]
        public IActionResult GetItemsBelowPrice(decimal maxPrice)
        {
            var items = _itemService.GetItemsBelowPrice(maxPrice);
            return new JsonResult(items);
        }
    
        [HttpGet]
        public IActionResult GetItemsAbovePrice(decimal minPrice)
        {
            var items = _itemService.GetItemsAbovePrice(minPrice);
            return new JsonResult(items);
        }

        [HttpGet]
        public IActionResult AddItem()
        {
            return new JsonResult(new NewItemVm());
        }

        [HttpPost]
        public IActionResult AddItem([FromBody] NewItemVm model)
        {
            int id = _itemService.AddItem(model);
            return new JsonResult(id);
        }

        [HttpGet]
        public IActionResult EditItem(int id)
        {
            var item = _itemService.GetItemById(id);
            return new JsonResult(item);
        }

        [HttpPost]
        public IActionResult EditItem([FromBody] NewItemVm model)
        {
            if (ModelState.IsValid)
            {
                _itemService.UpdateItem(model);
            }

            return new JsonResult(model);
        }

        [HttpDelete]
        public IActionResult DeleteItem(int itemId)
        {
            _itemService.DeleteItem(itemId);
            return new JsonResult(itemId);
        }

        [HttpDelete]
        public IActionResult DeleteItemAbsolute(int itemId)
        {
            _itemService.DeleteItemAbsolute(itemId);
            return new JsonResult(itemId);
        }
    }
}