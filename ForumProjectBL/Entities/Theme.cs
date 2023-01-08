using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Theme
    {
        [Key]
		public int? ThemeId { get; set; }

		[MaxLength(50)]
		public string? Title { get; set; }

		[MaxLength(100)]
		public string? Description { get; set; }

		public virtual IEnumerable<Discussion>? Discussions { get; set; }
	}
}
