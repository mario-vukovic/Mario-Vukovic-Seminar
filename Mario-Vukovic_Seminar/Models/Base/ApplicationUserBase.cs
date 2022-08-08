namespace Mario_Vukovic_Seminar.Models.Base
{
    public abstract class ApplicationUserBase
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Dob { get; set; }
    }
}
