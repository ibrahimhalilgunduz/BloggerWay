using AutoMapper;
using BloggerWay.Entities.Concrete;
using BloggerWay.Entities.Dtos;
using System;

namespace BloggerWay.Services.AutoMapper.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto, Category>().ForMember(c => c.CreatedDate, d => d.MapFrom(x => DateTime.Now));
            CreateMap<CategoryUpdateDto, Category>().ForMember(c => c.ModifiedByName, d => d.MapFrom(x => DateTime.Now));
            CreateMap<Category, CategoryUpdateDto>();
        }
    }
}
