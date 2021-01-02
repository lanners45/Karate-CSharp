using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karate.Forms
{
	public partial class MaintenaceItemForm : Form
	{
		public string ItemName
		{
			get
			{ return NameTextBox.Text; }
		}
		public MaintenaceItemForm()
		{
			InitializeComponent();
		}

		private void MaintenaceItemForm_Load(object sender, EventArgs e)
		{
			SaveButton.Enabled = false;
		}

		private void NameTextBox_Leave(object sender, EventArgs e)
		{

		}

		private void NameTextBox_TextChanged(object sender, EventArgs e)
		{
			SaveButton.Enabled = NameTextBox.Text.Length > 0 ? true : false;
		}
	}
}
