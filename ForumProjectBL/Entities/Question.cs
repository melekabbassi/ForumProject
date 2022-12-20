using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Question : Message
    {
        public int? QuestionId { get; set; }
        public List<Reply>? Replies { get; set; }
    }
}
