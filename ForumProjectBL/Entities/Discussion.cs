using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Discussion
    {
        public int? DiscussionId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public int? ThemeId { get; set; }
        public List<User>? Users { get; set; }
        public List<Question>? Questions { get; set; }        
    }
}
