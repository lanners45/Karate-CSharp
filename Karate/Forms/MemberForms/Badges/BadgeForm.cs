using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Karate.Common.Model;
using Karate.SqLite.Services;

namespace Karate.Forms.MemberForms.Badges
{
	public partial class BadgeForm : Form
	{
		const string _title = "Adding new badge ";
		public BadgeForm()
		{
			InitializeComponent();
		}

		public MemberBadge GetData()
		{
			MemberBadge badgeItem = BadgeListView.SelectedItems[0].Tag as MemberBadge;
			badgeItem.DateAchieved = DateAchievedDatePicker.Value;
			return badgeItem;
		}

		public void LoadData(int memberId)
		{
		//	List<MemberBadge> memberBadgeList = Karate.SqLite.Services.BadgeData.GetBadges(memberId);

			List<Badge> badgeList = BadgeData.GetBadges();
			foreach (MemberBadge badgeItem in badgeList) //.Where(p => !memberBadgeList.Any(p2 => p2.BadgeId == p.BadgeId)))
			{
				ListViewItem lvi = new ListViewItem(badgeItem.BadgeType);
				lvi.SubItems.Add(badgeItem.BadgeDescription);
				lvi.Tag = badgeItem;
				BadgeListView.Items.Add(lvi);
			}
			BadgeListView.Refresh();
		}
		private void EnableSaveButton()
		{ 
			if (BadgeListView.SelectedItems.Count == 1)
			{
				SaveButton.Enabled = true;
			}	
			else
			{
				SaveButton.Enabled = false;
			}
		}

		private void BadgeListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			EnableSaveButton();
		}
	}
}
