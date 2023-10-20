using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCereals.Models
{
	[Table("tbl_cereals")]
	public class Cereal
	{
		[Key]
		public int CerealId { get; set; }

		[Required]
		//[Column("nom_de_la_colnne_en_base_de_donnees")]
		public string Name { get; set; }

		[Required]
		public int Calories { get; set; }

		[Required]
		public int Protein { get; set; }


	}
}
