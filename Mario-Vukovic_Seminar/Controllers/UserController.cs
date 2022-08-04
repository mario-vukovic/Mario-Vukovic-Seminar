using AutoMapper;
using Mario_Vukovic_Seminar.Models.Binding;
using Mario_Vukovic_Seminar.Models.Dbo;
using Mario_Vukovic_Seminar.Services.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Mario_Vukovic_Seminar.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IMapper mapper;


        public UserController(IUserService userSevice, SignInManager<ApplicationUser> signInManager, IMapper mapper)
        {
            this.userService = userSevice;
            this.signInManager = signInManager;
            this.mapper = mapper;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(ApplicationUserBinding model)
        {
            var register = await userService.CreateUserAsync(model, "BasicUser");
            if (true)
            {
                await signInManager.SignInAsync(register, false);
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> UserManagement()
        {
            var users = await userService.GetAllUsersAsync();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(ApplicationUserBinding model, string role)
        {
            await userService.AddNewUserAsync(model, "BasicUser");
            return RedirectToAction("UserManagement");
        }

        public async Task<IActionResult> UserDetails(string id)
        {
            var user = await userService.GetUserAsync(id);
            return View(user);
        }

        public async Task<IActionResult> UpdateUser(string id)
        {
            var user = await userService.GetUserAsync(id);
            var model = mapper.Map<ApplicationUserUpdateBinding>(user);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(ApplicationUserUpdateBinding model)
        {
            var user = await userService.UpdateUserAsync(model);
            return RedirectToAction("UserManagement");
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userService.GetUserAsync(id);
            var model = mapper.Map<ApplicationUser>(user);
            return View(model);
        }

        [HttpPost, ActionName("DeleteUser")]
        public async Task<IActionResult> DeleteUserConfirmed(string id)
        {
            var user = await userService.GetUserAsync(id);
            var model = mapper.Map<ApplicationUser>(user);

            await userService.DeleteUserAsync(model);

            return RedirectToAction("UserManagement");
        }
    }
}
