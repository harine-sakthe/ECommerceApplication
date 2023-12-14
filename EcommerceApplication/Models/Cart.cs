using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace EcommerceApplication.Models
{
	public class Cart
	{
		[Key]
		public int Id { get; set; }

		public virtual ICollection<Product> Products { get; set; }

		[ForeignKey(nameof(User))]
		public int UserId { get; set; }

		public virtual User User { get; set; }

	}
}
