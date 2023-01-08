using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumProjectBL.Entities
{
    public class Message
    {
        [Key]
		public int? MessageId { get; set; }

		[MaxLength(50), MinLength(5)]
		public string? Title { get; set; }

		[MaxLength(500), MinLength(10)]
		public string? Content { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime? Date { get; set; }
		
        //public User? Author { get; set; }
        public virtual User? Author { get; set; }
    }
}
