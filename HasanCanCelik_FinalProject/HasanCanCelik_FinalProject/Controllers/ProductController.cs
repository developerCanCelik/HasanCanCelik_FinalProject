using BusinessLayer.Manager;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HasanCanCelik_FinalProject.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager();
        ProductValidator pv = new ProductValidator();
        Context c = new Context();

        public IActionResult Products()
        {
            var values = pm.GetAllOnlyUserID(LoginController.MyGlobalInt);
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                pm.BLDell(id);
                return RedirectToAction(nameof(Products));
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product p)
        {
            ValidationResult results = pv.Validate(p);
            if (results.IsValid)
            {
                var ktg = c.Categories.Where(m => m.CategoryID == p.CategoryID).FirstOrDefault();
                p.CategoryID = ktg.CategoryID;
                var tg = c.Tags.Where(m => m.TagID == p.TagID).FirstOrDefault();
                p.TagID = tg.TagID;

                p.UserID = LoginController.MyGlobalInt;
                pm.BLAdd(p);
                return RedirectToAction(nameof(Products));
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    TempData["mesaj"] = item.ErrorMessage; ;
                    return RedirectToAction(nameof(AddProduct));
                }
            }
            return RedirectToAction(nameof(AddProduct));
         
        }
        public IActionResult AddProduct()
        {
            List<SelectListItem> categoryVal = (from i in c.Categories.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = i.CategoryName,
                                                    Value = i.CategoryID.ToString()
                                                }).ToList();
            List<SelectListItem> tagVal = (from i in c.Tags.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.TagName,
                                               Value = i.TagID.ToString()
                                           }).ToList();
            ViewBag.categoryVal = categoryVal;
            ViewBag.tagVal = tagVal;
            return View();

        }
        public IActionResult UpdateProduct(int id)
        {

            List<SelectListItem> categoryVal = (from i in c.Categories.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = i.CategoryName,
                                                    Value = i.CategoryID.ToString()
                                                }).ToList();
            List<SelectListItem> tagVal = (from i in c.Tags.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.TagName,
                                               Value = i.TagID.ToString()
                                           }).ToList();
            ViewBag.categoryVal = categoryVal;
            ViewBag.tagVal = tagVal;
            ViewBag.writeId = pm.GetOnlyProduct(id);
            return View();

        }
        [HttpPost]
        public IActionResult Update(Product p)
        {
            var ktg = c.Categories.Where(m => m.CategoryID == p.CategoryID).FirstOrDefault();
            p.CategoryID = ktg.CategoryID;
            var tg = c.Tags.Where(m => m.TagID == p.TagID).FirstOrDefault();
            p.TagID = tg.TagID;

            pm.BLUpdate(p);
            return RedirectToAction(nameof(Products));
        }
        public IActionResult Publish(int id)
        {
            var values = pm.GetOnlyProduct(id);
            foreach (var item in values)
            {
                if (item.IsPublish)
                {
                    item.IsPublish = false;
                    Update(item);
                }
                else
                {
                    item.IsPublish = true;
                    Update(item);
                }
            }
            return RedirectToAction(nameof(Products));
        }
    }
}
