using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Karate.Forms.Documents;
using Karate.Forms.MemberForms;
using Karate.Forms.MemberForms.Badges;
using Karate.Helper;
using Karate.Common.Model;
using System.Linq;
using Karate.SqLite.Services;

namespace Karate.Forms
{
    public partial class ActiveMembersForm : Form
	{
		private bool IsFilterApplied = false;
		private List<ClassItem> classList = new List<ClassItem>();

		public ActiveMembersForm()
		{
			InitializeComponent();
		}
		private void ActiveMembersForm_Load(object sender, EventArgs e)
		{
            try
            {
				classList = SqLite.Services.ClassData.GetClassItems();

				foreach (ClassItem classItem in classList)
                {
                    ClassComboBox.Items.Add(classItem);
                    ClassComboBox.DisplayMember = "ClassItem.Name";
				}

                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Karate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			if (ActiveMembersListView.SelectedItems.Count == 0)
			{
				MessageBox.Show("No member selected", "Karate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			using (MemberForm memberForm = new MemberForm())
			{
				ActiveMemberSummary selectedMember = ActiveMembersListView.SelectedItems[0].Tag as ActiveMemberSummary;
				memberForm.PopulateForm(selectedMember);
				if (memberForm.ShowDialog() == DialogResult.OK)
				{
					Member member = memberForm.GetData();
					SqLite.Services.MemberData.UpdateMember(member);
					if (member.Address != null)
					{
						SqLite.Services.AddressData.UpdateAddress(member.Address);
					}
				}
			}
			RefreshData();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			using (MemberForm memberForm = new MemberForm())
			{
				if (memberForm.ShowDialog() == DialogResult.OK)
				{
                    Member member = memberForm.GetData();
                    member.StatusId = 1;
                    MemberData.InsertMember(member);
				}
			}
			RefreshData();
		}

		private void PrintButton_Click(object sender, EventArgs e)
		{
			using (PrintForm printForm = new PrintForm())
			{
				List < Member> activeMembers = MemberData.GetActiveMembers();
				printForm.LoadData(activeMembers);
				printForm.ShowDialog();
			}
		}

		private void LicenceButton_Click(object sender, EventArgs e)
		{
			if (ActiveMembersListView.SelectedItems.Count == 0)
			{
				MessageBox.Show("No member selected", "Karate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Member selectedMember = ActiveMembersListView.SelectedItems[0].Tag as Member;
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
			}
		}

		private void GradingsButton_Click(object sender, EventArgs e)
		{
			if (ActiveMembersListView.SelectedItems.Count == 0)
			{
				MessageBox.Show("No member selected", "Karate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Member selectedMember = ActiveMembersListView.SelectedItems[0].Tag as Member;

			using (MemberGradingForm memberGradingForm = new MemberGradingForm())
			{
				memberGradingForm.LoadData(selectedMember);
				memberGradingForm.ShowDialog();
			}
		}

		private void BadgesButton_Click(object sender, EventArgs e)
		{
			if (ActiveMembersListView.SelectedItems.Count == 0)
			{
				MessageBox.Show("No member selected", "Karate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			try
			{
				Member selectedMember = ActiveMembersListView.SelectedItems[0].Tag as Member;

				using (MemberBadgeForm memberBadgeForm = new MemberBadgeForm())
				{
					memberBadgeForm.LoadData(selectedMember);
					memberBadgeForm.ShowDialog();
				}
			}
			catch (Exception ex)
			{
				using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + @"\errors.txt"))
				{
					sw.Write(ex);
					MessageBox.Show("Error Logged to errors.txt");
				}
			}
		}

		private void RefreshData()
		{
			List<ActiveMemberSummary> membersList = SqLite.Services.MemberData.GetActiveSummary();
			ActiveMembersListView.Items.Clear();
			foreach (ActiveMemberSummary member in membersList)
			{
				var classItem = classList.Single(item => item.ClassId == member.ClassId);
				if (IsFilterApplied == false || (IsFilterApplied && StringContainsText(member.Forenames, FirstNameTextBox.Text) && StringContainsText(member.Surname, SurnameTextBox.Text) && StringContainsText(KarateHelper.GetAge(member.DateOfBirth).ToString(), AgeTextBox.Text) && StringContainsText(classItem.Name, ClassComboBox.Text)))
				{
					ListViewItem lvi = new ListViewItem();
					lvi.Text = member.Forenames;
					lvi.SubItems.Add(member.Surname);
					lvi.SubItems.Add(member.StartDate.ToShortDateString());
					lvi.SubItems.Add(KarateHelper.GetAge(member.DateOfBirth).ToString());
					lvi.SubItems.Add(classItem.Name);
					lvi.Tag = member;
					if (member.LicenceExpiryDate != null)
					{
						lvi = KarateHelper.SetLviBackGroundColour(lvi, member.LicenceExpiryDate);
					}

					ActiveMembersListView.Items.Add(lvi);
				}
			}
		}

		
		private void DocumentButton_Click(object sender, EventArgs e)
		{
			if (ActiveMembersListView.SelectedItems.Count == 0)
			{
				MessageBox.Show("No member selected", "Karate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Member selectedMember = ActiveMembersListView.SelectedItems[0].Tag as Member;
			using (DocumentListForm documentListForm = new DocumentListForm())
			{
				documentListForm.SetData(selectedMember);
				documentListForm.ShowDialog();
			}
		}

		private void DeActivateButton_Click(object sender, EventArgs e)
		{
			if (ActiveMembersListView.SelectedItems.Count == 0)
			{
				MessageBox.Show("No member selected", "Karate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Member selectedMember = ActiveMembersListView.SelectedItems[0].Tag as Member;

			MemberData.InactiveMember(selectedMember);

			RefreshData();
		}

		private void SummaryButton_Click(object sender, EventArgs e)
		{
			if (ActiveMembersListView.SelectedItems.Count == 0)
			{
				MessageBox.Show("No member selected", "Karate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Member selectedMember = ActiveMembersListView.SelectedItems[0].Tag as Member;

			using (SummaryForm SummaryForm = new SummaryForm())
			{
				SummaryForm.SetData(selectedMember);
				SummaryForm.ShowDialog();
			}

		}

		private void ApplyFilterButton_Click(object sender, EventArgs e)
		{
			IsFilterApplied = true;
			RefreshData();
		}

		private bool StringContainsText(string value, string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return true;
			}

			return value.Contains(text);
		}

		private void ClearFilterButton_Click(object sender, EventArgs e)
		{
			IsFilterApplied = false;
			FirstNameTextBox.Text = string.Empty;
			SurnameTextBox.Text = string.Empty;
			AgeTextBox.Text = string.Empty;
			RefreshData();
		}

		private void ActiveMembersListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			this.ActiveMembersListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
		}
	}
}
