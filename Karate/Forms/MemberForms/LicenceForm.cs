using System;
using System.Windows.Forms;
using Karate.Common.Model;

namespace Karate.Forms
{
	public partial class LicenceForm : Form
	{
		public LicenceForm()
		{
			InitializeComponent();
		}

		public void SetData(string name, Licence licence)
		{
			NameTextBox.Text = name;
			if (licence != null && licence.ExpiryDate.HasValue)
			{
				ExpiryDatePicker.Value = licence.ExpiryDate.Value;
			}
		}

		public DateTime GetData()
		{
			return ExpiryDatePicker.Value;
		}
	}
}
