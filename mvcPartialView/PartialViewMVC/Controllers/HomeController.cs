using StronglyTypedPartialViewMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedPartialViewMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        List<Product> ProductesList = new List<Product>()
        {
            new Product{id=1,name="Reebok Shoes", price=10000.00,picture="~/images/alexa.jpg"},
            new Product{id=2,name="Reebok Shoes", price=20000.00,picture="~/images/find.png"},
            new Product{id=3,name="Reebok Shoes", price=30000.00,picture="~/images/sell.jpg"},
        };

        public ActionResult Index()
        { 
            return View(ProductesList);
        }
    }
}