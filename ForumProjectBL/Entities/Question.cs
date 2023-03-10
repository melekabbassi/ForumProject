using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Question : Message
    {
		public int? QuestionId { get; set; }
        //public List<Reply>? Replies { get; set; }
		public virtual IEnumerable<Reply>? Replies { get; set; }

        [ForeignKey("Discussion")]
        public int? DiscussionId { get; set; }
    }
}
