using AutoMapper;
using BloggerWay.Entities.Dtos;
using BloggerWay.MVC.Areas.Admin.Models;

namespace BloggerWay.MVC.AutoMapper
{
    public class ViewModelsProfile : Profile
    {
        public ViewModelsProfile()
        {
            CreateMap<ArticleAddViewModel, ArticleAddDto>();
        }
    }
}
