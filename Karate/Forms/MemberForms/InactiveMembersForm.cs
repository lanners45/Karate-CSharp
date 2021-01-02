using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Karate.Helper;
using Karate.Common.Model;
using Karate.SqLite.Services;

namespace Karate.Forms
{
	public partial class InactiveMembersForm : Form
	{
		public InactiveMembersForm()
		{
			InitializeComponent();
		}
		private void ActiveMembersForm_Load(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void PrintButton_Click(object sender, EventArgs e)
		{
			using (PrintForm printForm = new PrintForm())
			{
				printForm.LoadData(MemberData.GetInactiveMembers());  // to do 
				printForm.ShowDialog();
			}
		}

		private void LicenceButton_Click(object sender, EventArgs e)
		{
			if (InActiveMembersListView.SelectedItems.Count == 0)
			{
				MessageBox.Show("No member selected", "Karate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Member selectedMember = InActiveMembersListView.SelectedItems[0].Tag as Member;
			Licence licence = LicenseData.GetLicenseByMember(selectedMember).FirstOrDefault();
			LicenceForm licenceForm = new LicenceForm();
			licenceForm.SetData(string.Format("{0} {1}", selectedMember.Forenames, selectedMember.Surname), licence);
			if (licenceForm.ShowDialog() == DialogResult.OK)
			{
				if (licence == null)
				{
					licence = new Licence();
					licence.ExpiryDate = licenceForm.GetData();
					licence.MemberId = selectedMember.MemberId;
					LicenseData.InsertLicense(licence);
				}
				else
				{
					licence.ExpiryDate = licenceForm.GetData();
					LicenseData.UpdateLicense(licence);
				}
				RefreshData();
			}

		}

		private void RefreshData()
		{
			List<Member> membersList = MemberData.GetInactiveMembers();
			InActiveMembersListView.Items.Clear();
			foreach (Member member in membersList)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = member.Forenames;
				lvi.SubItems.Add(member.Surname);
				//lvi.SubItems.Add(member.ClassItems.ClassName);
				lvi.SubItems.Add(KarateHelper.GetInactiveDays(member.InactiveDate).ToString());
				lvi.Tag = member;
				InActiveMembersListView.Items.Add(lvi);
			}

			if (membersList.Count() == 0)
			{
				PrintButton.Enabled = false;
			}
		}

		private void ReactiveMemberButton_Click(object sender, EventArgs e)
		{
			if (InActiveMembersListView.SelectedItems.Count == 0)
			{
				MessageBox.Show("No member selected", "Karate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Member selectedMember = InActiveMembersListView.SelectedItems[0].Tag as Member;

			MemberData.ReactiveMember(selectedMember);
			RefreshData();
		}

		private void InActiveMembersListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			this.InActiveMembersListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
		}
	}
}
