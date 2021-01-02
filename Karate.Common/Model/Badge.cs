using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate.Common.Model
{
	public class Badge
	{
		public int BadgeId { get; set; }
		public string BadgeType { get; set; }
		public string BadgeDescription { get; set; }

		public Badge(string type, string description)
		{
			BadgeType = type;
			BadgeDescription = description;
		}

		public Badge()
		{

		}
	}
}
