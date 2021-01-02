using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Karate.Common.Model;
using Karate.SqLite.Services;

namespace Karate.Forms
{
	public partial class PrintMemberSummary : Form
	{
		const int standardPadding = 20;
		const int ZeroPadding = 0;
		public PrintMemberSummary()
		{
			InitializeComponent();
		}

		public void LoadData(Member member)
		{
			PrintHeader("Iruka Karate Club", 60, true);
			PrintHeader("Summary Form", 60,true);
			NewLine();
			NewLine();
			PrintHeader("Name : ", ZeroPadding, false);
		/*	richTextBox.AppendText(member.GetFullName.PadRight(30));
			PrintHeader("Start Date : ", ZeroPadding, false);
			PrintLine(member.StartDate.ToShortDateString(), standardPadding, false);
			PrintHeader("Licence Expiry Date : ", ZeroPadding, false);
			PrintLine(member.LicenceInformation == null ? "n/a" : member.LicenceInformation.ExpiryDate.ToShortDateString(), standardPadding, true);
			NewLine();
			PrintHeader("Classs : ", ZeroPadding, false);
			PrintLine(member.ClassItems.ClassName, standardPadding, true);
			NewLine();
			PrintHeader("Address", standardPadding, true);
			//PrintLine(member.Address, 60, true);
			PrintHeader("Notes", standardPadding, true);
			PrintLine(member.Note, 60, true);
			NewLine();
			PrintHeader("Land Line : ", ZeroPadding, false);
			PrintLine(member.LandLine, standardPadding, true);
			PrintHeader("Mobile Number : ", ZeroPadding, false);
			PrintLine(member.MobileNumber, ZeroPadding, false);
			PrintHeader("Email Address : ", ZeroPadding, false);
			//PrintLine(member.EmailAdress, 60, true);
			NewLine();
			PrintHeader("Gradings", standardPadding, true);
			NewLine();
			PrintLine("Date Achieved", standardPadding, false);
			PrintLine("Grade", standardPadding, false);
			PrintLine("Belt", 60, false);
			PrintLine("Current", standardPadding, false);
			NewLine();*/
			richTextBox.AppendText(string.Empty.PadRight(standardPadding, '-'));
			richTextBox.AppendText(string.Empty.PadRight(standardPadding, '-'));
			richTextBox.AppendText(string.Empty.PadRight(60, '-'));
			richTextBox.AppendText(string.Empty.PadRight(45, '-'));
			NewLine();

			List<GradingItem> gradings = GradeData.GetGradesByMemberId(member);

			foreach (GradingItem grading in gradings)
			{
				PrintLine(grading.DateAchieved.ToShortDateString(), standardPadding, false);
				PrintLine(grading.Grade, standardPadding, false);
				PrintLine(grading.BeltDescription, 60, false);
				if (gradings.First().GradingId == grading.GradingId)
				{
					PrintLine("Yes", 20, false);
				}
				NewLine();
			}

			NewLine();
			PrintHeader("Badges", standardPadding, true);
			NewLine();
			NewLine();
			PrintLine("Bradge", 60, false);
			PrintLine("Badge Description", 100, true);
			richTextBox.AppendText(string.Empty.PadRight(60, '-'));
			richTextBox.AppendText(string.Empty.PadRight(100, '-'));
			NewLine();

			List<MemberBadge> badges = BadgeData.GetBadgesByMemberId(member);

			foreach (MemberBadge badge in badges)
			{
				PrintLine(badge.BadgeType, 60, false);
				PrintLine(badge.BadgeDescription, 100, true);
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

		private void PrintHeader(string header, int length, bool newLine)
		{
			richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
			richTextBox.AppendText(header.PadRight(length));
			richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular);
			if (newLine)
			{
				NewLine();
			}
		}
		private void PrintLine(string data, int length, bool newLine)
		{
			richTextBox.AppendText(data.PadRight(length));
			if (newLine)
			{
				NewLine();
			}

		}
		private void NewLine()
		{
			richTextBox.AppendText(Environment.NewLine);
		}
	}
}
