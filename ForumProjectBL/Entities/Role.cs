using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Role
    {
		[Key]
		public int? RoleId { get; set; }

        [MaxLength(20)]
        public string? Title { get; set; }

        public string? Permissions { get; set; }
    }
}
