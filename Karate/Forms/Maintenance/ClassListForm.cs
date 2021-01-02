using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Karate.Common.Model;

namespace Karate.Forms.Maintenance
{
	public partial class ClassListForm : Form
	{
		public ClassListForm()
		{
			InitializeComponent();
		}

		private void ClassesList_Load(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (ClassesListView.SelectedItems.Count == 1 && MessageBox.Show("Are you sure you want to delete this?","Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				ClassItem classItem = ClassesListView.SelectedItems[0].Tag as ClassItem;
				SqLite.Services.ClassData.DeleteClass(classItem);
				RefreshData();
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			MaintenaceItemForm classItemForm = new MaintenaceItemForm();
			classItemForm.Text = "New Class Item";
			if (classItemForm.ShowDialog() == DialogResult.OK)
			{
				ClassItem classItem = new ClassItem() { Name = classItemForm.ItemName };
				SqLite.Services.ClassData.InsertClass(classItem);
				RefreshData();
			}
		}

		private void RefreshData()
		{
			List<ClassItem> classesList = SqLite.Services.ClassData.GetClassItems();
			ClassesListView.Items.Clear();
			foreach (ClassItem classInformation in classesList)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = classInformation.Name;
				lvi.Tag = classInformation;
				ClassesListView.Items.Add(lvi);
			}
			ClassesListView.Refresh();
		}
	}
}
