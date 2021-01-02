using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Karate.Helper;
using Karate.Common.Model;
using Karate.SqLite.Services;

namespace Karate.Forms
{
	public partial class SummaryForm : Form
	{
		Member  _member;
		public SummaryForm()
		{
			InitializeComponent();
		}

		public void SetData(Member member)
		{

			ClassTextBox.ForeColor = System.Drawing.Color.Black;

			_member = member;
//			ClassTextBox.Text = member.ClassItems.ClassName;
			NameTextBox.Text = member.GetFullName;
			//AddressTextBox.Text = member.Address;
			StartDateTextBox.Text = KarateHelper.SetDateViewFormat(member.StartDate);
			BirthDateTextBox.Text = KarateHelper.SetDateViewFormat(member.DateOfBirth);
/*			LandlineTextBox.Text = member.LandLine;
			MobileNumberTextBox.Text = member.MobileNumber;
			//EmailAdressTextBox.Text = member.EmailAdress;
			NotesTextBox.Text = member.Note;
			if (member.LicenceInformation != null)
			{
				LicenceExpiryDateTextBox.Text = KarateHelper.SetDateViewFormat(member.LicenceInformation.ExpiryDate);
			}
			*/
			List<MemberBadge> badgeList = BadgeData.GetBadgesByMemberId(member);
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

			Dictionary<Int32, string> styles = StyleData.GetStyles().ToDictionary(x => x.StyleId, x => x.Name);
			List<GradingItem> gradingList = GradeData.GetGradesByMemberId(member).OrderBy(x => x.StyleId).ToList();
			MemberGradeListView.Items.Clear();

			foreach (KeyValuePair<Int32, string> kvp in styles)
			{
				foreach (GradingItem item in gradingList.Where(x=> x.StyleId == kvp.Key))
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


			string documentsDirectory = Properties.Settings.Default.DataRoot + "\\Active\\" + _member.MemberId.ToString();

			if (Directory.Exists(documentsDirectory))
			{
				string[] files = Directory.GetFiles(documentsDirectory);
				FilesListView.Items.Clear();

				foreach (string filename in files)
				{
					FileAttributes fileAttributes = File.GetAttributes(filename);
					ListViewItem lvi = new ListViewItem(Path.GetFileName(filename));
					lvi.SubItems.Add(File.GetCreationTime(filename).ToShortDateString());
					FileInfo fileInfo = new FileInfo(filename);
					string sizeInKb = string.Format("{0} kb", fileInfo.Length / 1024);
					lvi.SubItems.Add(sizeInKb);
					lvi.Tag = filename;
					FilesListView.Items.Add(lvi);
				}
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}


		private void MemberForm_Load(object sender, EventArgs e)
		{
		}

		private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (ShowPasswordCheckBox.Checked)
			{
				PasswordTextBox.PasswordChar = '\0';
			}
			else
			{
				PasswordTextBox.PasswordChar = '*';
			}
		}

		private void MemberGradeListView_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void PrintButton_Click(object sender, EventArgs e)
		{
			using (PrintMemberSummary summaryForm = new PrintMemberSummary())
			{
				summaryForm.LoadData(_member);
				summaryForm.ShowDialog();
			}
		}

		private void MemberGradeListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			this.MemberGradeListView.ListViewItemSorter = new ListViewItemComparer(e.Column);

		}

		private void MemberBadgeListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			this.MemberBadgeListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
		}

		private void FilesListView_DoubleClick(object sender, EventArgs e)
		{
			if (FilesListView.SelectedItems.Count == 0)
			{
				MessageBox.Show("No file selected", "Karate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			string fileName = FilesListView.SelectedItems[0].Tag as string;
			Process myProcess = new Process();
			myProcess.StartInfo.FileName = fileName;
			myProcess.Start();
		}
	}
}
