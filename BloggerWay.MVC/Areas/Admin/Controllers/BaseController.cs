using AutoMapper;
using BloggerWay.Entities.Concrete;
using BloggerWay.MVC.Helpers.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BloggerWay.MVC.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper)
        {
            UserManager = userManager;
            Mapper = mapper;
            ImageHelper = imageHelper;
        }

        protected UserManager<User> UserManager { get; }
        protected IMapper Mapper { get; }
        protected IImageHelper ImageHelper { get; }
        protected User LoggedInUser => UserManager.GetUserAsync(HttpContext.User).Result;
    }
}
