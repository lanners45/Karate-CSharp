using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karate.Common.Model;

namespace Karate.Forms.Maintenance
{
	public partial class GradeForm : Form
	{
		GradeItem _gradeItem;
		public GradeForm()
		{
			InitializeComponent();
		}

		public void InitaliseData(GradeItem item)
		{
			_gradeItem = item;
		}

		public GradeItem GetData()
		{
			_gradeItem.Grade = GradeTextBox.Text;
			_gradeItem.BeltDescription = BeltDescriptionTextbox.Text;

			return _gradeItem;
		}
	}
}
