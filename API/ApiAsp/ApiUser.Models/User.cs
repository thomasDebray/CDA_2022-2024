using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUser.Models
{
	[Table("Users")]
	public class User : Model
	{
		// [Column("user_name")]
		[Required(ErrorMessage = "Le nom d'utilisateur est requis")]
		// [MaxLength(16, ErrorMessage = "")]
		[StringLength(maximumLength: 16, MinimumLength = 2)]
		[RegularExpression(@"^[a-zA-Z]+(?:\-[a-zA-Z]+)?$")]
		public string? UserName { get; set; }

		[Required(ErrorMessage = "Le mot de passe est obligatoire")]
		[RegularExpression(@"^[a-zA-Z0-9]{8,}$")]
		public string? Password { get; set; }
	}
}
