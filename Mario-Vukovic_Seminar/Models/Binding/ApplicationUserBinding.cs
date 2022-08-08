using Mario_Vukovic_Seminar.Models.Base;
using Mario_Vukovic_Seminar.Models.Dbo;

namespace Mario_Vukovic_Seminar.Models.Binding
{
    public class ApplicationUserBinding : ApplicationUserBaseBinding
    {

    }

    public class ApplicationUserBaseBinding
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Dob { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class ApplicationUserAdminBinding : ApplicationUserBaseBinding
    {
        public string RoleId { get; set; }
    }

    public class ApplicationUserAdminUpdateBinding : ApplicationUserAdminBinding
    {
        public string Id { get; set; }
    }

}
