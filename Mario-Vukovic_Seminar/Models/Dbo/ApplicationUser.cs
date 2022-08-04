using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Mario_Vukovic_Seminar.Models.Dbo
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public DateTime Dob { get; set; }

        public string? Role
        {
            get
            {
                switch (FirstName)
                {
                    case "Admin":
                        return "Admin";
                    case "BasicUser":
                        return "BasicUser";
                    default:
                        return "BasicUser";
                }
            }
        }
    }
}
