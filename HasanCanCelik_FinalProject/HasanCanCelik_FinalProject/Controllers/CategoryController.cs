using BusinessLayer.Manager;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HasanCanCelik_FinalProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        public IActionResult Index()
        {
            var values = cm.GetAll();
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category c)
        {
            cm.BLAdd(c);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                cm.BLDell(id);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Update(Category c)
        {
            cm.BLUpdate(c);
            return RedirectToAction("Index");
        }
    }
}
