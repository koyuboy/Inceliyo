using AutoMapper;
using Inceliyo.Application.DTOs.Category;
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
            CreateMap<Category, CategoryViewDto>().ReverseMap(); ;
        }
    }
}
