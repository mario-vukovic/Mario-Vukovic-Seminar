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

        public async Task<ApplicationUser?> CreateUserAsync(ApplicationUserBinding model, string role)
        {
            var findUser = await userManager.FindByEmailAsync(model.Email);
            if (findUser != null)
            {
                return null;
            }
            var user = mapper.Map<ApplicationUser>(model);
            var createdUser = await userManager.CreateAsync(user, model.Password);
            if (createdUser.Succeeded)
            {
                var userAddedToRole = await userManager.AddToRoleAsync(user, role);
                if (!userAddedToRole.Succeeded)
                {
                    throw new Exception("Korisnik nije dodan u rolu!");
                }
            }
            return user;
        }


        public async Task<ApplicationUserViewModel> CreateNewUserAsync(ApplicationUserAdminBinding model, string role)
        {

            var findUser = await userManager.FindByEmailAsync(model.Email);
            if (findUser != null)
            {
                return null;
            }

            var user = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Dob = model.Dob

            };

            var roles = await GetUserRoles();
            var userRole = roles.FirstOrDefault(x => x.Id == model.RoleId);

            var createdUser = await userManager.CreateAsync(user, model.Password);
            if (createdUser.Succeeded)
            {
                var userAddedToRole = await userManager.AddToRoleAsync(user, userRole.Name);
                if (!userAddedToRole.Succeeded)
                {
                    throw new Exception("Korisnik nije dodan u rolu!");
                }
            }
            return mapper.Map<ApplicationUserViewModel>(user);

        }

        //public async Task<ApplicationUser> AddNewUserAsync(ApplicationUserBinding model, string role)
        //{

        //    var findUserByEmail = await userManager.FindByEmailAsync(model.Email);
        //    if (findUserByEmail != null)
        //    {
        //        throw new Exception("User with that email already exists");
        //    }
        //    var user = mapper.Map<ApplicationUser>(model);
        //    var createUser = await userManager.CreateAsync(user, model.Password);
        //    if (!createUser.Succeeded) return user;

        //    var assignRole = await userManager.AddToRoleAsync(user, role);
        //    if (!assignRole.Succeeded)
        //    {
        //        throw new Exception("Role assignment failed!");
        //    }

        //    return user;
        //}

        public async Task<List<ApplicationUserViewModel>> GetAllUsersAsync()
        {
            var users = await db.Users.ToListAsync();
            var response = users.Select(x => mapper.Map<ApplicationUserViewModel>(x)).ToList();
            response.ForEach(x => x.Role = GetUserRole(x.Id).Result);
            return response;
        }

        public async Task<ApplicationUserViewModel> GetUserAsync(string id)
        {
            var user = await db.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
            {
                return null;
            }

            var response = mapper.Map<ApplicationUserViewModel>(user);
            response.Role = await GetUserRole(id);
            return response;
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

        public async Task<ApplicationUserViewModel> UpdateUserAsync(ApplicationUserAdminUpdateBinding model)
        {
            var dboUser = await db.Users
                .FirstOrDefaultAsync(x => x.Id == model.Id);
            var role = await db.Roles.FindAsync(model.RoleId);


            if (dboUser == null || role == null)
            {
                return null;
            }


            await DeleteAllUserRoles(dboUser);
            await userManager.AddToRoleAsync(dboUser, role.Name);

            dboUser.FirstName = model.FirstName;
            dboUser.LastName = model.LastName;
            dboUser.Dob = model.Dob;
            await db.SaveChangesAsync();


            var response = mapper.Map<ApplicationUserViewModel>(dboUser);
            return response;
        }

        public async Task<List<ApplicationUserRolesViewModel>> GetUserRoles()
        {

            var roles = await db.Roles.ToListAsync();
            if (!roles.Any())
            {
                return new List<ApplicationUserRolesViewModel>();
            }

            return roles.Select(x => mapper.Map<ApplicationUserRolesViewModel>(x)).ToList();
        }

        public async Task<string> GetUserRole(string id)
        {
            var user = await db.Users.FindAsync(id);
            if (user == null)
            {
                return String.Empty;
            }
            var roles = await userManager.GetRolesAsync(user);
            return roles.First();
        }

        private async Task DeleteAllUserRoles(ApplicationUser user)
        {
            var userRoles = await userManager.GetRolesAsync(user);
            foreach (var item in userRoles)
            {
                await userManager.RemoveFromRoleAsync(user, item);
            }
        }




    }
}
