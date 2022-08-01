using Microsoft.AspNetCore.Mvc;

namespace JustDaiting.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
