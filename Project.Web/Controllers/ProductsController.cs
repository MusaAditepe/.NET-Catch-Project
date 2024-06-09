using Autofac.Core;
using Microsoft.AspNetCore.Mvc;
using Project.Core.Services;
using Project.Service.Services;

namespace Project.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _services;

     


        public ProductsController(IProductService services)
        {
            _services = services;
            
        }

        //  [HttpGet("[action]")]
        public async Task<IActionResult> Index()
        {
            var customResponse = (await _services.GetProductsWithCategory());
            return View(customResponse.Data);
        }
       
    }
}
