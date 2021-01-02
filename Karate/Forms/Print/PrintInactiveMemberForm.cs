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

namespace Karate.Forms
{
	public partial class PrintInactiveMemberForm : Form
	{
		public PrintInactiveMemberForm()
		{
			InitializeComponent();
		}

		public void LoadData(List<Member> members)
		{
			richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
			richTextBox.AppendText("Iruka Karate Club" + Environment.NewLine);
			richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
			richTextBox.AppendText("Inactive Members Inforamtion" + Environment.NewLine);
			richTextBox.AppendText(Environment.NewLine);
			richTextBox.AppendText(Environment.NewLine);
			richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular);
			richTextBox.AppendText("Forename".PadRight(30) +     "Lastname".PadRight(30) +      "Status".PadRight(20) + Environment.NewLine);
			richTextBox.AppendText(string.Empty.PadRight(30,'-') +     string.Empty.PadRight(30,'-') +      string.Empty.PadRight(30, '-') + Environment.NewLine);
			richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular);

			foreach (Member member in members)
			{
			/*	string expiryDate = member.LicenceInformation != null ? member.LicenceInformation.ExpiryDate.ToShortDateString() : "No Licence";
				richTextBox.AppendText(member.ForeName.PadRight(30) + "    " + member.Surname.PadRight(30) + "  " + expiryDate + Environment.NewLine);*/
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			PrintDialog printDialog = new PrintDialog();
			PrintDocument documentToPrint = new PrintDocument();
			printDialog.Document = documentToPrint;

			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				StringReader reader = new StringReader(richTextBox.Text);
				documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
				documentToPrint.Print();
			}
		}
		private void DocumentToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			StringReader reader = new StringReader(richTextBox.Text);
			float LinesPerPage = 0;
			float YPosition = 0;
			int Count = 0;
			float LeftMargin = e.MarginBounds.Left;
			float TopMargin = e.MarginBounds.Top;
			string Line = null;
			Font PrintFont = this.richTextBox.Font;
			SolidBrush PrintBrush = new SolidBrush(Color.Black);

			LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

			while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
			{
				YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
				e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
				Count++;
			}

			if (Line != null)
			{
				e.HasMorePages = true;
			}
			else
			{
				e.HasMorePages = false;
			}
			PrintBrush.Dispose();
		}
	}
}
