using BusinessLayer.Manager;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HasanCanCelik_FinalProject.Controllers
{
    public class PageController : Controller
    {

        ProductManager pm = new ProductManager();
        Context c = new Context();
        public IActionResult Index()
        {
            var values = pm.GetAll().Where(a => a.IsPublish).ToList();
            return View(values);
        }
        public IActionResult BuyProduct(int id)
        {
            var values = pm.GetOnlyProduct(id);
            foreach (var item in values)
            {
                if (item.Stock != 0){
                    item.Stock--;
                    pm.BLUpdate(item);
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
