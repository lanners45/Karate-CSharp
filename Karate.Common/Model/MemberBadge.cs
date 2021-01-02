using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate.Common.Model
{
	public class MemberBadge : Badge
	{
		public DateTime DateAchieved { get; set; }
		public int MemberId { get; set; }

		public MemberBadge(int badgeId, string type, string description) : base(type, description)
		{
			BadgeId = badgeId;
		}

		public MemberBadge()
		{

		}
	}
}
