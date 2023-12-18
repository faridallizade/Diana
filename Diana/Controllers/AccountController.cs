using Diana.Helpers;
using Diana.Models;
using Diana.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Diana.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _user;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> user, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _user = user;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVm registerVm)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVm);

            }
            AppUser appUser = new AppUser()
            {
                Name = registerVm.Name,
                Surname = registerVm.Surname,
                Email = registerVm.Email,
                UserName = registerVm.UserName,
            };
            var create = await _user.CreateAsync(appUser, registerVm.Password);
            if (!create.Succeeded)
            {
                foreach (var item in create.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }

            //await _user.AddToRoleAsync(appUser, Roles.Admin.ToString());

            return RedirectToAction("Index", "Home");
        }


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVm loginVm, string? ReturnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser user = await _user.FindByNameAsync(loginVm.UsernameOrEmail);
            if (user is null)
            {
                user = await _user.FindByEmailAsync(loginVm.UsernameOrEmail);
                if (user == null)
                {
                    ModelState.AddModelError("", "Invalid Username, Email or Password.");
                    return View();
                }

            }
            var result = _signInManager.CheckPasswordSignInAsync(user, loginVm.Password, true).Result;
            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Try again a few minutes later");
                return View();
            }
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Invalid Username,Email or Password.");
                return View();
            }
            await _signInManager.SignInAsync(user, loginVm.RememberMe);

            if (ReturnUrl != null)
            {
                return Redirect(ReturnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> CreateRole()
        {
            foreach (Roles item in Enum.GetValues(typeof(Roles)))
            {
                if (await _roleManager.FindByNameAsync(item.ToString()) == null)
                {
                    await _roleManager.CreateAsync(new IdentityRole()
                    {
                        Name = item.ToString(),

                    });
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }


}

