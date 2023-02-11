using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductDetail.DAL;
using ProductDetail.Models;
using ProductDetail.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDetail.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            List<Picture> pictures = _context.Pictures.Include(x => x.Product).ToList();

            HomeVm homeVm = new HomeVm();
            homeVm.Products = products;
            homeVm.Pictures = pictures;
            return View(homeVm);
        }
    }
}
