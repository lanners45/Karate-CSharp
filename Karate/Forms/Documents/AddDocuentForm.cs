using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karate.Forms.Documents
{
	public partial class AddDocuentForm : Form
	{
		public AddDocuentForm()
		{
			InitializeComponent();
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); 
				openFileDialog.Filter = "Text Files(*.DOC; *.PDF; *.DOCX)| *.doc; *.pdf; *.docx| All files(*.*) | *.*";
				openFileDialog.InitialDirectory = @"C:\";
				DialogResult result = openFileDialog.ShowDialog();
				if (result == DialogResult.OK) // Test result.
				{
					FilenameTextBox.Text = openFileDialog.FileName;
				}
			}
		}

		public Dictionary<string,bool> GetData()
		{
			Dictionary<string, bool> data = new Dictionary<string, bool>();
			data.Add(FilenameTextBox.Text, NewStarterFormCheckBox.Checked);
			return data;
		}
		private void SaveButton_Click(object sender, EventArgs e)
		{

		}
	}
}
