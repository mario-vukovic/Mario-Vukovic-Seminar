using Mario_Vukovic_Seminar.Models.Base;
using Mario_Vukovic_Seminar.Models.Dbo;

namespace Mario_Vukovic_Seminar.Models.ViewModel
{
    public class ApplicationUserViewModel : ApplicationUserBase
    {
        public string? Id { get; set; }
        public string Role { get; set; }

    }
}
