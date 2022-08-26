using BusinessLayer.Manager;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HasanCanCelik_FinalProject.Controllers
{
    public class UserController : Controller
    {
        UserManager um = new UserManager();

        public IActionResult Index()
        {
            var values = um.GetAll();
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(User u)
        {

            um.BLUpdate(u);
            return RedirectToAction(nameof(Index));
        }
    }
}
