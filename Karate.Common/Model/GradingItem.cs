using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate.Common.Model
{
	public class GradingItem
	{
		public int MemberId { get; set; }
		public int GradeId { get; set; }
		public DateTime DateAchieved { get; set; }
		public int GradingId { get; set; }
		public int StyleId { get; set; }
		public string Grade { get; set; }
		public string BeltDescription { get; set; }
	}
}
