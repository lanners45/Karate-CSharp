using System.Windows.Forms;
using Karate.Common.Model;

namespace Karate.Forms.Maintenance
{
	public partial class BadgeForm : Form
	{
		public BadgeForm()
		{
			InitializeComponent();
		}

		public Badge GetData()
		{
			Badge badgeItem = new Badge();
			badgeItem.BadgeType = BadgeTypeTextBox.Text;
			badgeItem.BadgeDescription = BadgeDescriptionTextbox.Text;

			return badgeItem;
		}
	}
}
