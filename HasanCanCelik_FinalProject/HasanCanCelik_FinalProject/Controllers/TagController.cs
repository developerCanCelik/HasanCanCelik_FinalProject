using BusinessLayer.Manager;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HasanCanCelik_FinalProject.Controllers
{
    public class TagController : Controller
    {
        TagManager tm = new TagManager();
        public IActionResult Index()
        {
            var values = tm.GetAll();
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tag t)
        {
            tm.BLAdd(t);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                tm.BLDell(id);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Update(Tag t)
        {
            tm.BLUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
