using AutoMapper;
using Inceliyo.Application.DTOs.Responses;
using Inceliyo.Application.DTOs.Responses.Category;
using Inceliyo.Application.Interfaces.Services;
using Inceliyo.Application.Wrappers;
using Inceliyo.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Application.Mediator.Commands.CategoryCommands
{
    public class AddCategoryCommand : IRequest<CustomBaseResponse<AddCategoryResponse>>
    {
        public string Name { get; set; }
        public Guid ParentId { get; set; }

        public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommand, CustomBaseResponse<AddCategoryResponse>>
        {
            private readonly ICategoryService _categoryService;
            private readonly IMapper _mapper;
            
            public AddCategoryCommandHandler(ICategoryService categoryService, IMapper mapper)
            {
                _categoryService = categoryService;
                _mapper = mapper;
            }
            
            public async Task<CustomBaseResponse<AddCategoryResponse>> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
            {
                var category = _mapper.Map<Category>(request);
                await _categoryService.AddAsync(category);
                var responseModel = _mapper.Map<AddCategoryResponse>(category);

                return CustomBaseResponse<AddCategoryResponse>.Success(201, responseModel);
            }
        }
    }
}
