﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Signature
    {
        [Key]
		public int? SignatureId { get; set; }
        public string? Content { get; set; }
        public byte[]? Image { get; set; }
    }
}
