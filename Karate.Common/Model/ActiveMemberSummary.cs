using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate.Common.Model
{
	public class ActiveMemberSummary
	{
		public int MemberId { get; set; }
		public string Forenames { get; set; }
		public string Surname { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int ClassId { get; set; }

		public DateTime LicenceExpiryDate { get; set; }
	}
}
