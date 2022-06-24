using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inceliyo.Application.Interfaces.Services;
using Inceliyo.Domain.Entities;

namespace Inceliyo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        //private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> All()
        {
            var categories = await _categoryService.GetAllAsync();

            return categories;
        }

    }
}
