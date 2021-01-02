using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karate.Helper
{
	public static class KarateHelper
	{
		public const long TicksPerDay = 864000000000;

		public static int GetAge(DateTime birthdate)
		{
            try
            {
                TimeSpan span = DateTime.Now - birthdate;
                DateTime zeroTime = new DateTime(1, 1, 1);
                return (zeroTime + span).Year - 1;
            }
            catch
            {
                return -1;
            }
		}

		public static long GetInactiveDays(DateTime inactiveDate)
		{
			return DateTime.Now.Subtract(inactiveDate).Ticks;
		}
		public static string SetDateViewFormat(DateTime value)
		{
			return value.ToString("dd/MM/yyyy");
		}

		public static ListViewItem SetLviBackGroundColour(ListViewItem lvi, DateTime expiryDate)
		{
			long days = (expiryDate.Ticks - DateTime.Now.Ticks) / TicksPerDay;
			if (days >= 0 && days < 31)
			{
				lvi.BackColor = System.Drawing.Color.Yellow;
			}
			else if (days <0)
            {
				lvi.BackColor = System.Drawing.Color.Salmon;
			}

			return lvi;
		}
	}
}
