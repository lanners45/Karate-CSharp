using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Karate.Helper;
using Karate.Common.Model;
using Karate.SqLite.Services;

namespace Karate.Forms
{
	public partial class LicienceExpiryForm : Form
	{
		public LicienceExpiryForm()
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
				printForm.LoadData(MemberData.GetAllMembers());
				printForm.ShowDialog();

				using (StreamWriter sw = new StreamWriter(@"c:\temp\text.txt"))
				{
					sw.WriteLine("Forename     Lastname     Status");
					sw.WriteLine("--------------------------------------");

					foreach (ListViewItem lvi in ActiveMembersListView.Items)
					{
						Member member = lvi.Tag as Member;
						sw.WriteLine(member.Forenames + "    " + member.Surname + "   " + member.StatusId);
					}
				}
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
				RefreshData();
			}

		}

		private void RefreshData()
		{
			List<Member> membersList = Karate.SqLite.Services.MemberData.GetAllMembers();//.OrderBy(x => x.LicenceInformation == null ? DateTime.Parse("01/01/2000") : x.LicenceInformation.ExpiryDate).ToList();
			ActiveMembersListView.Items.Clear();
			foreach (Member member in membersList)
			{
				Address address = SqLite.Services.AddressData.GetAddressById(new Address() { AddressId = member.AddressId });
				ClassItem classItem = SqLite.Services.ClassData.GetClassItems().Single(item => item.ClassId == member.ClassId);
				Licence licence = SqLite.Services.MemberData.GetLicenceById(member);
				ListViewItem lvi = new ListViewItem();
				lvi.Text = member.Forenames;
				lvi.SubItems.Add(member.Surname);
				lvi.SubItems.Add(classItem.Name);
				lvi.SubItems.Add(KarateHelper.GetAge(member.DateOfBirth).ToString());
				lvi.SubItems.Add(licence == null || !licence.ExpiryDate.HasValue ? "No Licence" : licence.ExpiryDate.Value.ToShortDateString());
				if (licence != null && licence.ExpiryDate != null)
				{
					lvi = KarateHelper.SetLviBackGroundColour(lvi, licence.ExpiryDate.Value);
				}
				lvi.Tag = member;
				ActiveMembersListView.Items.Add(lvi);
			}
		}

		private void ActiveMembersListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			this.ActiveMembersListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
		}
	}
}
