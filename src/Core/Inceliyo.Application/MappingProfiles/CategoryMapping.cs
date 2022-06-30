using AutoMapper;
using Inceliyo.Application.DTOs.Requests.Category;
using Inceliyo.Application.DTOs.Responses.Category;
using Inceliyo.Application.Mediator.Commands.CategoryCommands;
using Inceliyo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Application.MappingProfiles
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CategoryNameResponse>().ReverseMap();
            CreateMap<Category, AddCategoryResponse>().ReverseMap();
            CreateMap<Category, AddCategoryCommand>().ReverseMap();
            
        }
    }
}
