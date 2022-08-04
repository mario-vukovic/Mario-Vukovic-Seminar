using AutoMapper;
using Mario_Vukovic_Seminar.Data;
using Mario_Vukovic_Seminar.Models.Binding;
using Mario_Vukovic_Seminar.Models.Dbo;
using Mario_Vukovic_Seminar.Models.ViewModel;
using Mario_Vukovic_Seminar.Services.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mario_Vukovic_Seminar.Services.Implementation
{
    public class UserService : IUserService
    {

        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMapper mapper;
        private SignInManager<ApplicationUser> signInManager;
        private readonly ApplicationDbContext db;

        public UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.signInManager = signInManager;
            this.db = db;
        }

        public async Task<ApplicationUser> CreateUserAsync(ApplicationUserBinding model, string role)
        {
            
            var findUserByEmail = await userManager.FindByEmailAsync(model.Email);
            if (findUserByEmail != null)
            {
                throw new Exception("User with that email already exists");
            }

            var user = mapper.Map<ApplicationUser>(model);

            var createUser = await userManager.CreateAsync(user, model.Password);
            if (!createUser.Succeeded) return user;

            var assignRole = await userManager.AddToRoleAsync(user, role);
            if (!assignRole.Succeeded)
            {
                throw new Exception("Role assignment failed!");
            }

            return user;

        }

        public async Task<ApplicationUser> AddNewUserAsync(ApplicationUserBinding model, string role)
        {
            
            var findUserByEmail = await userManager.FindByEmailAsync(model.Email);
            if (findUserByEmail != null)
            {
                throw new Exception("User with that email already exists");
            }
            var user = mapper.Map<ApplicationUser>(model);
            var createUser = await userManager.CreateAsync(user, model.Password);
            if (!createUser.Succeeded) return user;

            var assignRole = await userManager.AddToRoleAsync(user, role);
            if (!assignRole.Succeeded)
            {
                throw new Exception("Role assignment failed!");
            }

            return user;
        }

        public async Task<List<ApplicationUserViewModel>> GetAllUsersAsync()
        {
            var users = await db.ApplicationUser.ToListAsync();
            return users.Select(x => mapper.Map<ApplicationUserViewModel>(x)).ToList();
        }

        public async Task<ApplicationUserViewModel> GetUserAsync(string id)
        {
            var user = await db.ApplicationUser.FirstOrDefaultAsync(x => x.Id == id);
            return mapper.Map<ApplicationUserViewModel>(user);
        }

        public async Task DeleteUserAsync(ApplicationUser model)
        {
            var user = await db.ApplicationUser.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (user != null)
            {
                db.ApplicationUser.Remove(user);
            }
            await db.SaveChangesAsync();
        }

        public async Task<ApplicationUserViewModel> UpdateUserAsync(ApplicationUserUpdateBinding model)
        {
            var user = await db.ApplicationUser.FirstOrDefaultAsync(x => x.Id == model.Id);
            var hasher = new PasswordHasher<ApplicationUser?>();

            user.FirstName = model.FirstName ?? user.FirstName;
            user.LastName = model.LastName ?? user.LastName;
            user.Email = model.Email ?? user.Email;
            user.UserName = model.Email ?? user.UserName;
            user.Dob = model.Dob ?? user.Dob;
            user.NormalizedEmail = model.Email.ToUpper();
            user.NormalizedUserName = model.Email.ToUpper();
            user.EmailConfirmed = model.EmailConfirmed;
            user.Password = model.Password ?? user.Password;
            user.PasswordHash = hasher.HashPassword(user, model.Password);

            await db.SaveChangesAsync();
            return mapper.Map<ApplicationUserViewModel>(user);
        }
    }
}
