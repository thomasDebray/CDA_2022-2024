using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibraryModels
{
	public class BankTransaction : Model
	{
		[Column("transaction_date")]
		//[DataType(DataType.DateTime)]
		//[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0:yyyy-MM-dd HH:mm:ss")]
		[Required]
		public DateTime? Transaction_Date { get; set; }

		[Column("transaction_from")]
		[Required]
		[Range(10000000000,99999999999)]
		public long Transaction_From { get; set; }

		[Column("transaction_to")]
		[Required]
		[Range(10000000000, 99999999999)]
		public long Transaction_To { get; set; }

		[Column("transaction_amount")]
		[Required]
		//[RegularExpression(@"^[0-9]{0,5}(?:[.|,][0-9]{2})$") ]
		[Precision(7,2)]
		[Range(0.01, 99000)]
		public decimal Transaction_Amount { get; set; }
	}
}