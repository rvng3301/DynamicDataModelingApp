namespace WebApplication2.Models
{
    public class LibraryMember
    {
        public int LibraryMemberId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime MembershipDate { get; set; }
    }
}