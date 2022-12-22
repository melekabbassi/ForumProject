using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Reply : Message
    {
        public int? ReplyId { get; set; }
        public int? QuestionId { get; set; }
    }
}
