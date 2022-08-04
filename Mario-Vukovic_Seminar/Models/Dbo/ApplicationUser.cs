using Microsoft.AspNetCore.Identity;

namespace Mario_Vukovic_Seminar.Models.Dbo
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public DateTime Dob { get; set; }


    }
}
