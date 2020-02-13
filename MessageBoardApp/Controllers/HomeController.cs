using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MessageBoardApp.Models;
using System.Runtime.Caching;

namespace MessageBoardApp.Controllers
{
    public class HomeController : Controller
    {
        ObjectCache cache = MemoryCache.Default;
        List<UserLogin> userLogin;

        public HomeController()
        {
            userLogin = cache["userLogin"] as List<UserLogin>;
            if (userLogin== null)
            {
                userLogin = new List<UserLogin>();
            }
        }
        public void SaveCache()
        {
            cache["userLogin"] = userLogin;
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
        public IActionResult ViewUser(UserLogin Info)
        {
            UserLogin list = new UserLogin();
            list.UserId = Info.UserId;
            list.UserName = Info.UserName;
            list.MessageContent = Info.MessageContent;
            return View(userLogin);

        }
        public IActionResult AddUser()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddUser(UserLogin user)
        {
            userLogin.Add(user);
            SaveCache();

            return RedirectToAction("UserList");
            
        }
        public IActionResult UserList()
        { 

            return View(userLogin);
        }
    }
}
