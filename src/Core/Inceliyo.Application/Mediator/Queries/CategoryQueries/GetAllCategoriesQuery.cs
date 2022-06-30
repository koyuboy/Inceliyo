using AutoMapper;
using Inceliyo.Application.DTOs.Responses.Category;
using Inceliyo.Application.Interfaces.Services;
using Inceliyo.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Application.Mediator.Queries.CategoryQueries
{
    public class GetAllCategoriesQuery : IRequest<CustomBaseResponse<List<CategoryNameResponse>>>
    {

        public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, CustomBaseResponse<List<CategoryNameResponse>>>
        {
            private readonly ICategoryService _categoryService;
            private readonly IMapper _mapper;

            public GetAllCategoriesQueryHandler(ICategoryService categoryService, IMapper mapper)
            {
                _categoryService = categoryService;
                _mapper = mapper;
            }



            public async Task<CustomBaseResponse<List<CategoryNameResponse>>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
            {
                var categories = await _categoryService.GetAllAsync();

                var viewModel = _mapper.Map<List<CategoryNameResponse>>(categories);

                return CustomBaseResponse<List<CategoryNameResponse>>.Success(200, viewModel);
            }
        }
    }
}
