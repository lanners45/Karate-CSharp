using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Karate.Common.Model;
using Karate.SqLite.Services;

namespace Karate.Forms.Maintenance
{
	public partial class StyleAndGradeForm : Form
	{
		public StyleAndGradeForm()
		{
			InitializeComponent();
			RefreshData();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			using (MaintenaceItemForm styleItemForm = new MaintenaceItemForm())
			{
				styleItemForm.Text = "New Style Item";
				if (styleItemForm.ShowDialog() == DialogResult.OK)
				{
					StyleItem styleItem = new StyleItem();
					styleItem.Name = styleItemForm.ItemName;
					SqLite.Services.StyleData.InsertStyle(styleItem);
					RefreshData();
				}
			}
		}

		private void RefreshData()
		{
			List<StyleItem> styleList = SqLite.Services.StyleData.GetStyles();
			StyleListView.Items.Clear();
			foreach (StyleItem styleItem in styleList)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = styleItem.Name;
				lvi.Tag = styleItem;
				StyleListView.Items.Add(lvi);
			}
			StyleListView.Refresh();

			List<GradeData> gradesList = new List<GradeData>();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (StyleListView.SelectedItems.Count == 1 && GradesListView.Items.Count > 0)
			{
				MessageBox.Show("There are outstanding Grades for this Style.  Please delete the Grades", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (StyleListView.SelectedItems.Count == 1 && MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				StyleItem styleItem = StyleListView.SelectedItems[0].Tag as StyleItem;
				StyleData.DeleteStyle(styleItem);
				RefreshData();
			}
		}

		private void AddGtradeButton_Click(object sender, EventArgs e)
		{
			if (StyleListView.SelectedItems.Count != 1)
			{
				MessageBox.Show("No Style selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			StyleItem styleItem = StyleListView.SelectedItems[0].Tag as StyleItem;
			GradeForm gradeForm = new GradeForm();
			gradeForm.InitaliseData(new GradeItem(styleItem.StyleId));
			if (gradeForm.ShowDialog() == DialogResult.OK)
			{
				SqLite.Services.GradeData.InsertGrade(gradeForm.GetData());
			}
			RefreshGradeView();
		}

		private void DeleteGradeButton_Click(object sender, EventArgs e)
		{
			if (GradesListView.SelectedItems.Count != 1)
			{
				MessageBox.Show("No Grade selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			GradeItem gradeItem = (GradeItem)GradesListView.SelectedItems[0].Tag;
			SqLite.Services.GradeData.DeleteGrade(gradeItem);
			RefreshGradeView();
		}

		private void StyleListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshGradeView();
		}

		private void RefreshGradeView()
		{
			StyleItem styleItem = StyleListView.SelectedItems[0].Tag as StyleItem;
			List<GradeItem> grades = SqLite. Services.GradeData.GetGradesByStyle(styleItem);
			GradesListView.Items.Clear();
			foreach (GradeItem grade in grades)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = grade.Grade;
				lvi.SubItems.Add(grade.BeltDescription);
				lvi.Tag = grade;
				GradesListView.Items.Add(lvi);
			}

			GradesListView.Refresh();
		}
	}
}
