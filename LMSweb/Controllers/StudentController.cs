using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using LMSweb.ViewModels;
using LMSweb.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace LMSweb.Controllers
{
    [Authorize(Roles="Student")]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly LMSmodel db;

        public StudentController(ILogger<StudentController> logger, LMSmodel model)
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

        [AllowAnonymous]
        [Route("[action]")]
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
            var result = db.Students.Where(x => x.SID == login.ID && x.Password == login.Password).FirstOrDefault(); //驗證
            if (result != null) //資料庫有資料(這個人)
            {
                var claims = new List<Claim> {
                    //加入使用者的相關資訊
                    new Claim(ClaimTypes.Role, "Student"),
                    new Claim(ClaimTypes.Name, result.SName),
                    new Claim("SID",result.SID)
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
