using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karate.Forms.Documents
{
	public partial class DocumentListForm : Form
	{
		Karate.Common.Model.Member _member;

		public DocumentListForm()
		{
			InitializeComponent();
		}

		public void SetData(Karate.Common.Model.Member member)
		{
			_member = member;
			MemberNameTextBox.Text = _member.GetFullName;
			RefreshData();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			using (AddDocuentForm addDocumentForm = new AddDocuentForm())
			{
				if (addDocumentForm.ShowDialog() == DialogResult.OK)
				{
					string documentsDirectory = Properties.Settings.Default.DataRoot + "\\Active\\" + _member.MemberId.ToString();
					CreateDirectoryIfNotExists(documentsDirectory);
					Dictionary<string, bool> data = addDocumentForm.GetData();
					string filename = GetFileName(data.First().Key, data.First().Value);
					documentsDirectory = documentsDirectory + "\\" + filename;
					File.Copy(data.First().Key, documentsDirectory);
					RefreshData();
				}
			}
		}

		private void CreateDirectoryIfNotExists(string documentsDirectory)
		{
			if (!Directory.Exists(documentsDirectory))
			{
				Directory.CreateDirectory(documentsDirectory);
			}
		}

		private void RefreshData()
		{
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

		private void OpenButton_Click(object sender, EventArgs e)
		{
			if (FilesListView.SelectedItems.Count == 0)
			{
				MessageBox.Show("No file selected", "Karate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			string fileName = FilesListView.SelectedItems[0].Tag as string;
			Process myProcess = new Process();
			myProcess.StartInfo.FileName = fileName;
			myProcess.WaitForExit();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (FilesListView.SelectedItems.Count == 1 && MessageBox.Show("Are you sure you want to delete this file?", "Karate Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				string fileName = FilesListView.SelectedItems[0].Tag as string;
				File.Delete(fileName);
				RefreshData();
			}
		}

		private string GetFileName(string fileName, bool isStartForm)
		{
			return  isStartForm ? "new_start_form" + Path.GetExtension(fileName) : Path.GetFileName(fileName);
		}
	}
}
