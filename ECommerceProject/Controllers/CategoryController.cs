using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceProject.Models; // Category modeli için eklendi.
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Controllers
{
    public class CategoryController : Controller
    {
        [Route("/kategori/{id}")]
        public IActionResult Index(int id)
        {
            Category category = new Category();

            using (ECommerceContext eCommerceContext = new ECommerceContext())
            {
                category = eCommerceContext.Categories.SingleOrDefault(a => a.Id == id); //categories tablosundan bir tane kayıt getir.

            }
            ViewData["Title"] = category.Name; // Bunun yerine ViewBag fonksiyonu da kullanılabilir.
            return View(category);
        }
    }
}