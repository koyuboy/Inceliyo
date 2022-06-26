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
        public async Task<IEnumerable<Category>> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();

            return categories;
        }

        [HttpGet("{id}")]
        public async Task<Category> GetById(Guid id)
        {
            var category = await _categoryService.GetByIdAsync(id);

            return category;
        }

        [HttpPost]
        public async Task<Category> Add(Category category)
        {
            var result = await _categoryService.AddAsync(category);

            return result;
        }

        [HttpPut]
        public async Task Update(Category category)
        {
            await _categoryService.UpdateAsync(category);

        }

        [HttpDelete("{id}")]
        public async Task Remove(Guid id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            await _categoryService.RemoveAsync(category);

        }

    }
}
