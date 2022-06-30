using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inceliyo.Application.Interfaces.Services;
using Inceliyo.Domain.Entities;
using MediatR;
using Inceliyo.Application.Mediator.Commands.CategoryCommands;
using Inceliyo.Application.Mediator.Queries.CategoryQueries;

namespace Inceliyo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        //private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        private readonly IMediator _mediator;

        public CategoriesController(ICategoryService categoryService, IMediator mediator)
        {
            _categoryService = categoryService;
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var query = new GetAllCategoriesQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetCategoryByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCategoryCommand command)
        {
            return Ok(await _mediator.Send(command));
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
