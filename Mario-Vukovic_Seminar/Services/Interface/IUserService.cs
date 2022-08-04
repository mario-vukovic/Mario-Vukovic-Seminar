using Mario_Vukovic_Seminar.Models.Binding;
using Mario_Vukovic_Seminar.Models.Dbo;
using Mario_Vukovic_Seminar.Models.ViewModel;

namespace Mario_Vukovic_Seminar.Services.Interface;

public interface IUserService
{
    Task<ApplicationUser> CreateUserAsync(ApplicationUserBinding model, string role);
    Task<ApplicationUser> AddNewUserAsync(ApplicationUserBinding model, string role);
    Task<List<ApplicationUserViewModel>> GetAllUsersAsync();
    Task<ApplicationUserViewModel> GetUserAsync(string id);
    Task DeleteUserAsync(ApplicationUser model);
    Task<ApplicationUserViewModel> UpdateUserAsync(ApplicationUserUpdateBinding model);
}