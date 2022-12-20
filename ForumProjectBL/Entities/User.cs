using Microsoft.AspNetCore.Identity;

namespace ForumProjectBL.Entities
{
    public class User : IdentityUser
    {
        public int? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<Discussion>? Favorites { get; set; }
        public DateTime? SignUpDate { get; set; }
        public Role? Role { get; set; }
    }
}