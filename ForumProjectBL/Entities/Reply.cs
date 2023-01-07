using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Reply : Message
    {
        public int? ReplyId { get; set; }
        
		[ForeignKey("Question")]
		public int? QuestionId { get; set; }
    }
}
