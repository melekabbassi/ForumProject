using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Signature
    {
        public int? SignatureId { get; set; }
        public string? Content { get; set; }
        public byte[]? Image { get; set; }
    }
}
