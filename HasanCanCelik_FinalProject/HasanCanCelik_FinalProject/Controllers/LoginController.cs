using BusinessLayer.Manager;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HasanCanCelik_FinalProject.Controllers
{
    public class LoginController : Controller
    {
        UserManager um = new UserManager();
        public static int MyGlobalInt { get; set; }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Login(string Email, string Password)
        {
            var admin = false;
            var author = um.GetAll().FirstOrDefault(x => x.Email == Email && x.Password == Password);
            if (author != null)
            {
                foreach (var item in um.GetByEmail(Email))
                {
                    admin = item.IsAdmin;
                    MyGlobalInt = item.UserID;

                }
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, Email)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                if (admin == true)
                {
                    return RedirectToAction("Index", "Category");
                }
                else
                {
                    return RedirectToAction("Index", "Page");
                }
            }
            return View();
        }
        //Yeni kullanıcı kayıtlarını admin ve normal kullanıcı olarak ayırdım
        [HttpPost]
        public async Task<IActionResult> Create(User u)
        {
            um.BLAdd(u);
            return RedirectToAction(nameof(Login));
        }
        public async Task<IActionResult> CreateAdmin(User u)
        {
            um.BLAdd(u);
            return RedirectToAction(nameof(Login));
        }
    }
}
