using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SinggnalR.DAL;
using SinggnalR.Hubs;
using SinggnalR.Models;
using SinggnalR.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SinggnalR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly Context _context;
        private readonly IHubContext<ChatHub> _hubContext;

        public HomeController(IHubContext<ChatHub> hubContext, ILogger<HomeController> logger,UserManager<AppUser>userManager,SignInManager<AppUser>signInManager, DAL.Context context)
        {
            _logger = logger;
            _userManager = userManager;
           _signInManager = signInManager;
            _context = context;
            _hubContext = hubContext;
        }

        public IActionResult Index()
        {
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


        public IActionResult Chat()
        {

            var users = _userManager.Users.ToList();
            ViewBag.Users = users;
            return View();
        }


        public async Task<IActionResult> CreateUser()
        {
            var user1 = new AppUser { FullName = "UserTest1", UserName = "user1" };
            var user2 = new AppUser { FullName = "UserTest2", UserName = "user2" };
            var user3 = new AppUser { FullName = "UserTest3", UserName = "user3" };

            await _userManager.CreateAsync(user1, "12345@Ab");
            await _userManager.CreateAsync(user2, "12345@Ab");
            await _userManager.CreateAsync(user3, "12345@Ab");

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            AppUser user = await _userManager.FindByNameAsync(loginVM.UserName);

           var result= await _signInManager.PasswordSignInAsync(user, loginVM.Password, true, true);


            if (user == null) return NotFound();

            return RedirectToAction(nameof(Chat));
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
