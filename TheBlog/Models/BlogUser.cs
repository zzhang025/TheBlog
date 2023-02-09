using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TheBlog.Models
{
	public class BlogUser : IdentityUser
	{
		[Required]
		[Display(Name ="First Name")]
		public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

		public byte[]? Image { get; set; }
		public string? ContentType { get; set; }

		public string? FacebookUrl { get; set; }
		public string? TwitterUrl { get; set; }

		[NotMapped]
		public string FullName {

			get
			{
				return $"{FirstName}{LastName}";
			}
		}

		// navigational property
		public virtual ICollection<Blog> Blogs { get; set; } = new HashSet<Blog>();
		public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
	}
}

