using IdentityCase.Entities;
using IdentityCase.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCase.Controllers
{
    public class RegisterController : Controller
    {
        //Kayıt işlemleri controllerı

        private readonly UserManager<AppUser> _userManager; //dependency injection

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                UserName = model.UserName,
            };
            //await ıdentitylere register işlemi dağlıypr
            var result = await _userManager.CreateAsync(appUser, model.Password); //passwordu burda kulanmamızın sebebi hashlemek

            if (result.Succeeded)
            {
                return RedirectToAction("UserLogin", "Login");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }

        }
    }
}
// async garson siparişi aşçıya yöneltti, siparişi yönelttikten sonra dönüp başka işler yapması yani başka sipariş alması veya masaları temizlemesi gibi işleri yapmaya devam etmesi asenkron yapı denir