using Mario_Vukovic_Seminar.Models.Dbo;

namespace Mario_Vukovic_Seminar.Models.Binding
{
    public class ApplicationUserBinding:ApplicationUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Dob { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }
}
