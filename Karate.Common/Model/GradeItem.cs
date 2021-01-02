using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate.Common.Model
{
	public class GradeItem
	{
		public Int32 GradeId { get; set; }
		public string Grade { get; set; }
		public string BeltDescription { get; set; }
		public int StyleId { get; set; }

		public GradeItem()
		{ }
		public GradeItem(int styleId )
		{
			StyleId = styleId;
		}
	}

}
