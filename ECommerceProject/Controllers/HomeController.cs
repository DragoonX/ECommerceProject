using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECommerceProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (ECommerceContext eCommerceContext = new ECommerceContext()) //vt bağlantısı yapıldı.
            {
                //using kullanımı ile komut kullanılmadığında garbage collector ile atılır.
                List<User> users = eCommerceContext.Users.Include(a => a.Addresses).ToList();
                List<Address> address = eCommerceContext.Addresses.Include(b => b.User).ToList();
            }
                return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
