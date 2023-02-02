using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TheBlog.Models
{
	public class Tag
	{
		public int Id { get; set; }
		public int PostId { get; set; }
		public string AuthorId { get; set; }

		[Required]
        [StringLength(25, ErrorMessage = "The {0} must be at least {2} and at most {1}", MinimumLength = 2)]
		public string Text { get; set; }


		// Navigation Properties
		public virtual Post Post { get; set; }
		public virtual IdentityUser Author { get; set; }
	}
}

