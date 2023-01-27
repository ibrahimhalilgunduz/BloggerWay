using AutoMapper;
using BloggerWay.Entities.Concrete;
using BloggerWay.Entities.Dtos;

namespace BloggerWay.MVC.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {

            CreateMap<UserAddDto, User>();
        }
    }
}
