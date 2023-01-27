using AutoMapper;
using BloggerWay.Entities.Concrete;
using BloggerWay.Entities.Dtos;
using System;

namespace BloggerWay.Services.AutoMapper.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto, Article>().ForMember(a => a.CreatedDate, d => d.MapFrom(x => DateTime.Now));
            CreateMap<ArticleUpdateDto, Article>().ForMember(a => a.ModifiedDate, d => d.MapFrom(x => DateTime.Now));
            CreateMap<Article, ArticleUpdateDto>();
        }
    }
}
