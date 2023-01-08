using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Discussion
    {
        [Key]
        public int? DiscussionId { get; set; }

        [MaxLength(50), MinLength(10)]
        public string? Title { get; set; }

        [MaxLength(500), MinLength(50)]
        public string? Description { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime? Date { get; set; }


        [ForeignKey("Theme")]
        public int? ThemeId { get; set; }
        //public List<User>? Users { get; set; }
        //public List<Question>? Questions { get; set; }        
        public virtual IEnumerable<User>? Users { get; set; }
        public virtual IEnumerable<Question>? Questions { get; set; }
    }
}
