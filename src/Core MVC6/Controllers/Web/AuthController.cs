using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Identity;
using Core_MVC6.ViewModels;
using TravelApp.Controllers;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Core_MVC6.Controllers.Auth
{
    // [Route("[controller]/[action]")]
    public class AuthController : Controller
    {
        private SignInManager<AppUser> signInManager;
        private UserManager<AppUser> userManager;

        public AuthController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Trips", "Home");
            }

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel vm, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var signInResult = await signInManager.PasswordSignInAsync(vm.Username, vm.Password, true, false);

                if (signInResult.Succeeded)
                {
                    if (string.IsNullOrWhiteSpace(returnUrl))
                    {
                        return RedirectToAction("Trips", "Home");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Username or password incorrect");
                }

            }

            return View();
        }

        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser { UserName = model.Username, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        public async Task<ActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await signInManager.SignOutAsync();
            }

            return RedirectToAction("Index", "Home");
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
    }
}
