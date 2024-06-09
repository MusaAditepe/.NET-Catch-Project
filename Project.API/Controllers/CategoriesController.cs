using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Project.Core.Services;

namespace Project.API.Controllers
{
   
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult>GetSingleCategoryByIdWith(int categoryId)
        {
            return CreateActionResult(await _categoryService.GetSingleCategoryByIdWithProductAsync(categoryId));
        }
    }
}
