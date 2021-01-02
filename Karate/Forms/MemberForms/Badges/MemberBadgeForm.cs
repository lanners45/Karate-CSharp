using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Karate.Helper;
using Karate.Common.Model;
using Karate.SqLite.Services;

namespace Karate.Forms.MemberForms.Badges
{
	public partial class MemberBadgeForm : Form
	{
		Member _member = new Member();

		static string title = "Member Badges for ";

		public MemberBadgeForm()
		{
			InitializeComponent();
		}

		public void LoadData(Member member)
		{
			_member = member;
			this.Text = title + _member.GetFullName;
			RefreshViewData();
		}

		private void RefreshViewData()
		{
			List<MemberBadge> badgeList = BadgeData.GetBadgesByMemberId(_member);
			MemberBadgeListView.Items.Clear();
			foreach (MemberBadge item in badgeList)
			{
				ListViewItem lvi = new ListViewItem(KarateHelper.SetDateViewFormat(item.DateAchieved));
				lvi.SubItems.Add(item.BadgeType);
				lvi.SubItems.Add(item.BadgeDescription);
				lvi.Tag = item;
				MemberBadgeListView.Items.Add(lvi);
			}
			MemberBadgeListView.Refresh();
		}

		private void AddBageButton_Click(object sender, EventArgs e)
		{
			using (Badges.BadgeForm badgeForm = new BadgeForm())
			{
				badgeForm.LoadData(_member.MemberId);
				if (badgeForm.ShowDialog() == DialogResult.OK)
				{
					MemberBadge badgeItem = badgeForm.GetData();
					badgeItem.MemberId = _member.MemberId;
					MemberData.InsertMemberBadge(badgeItem);
				}
			}
			RefreshViewData();
		}

		private void DeleteBadgeButton_Click(object sender, EventArgs e)
		{
			if (MemberBadgeListView.SelectedItems.Count == 1 && MessageBox.Show("Are you sure you want to delete grade this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				MemberBadge badgeItem = MemberBadgeListView.SelectedItems[0].Tag as MemberBadge;
				BadgeData.DeleteBadge(badgeItem);
				MemberBadgeListView.Refresh();
			}
			RefreshViewData();
		}
	}
}
