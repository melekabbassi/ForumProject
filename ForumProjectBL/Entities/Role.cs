using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Role
    {
        public int? RoleId { get; set; }
        public string? Title { get; set; }
        public string? Permissions { get; set; }
    }
}
