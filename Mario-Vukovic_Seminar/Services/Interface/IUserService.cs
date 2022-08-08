using Mario_Vukovic_Seminar.Models.Binding;
using Mario_Vukovic_Seminar.Models.Dbo;
using Mario_Vukovic_Seminar.Models.ViewModel;

namespace Mario_Vukovic_Seminar.Services.Interface
{
    public interface IUserService
    {
        //Task<ApplicationUser> AddNewUserAsync(ApplicationUserBinding model, string role);
        Task<ApplicationUser?> CreateUserAsync(ApplicationUserBinding model, string role);
        Task<ApplicationUserViewModel> CreateNewUserAsync(ApplicationUserAdminBinding model, string role);
        Task DeleteUserAsync(ApplicationUser model);
        Task<List<ApplicationUserViewModel>> GetAllUsersAsync();
        Task<ApplicationUserViewModel> GetUserAsync(string id);
        Task<string> GetUserRole(string id);
        Task<List<ApplicationUserRolesViewModel>> GetUserRoles();
        Task<ApplicationUserViewModel> UpdateUserAsync(ApplicationUserAdminUpdateBinding model);
    }
}