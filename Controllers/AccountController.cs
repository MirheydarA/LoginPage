using LoginTemplate.Entities;
using LoginTemplate.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginTemplate.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager )
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterVM model)
        {
            if (!ModelState.IsValid) return View();

            var user = new User
            {
                Email = model.Email,
                UserName = model.Username,
                Fullname = model.Fullname,
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View();
            }

            return RedirectToAction(nameof(Login));
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
		public async Task<IActionResult> Login(AccountLoginVM model)
		{
			if (!ModelState.IsValid) return View();

			var user = await _userManager.FindByEmailAsync(model.Email);
			if (user == null)
			{
				ModelState.AddModelError(string.Empty, "Email or Password is incorrect");
				return View();
			}

			var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
			if (!result.Succeeded)
			{
				ModelState.AddModelError(string.Empty, "Email or Password is incorrect");
				return View();
			}

			return Content("Succesfully Login");
		}

	}
}
