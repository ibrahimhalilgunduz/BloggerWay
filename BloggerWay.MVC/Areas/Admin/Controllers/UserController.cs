using BloggerWay.Entities.Concrete;
using BloggerWay.Entities.Dtos;
using BloggerWay.Shared.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BloggerWay.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;

        public UserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();

            return View(new UserListDto
            {
                Users = users,
                ResultStatus = ResultStatus.Success
            });
        }
    }
}
