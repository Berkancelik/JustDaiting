using EntityLayer.Concrete;
using EntityLayer.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JustDaiting.Controllers
{
    public class UserController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserDto userDto)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser();
                user.UserName = userDto.UserName;
                user.Email = user.Email;
                user.PhoneNumber = userDto.PhoneNumber;

                IdentityResult result = await _userManager.CreateAsync(user,userDto.Password);


                if (result.Succeeded)
                {
                    return RedirectToAction("LogIn");
                }
                else
                {
                    foreach (IdentityError item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(userDto);
        }
    }
}
