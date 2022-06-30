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
    public class GetCategoryByIdQuery : IRequest<CustomBaseResponse<CategoryNameResponse>>
    {
        public Guid Id { get; set; }
        

        public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, CustomBaseResponse<CategoryNameResponse>>
        {
            private readonly ICategoryService _categoryService;
            private readonly IMapper _mapper;

            public GetCategoryByIdQueryHandler(ICategoryService categoryService, IMapper mapper)
            {
                _categoryService = categoryService;
                _mapper = mapper;
            }



            public async Task<CustomBaseResponse<CategoryNameResponse>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
            {
                
                var category = await _categoryService.GetByIdAsync(request.Id);
                var viewModel = _mapper.Map<CategoryNameResponse>(category);

                return CustomBaseResponse<CategoryNameResponse>.Success(200, viewModel);
                
                
            }
        }
    }
}
