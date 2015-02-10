using Microsoft.AspNet.Mvc;
using Jander.HspService.Models;

namespace Jander.HspService.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(User());
        }

        public User User()
        {
            User user = new User()
            {
                Name = "My name",
                Address = "My address"
            };

            return user;
        }
    }
}
