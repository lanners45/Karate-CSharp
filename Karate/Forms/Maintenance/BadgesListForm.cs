using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Karate.Forms.Maintenance;
using Karate.Common.Model;
using Karate.SqLite.Services;

namespace Karate.Forms
{
    public partial class BadgesListForm : Form
	{
		public BadgesListForm()
		{
			InitializeComponent();
		}

		private void BadgesForm_Load(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void RefreshData()
		{
			List<Badge> badgeList = BadgeData.GetBadges();
			BadgesListView.Items.Clear();
			foreach (Badge badgeItem in badgeList)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = badgeItem.BadgeType;
				lvi.SubItems.Add(badgeItem.BadgeDescription);
				lvi.Tag = badgeItem;
				BadgesListView.Items.Add(lvi);
			}
			BadgesListView.Refresh();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			using (BadgeForm badgeForm = new BadgeForm())
			{
				if (badgeForm.ShowDialog() == DialogResult.OK)
				{
					BadgeData.InsertBadge(badgeForm.GetData());
					RefreshData();
				}
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (BadgesListView.SelectedItems.Count == 1 && MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				BadgeData.DeleteBadge(BadgesListView.SelectedItems[0].Tag as Badge);
				RefreshData();
			}
		}
	}
}
