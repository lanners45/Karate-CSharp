using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Karate.Helper;
using Karate.Common.Model;
using Karate.SqLite.Services;

namespace Karate.Forms.MemberForms
{
	public partial class MemberGradingForm : Form
	{
		Member _member = new Member();

		public MemberGradingForm()
		{
			InitializeComponent();
		}

		public void LoadData(Member member)
		{
			_member = member;
			RefreshViewData();
		}

		private void AddStyleButton_Click(object sender, EventArgs e)
		{
			using (Gradings.GradeForm gradeForm = new Gradings.GradeForm())
			{
				if (gradeForm.ShowDialog() == DialogResult.OK)
				{
					GradingItem gradingItem = gradeForm.GetData();
					gradingItem.MemberId = _member.MemberId;
					GradeData.InsertMemberGrading(gradingItem);
				}
			}
			RefreshViewData();
		}

		private void DeleteStyleButton_Click(object sender, EventArgs e)
		{
			if (MemberGradeListView.SelectedItems.Count == 1 && MessageBox.Show("Are you sure you want to delete grade this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				GradingItem gradingItem = MemberGradeListView.SelectedItems[0].Tag as GradingItem;
				GradeData.DeleteMemberGrading(gradingItem);
				MemberGradeListView.Refresh();
			}
			RefreshViewData();
		}

		private void RefreshViewData()
		{
			Dictionary<Int32, string> styles = StyleData.GetStyles().ToDictionary(x => x.StyleId, x => x.Name);
			List<GradingItem> gradingList = GradeData.GetGradesByMemberId(_member).OrderBy(x => x.StyleId).ToList();
			MemberGradeListView.Items.Clear();

			foreach (KeyValuePair<Int32, string> kvp in styles)
			{
				foreach (GradingItem item in gradingList.Where(x => x.StyleId == kvp.Key))
				{
					this.MemberGradeListView.Groups.Add(new ListViewGroup(kvp.Value, kvp.Value));
					ListViewItem lvi = new ListViewItem(KarateHelper.SetDateViewFormat(item.DateAchieved));
					lvi.SubItems.Add(item.Grade);
					lvi.SubItems.Add(item.BeltDescription);
					if (gradingList.Last().GradingId == item.GradingId)
					{
						lvi.SubItems.Add("Yes");
						lvi.BackColor = System.Drawing.Color.LightGreen;
					}

					lvi.Group = this.MemberGradeListView.Groups[kvp.Value.ToString()];
					lvi.Tag = item;
					MemberGradeListView.Items.Add(lvi);
				}
			}
			MemberGradeListView.Refresh();
		}
	}
}
