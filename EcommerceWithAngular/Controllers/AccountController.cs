using EcommerceWithAngular.Models;
using EcommerceWithAngular.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWithAngular.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Customer> userManager;
        private readonly SignInManager<Customer> signInManager;
        private readonly IEmailSender emailSender;
        private readonly ILogger logger;

        public AccountController(
            UserManager<Customer> userManager,
            SignInManager<Customer> signInManager,
            IEmailSender emailSender,
            ILogger<AccountController> logger)
        {
            userManager = userManager;
            signInManager = signInManager;
            emailSender = emailSender;
            logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            return View();
        }
    }
}
