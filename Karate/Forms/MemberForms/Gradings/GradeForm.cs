using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Karate.Common.Model;
using Karate.SqLite.Services;

namespace Karate.Forms.MemberForms.Gradings
{
	public partial class GradeForm : Form
	{
		public GradeForm()
		{
			InitializeComponent();
			LoadData();
		}

		public GradingItem GetData()
		{
			GradeItem gradeItem = GradesListView.SelectedItems[0].Tag as GradeItem;
			GradingItem gradingItem = new GradingItem();
			gradingItem.GradeId = gradeItem.GradeId;
			gradingItem.StyleId = gradeItem.StyleId;
			gradingItem.DateAchieved = DateAchievedDatePicker.Value;
			return gradingItem;
		}

		private void LoadData()
		{
			List<StyleItem> stylesList = StyleData.GetStyles();
			foreach (StyleItem styleItem in stylesList)
			{
				ListViewItem lvi = new ListViewItem(styleItem.Name);
				lvi.Tag = styleItem;
				StyleListView.Items.Add(lvi);
			}
			StyleListView.Refresh();
		}
		private void EnableSaveButton()
		{ 
		
			if (StyleListView.SelectedItems.Count == 1 && GradesListView.SelectedItems.Count == 1)
			{
				SaveButton.Enabled = true;
			}	
			else
			{
				SaveButton.Enabled = false;
			}
		}

		private void GradesListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			EnableSaveButton();
		}

		private void StyleListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			StyleItem styleItem = StyleListView.SelectedItems[0].Tag as StyleItem;
			List<GradeItem> gradesList = GradeData.GetGradesByStyle(styleItem);
			foreach (GradeItem gradeItem in gradesList)
			{
				ListViewItem lvi = new ListViewItem(gradeItem.Grade);
				lvi.SubItems.Add(gradeItem.BeltDescription);
				lvi.Tag = gradeItem;
				GradesListView.Items.Add(lvi);
			}
			GradesListView.Refresh();
		}
	}
}
