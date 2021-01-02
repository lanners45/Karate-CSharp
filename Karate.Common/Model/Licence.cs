using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate.Common.Model
{
	public class Licence 
	{
		public int LicenceId { get; set; }
		public int MemberId { get; set; }
		public DateTime? ExpiryDate { get; set; }
	}
}
