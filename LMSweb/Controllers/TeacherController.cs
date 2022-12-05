using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using LMSweb.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using LMSweb.Models;

namespace LMSweb.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class TeacherController : Controller
    {
        private readonly ILogger<TeacherController> _logger;
        private readonly LMSmodel db;

        public TeacherController(ILogger<TeacherController> logger, LMSmodel model)
        {
            _logger = logger;
            db = model;
        }

        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [Route("[action]")]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("[action]")]
        public IActionResult Login(LoginViewModel login)
        {
            var result = db.Teachers.Where(x => x.TID == login.ID && x.Password == login.Password).FirstOrDefault(); //驗證
            if (result != null) //資料庫有資料(這個人)
            {
                var claims = new List<Claim> {
                    //加入使用者的相關資訊
                    new Claim(ClaimTypes.Role, "Student"),
                    new Claim(ClaimTypes.Name, result.TName),
                    new Claim("TID",result.TID)
                };
                ClaimsIdentity identity = new ClaimsIdentity(claims, "Student");

                var authProperty = new AuthenticationProperties {
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    IsPersistent = true,
                };

                HttpContext.SignInAsync(new ClaimsPrincipal(identity),authProperty); // 授權(登入)
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "輸入的帳密可能有誤或是沒有註冊");
                return View(login);
            }
        }        

        [Route("[action]")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
        
    }
}
