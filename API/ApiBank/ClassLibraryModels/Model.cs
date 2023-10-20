using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels
{
	abstract public class Model
	{
		[Key]
		[Column("transaction_id")]
		public int Transaction_Id { get; set; }
	}
}
