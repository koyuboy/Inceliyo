using Inceliyo.Application.DTOs.Category;
using Inceliyo.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Application.Mediator.Queries.Category
{
    public class GetAllCategoriesQuery : IRequest<CustomBaseResponse<List<CategoryViewDto>>>
    {
    }
}
