using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ForumProjectBL.Entities
{
    public class User : IdentityUser
    {
        [Key]
		public int? UserId { get; set; }

		[MaxLength(20)]
		public string? FirstName { get; set; }

		[MaxLength(20)]
		public string? LastName { get; set; }
        public List<Discussion>? Favorites { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime? SignUpDate { get; set; }
		
		public Role? Role { get; set; }
    }
}