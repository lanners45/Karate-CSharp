using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate.Common.Model
{
	public class SummaryMember : Member
	{
		public List<GradeItem> Grades { get; set; }
        public Licence LicenceInformation { get; set; }
        public WebCredential WebCredentialInformation { get; set; }
	}
}
