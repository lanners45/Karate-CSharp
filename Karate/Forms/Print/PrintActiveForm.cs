using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karate.Common.Model;
using Karate.Helper;

namespace Karate.Forms
{
	public partial class PrintForm : Form
	{
		public PrintForm()
		{
			InitializeComponent();
			this.printDocument1.BeginPrint += new PrintEventHandler(this.printDocument1_BeginPrint);
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			this.PrintButton.Click += new System.EventHandler(this.btnPrint_Click);
		}

		public void LoadData(List<Member> members)
		{
			richTextBoxPrintCtrl1.SelectionFont = new Font(richTextBoxPrintCtrl1.Font, FontStyle.Bold);
			richTextBoxPrintCtrl1.AppendText("Iruka Karate Club" + Environment.NewLine);
			richTextBoxPrintCtrl1.SelectionFont = new Font(richTextBoxPrintCtrl1.Font, FontStyle.Bold);
			richTextBoxPrintCtrl1.AppendText("Licence Inforamtion" + Environment.NewLine);
			richTextBoxPrintCtrl1.AppendText(Environment.NewLine);
			richTextBoxPrintCtrl1.AppendText(Environment.NewLine);
			richTextBoxPrintCtrl1.SelectionFont = new Font(richTextBoxPrintCtrl1.Font, FontStyle.Regular);
			richTextBoxPrintCtrl1.AppendText("Forename".PadRight(30) +     "Lastname".PadRight(30) +      "Expiry Date".PadRight(20) + "Age".PadRight(10) + "Class".PadRight(20) + Environment.NewLine);
			richTextBoxPrintCtrl1.AppendText(string.Empty.PadRight(30,'-') +     string.Empty.PadRight(30,'-') + string.Empty.PadRight(20, '-') + string.Empty.PadRight(10, '-')  +string.Empty.PadRight(35, '-') + Environment.NewLine);
			richTextBoxPrintCtrl1.SelectionFont = new Font(richTextBoxPrintCtrl1.Font, FontStyle.Regular);

			foreach (Member member in members)
			{
				string expiryDate = member.Licence != null && member.Licence .ExpiryDate.HasValue? member.Licence.ExpiryDate.Value.ToShortDateString() : "No Licence";
				richTextBoxPrintCtrl1.AppendText(member.Forenames.PadRight(30) + "    " + member.Surname.PadRight(30) + "  " + expiryDate.PadRight(20) + KarateHelper.GetAge(member.DateOfBirth).ToString().PadRight(10) + member.ClassItem.Name.PadRight(20) + Environment.NewLine);
			}
		}

		private int checkPrint;
		private void btnPageSetup_Click(object sender, System.EventArgs e)
		{
			pageSetupDialog1.ShowDialog();
		}

		private void btnPrintPreview_Click(object sender, System.EventArgs e)
		{
			printPreviewDialog1.ShowDialog();
		}

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			if (printDialog1.ShowDialog() == DialogResult.OK)
				printDocument1.Print();
		}

		private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{
			checkPrint = 0;
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			// Print the content of RichTextBox. Store the last character printed.
			checkPrint = richTextBoxPrintCtrl1.Print(checkPrint, richTextBoxPrintCtrl1.TextLength, e);

			// Check for more pages
			if (checkPrint < richTextBoxPrintCtrl1.TextLength)
				e.HasMorePages = true;
			else
				e.HasMorePages = false;
		}
	}
}

