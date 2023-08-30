using DataAccess.EntityFramework;
using DTO;
using Entity;
using Graduation_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace Graduation_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ShoppingContext _context;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ShoppingContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginViewModel.Username, loginViewModel.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Register(AppUserRegisterDto appUserRegisterDto)
		{
            var user = await _userManager.FindByNameAsync(appUserRegisterDto.Username);

            if (user != null)  // herhangi bir kayıt varsa
            {
                TempData["Error"] = "Bu isimde bir kayıt bulunmaktadır... Lütfen değiştiriniz";
                return View(appUserRegisterDto);
            }

            if (ModelState.IsValid)
			{
				AppUser appUser = new AppUser()
				{
					UserName = appUserRegisterDto.Username,
					Name = appUserRegisterDto.Name,
					Surname = appUserRegisterDto.Surname,
					Email = appUserRegisterDto.EMail,

				};
				var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);

				if (result.Succeeded)
				{
					await _userManager.AddToRoleAsync(appUser, UserRoles.User);

					return RedirectToAction("Login", "Account");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View();
		}

        // Logout Bölümü (göndericek olan yer Logout Butonu)
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
