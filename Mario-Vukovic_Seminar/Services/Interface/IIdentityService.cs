using Mario_Vukovic_Seminar.Models.Dbo;

namespace Mario_Vukovic_Seminar.Services.Interface;

public interface IIdentityService
{
    Task CreateRoleAsync(string role);
    Task CreateUserAsync(ApplicationUser applicationUser, string password, string role);
}