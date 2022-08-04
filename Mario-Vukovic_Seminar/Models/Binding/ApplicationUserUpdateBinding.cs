using Mario_Vukovic_Seminar.Models.Dbo;

namespace Mario_Vukovic_Seminar.Models.Binding
{
    public class ApplicationUserUpdateBinding:ApplicationUser
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }
}
