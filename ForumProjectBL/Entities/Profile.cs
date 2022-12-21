using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Profile
    {
        public int? ProfileId { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public string? Bio { get; set; }
        public Signature? Signature { get; set; }
        public User? User { get; set; }
        public string? ImagePath { get; set; } /***/
    }
}
