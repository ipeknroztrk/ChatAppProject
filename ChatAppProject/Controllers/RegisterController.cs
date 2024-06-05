using System.Threading.Tasks;
using ChatAppProject.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ChatAppProject.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterAppUser p)
        {
            if (!ModelState.IsValid)
            {
                // Model doğrulama hataları varsa sayfayı tekrar göster
                return View(p);
            }

            if (p.Password != p.ConfirmPassword)
            {
                ModelState.AddModelError("", "Şifreler eşleşmiyor.");
                return View(p);
            }



            AppUser appUser = new AppUser
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Email,
                UserName = p.UserName,
                Image = "default_image_url",
               
                

            };

            appUser.NormalizedEmail = p.Email.ToUpperInvariant().ToString();

            var result = await _userManager.CreateAsync(appUser, p.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            // Eğer işlemler başarısız olursa formu yeniden göster
            return View(p);
        }
    }
}
