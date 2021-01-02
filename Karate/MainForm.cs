using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Karate.Common.Enum;
using Karate.Forms;
using Karate.Forms.Maintenance;

namespace Karate
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void activeMembersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (ActiveMembersForm activeMembersForm = new ActiveMembersForm())
			{
				activeMembersForm.ShowDialog();
			}
		}

	
		private void classesToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (ClassListForm classlist = new ClassListForm())
			{
				classlist.ShowDialog();
			}
		}

		private void stylesToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (StyleAndGradeForm stylesAndGradeForm = new StyleAndGradeForm())
			{
				stylesAndGradeForm.ShowDialog();
			}
		}

		private void badgesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (BadgesListForm badgesForm = new BadgesListForm())
			{
				badgesForm.ShowDialog();
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (KarateAboutBox aboutBox = new KarateAboutBox())
			{
				aboutBox.ShowDialog();
			}
		}

		private void licenceExpiryListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (LicienceExpiryForm licenceExpiryForm = new LicienceExpiryForm())
			{
				licenceExpiryForm.ShowDialog();
			}
		}

		private void MainForm_Enter(object sender, EventArgs e)
		{
			try
			{
				Dictionary<Statistics, int> stats = SqLite.Services.StatisticsData.GetStats();
				foreach (KeyValuePair<Statistics, int> stat in stats)
				{
					switch (stat.Key)
					{
						case Statistics.AllMembers:
							AllMembersTextBox.Text = stat.Value.ToString();
							break;
						case Statistics.ActiveMembers:
							ActiveMembersTextBox.Text = stat.Value.ToString();
							break;
						case Statistics.InActiveMembers:
							InactiveMembersTextBox.Text = stat.Value.ToString();
							break;
						case Statistics.ExpiredMembers:
							ExpiredMembersTextBox.Text = stat.Value.ToString();
							break;
					}
				}
			}
			catch
			{
				MessageBox.Show("There was a problem connecting to the database.  Please run update database under utilties and restart the program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				membersToolStripMenuItem.Enabled = false;
				maintenanceToolStripMenuItem1.Enabled = false;
			}
		}

		private void inactiveMembersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (InactiveMembersForm inactiveMembersForm = new InactiveMembersForm())
			{
				inactiveMembersForm.ShowDialog();
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{

				Dictionary<Statistics, int> stats = SqLite.Services.StatisticsData.GetStats();
				foreach (KeyValuePair<Statistics, int> stat in stats)
				{
					switch (stat.Key)
					{
						case Statistics.AllMembers:
							AllMembersTextBox.Text = stat.Value.ToString();
							break;
						case Statistics.ActiveMembers:
							ActiveMembersTextBox.Text = stat.Value.ToString();
							break;
						case Statistics.InActiveMembers:
							InactiveMembersTextBox.Text = stat.Value.ToString();
							break;
						case Statistics.ExpiredMembers:
							ExpiredMembersTextBox.Text = stat.Value.ToString();
							break;
					}
				}
			}
			catch
			{
				MessageBox.Show("There was a problem connecting to the database.  Please run update database under utilties and restart the program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				membersToolStripMenuItem.Enabled = false;
				maintenanceToolStripMenuItem1.Enabled = false;
			}
		}

		private void createSqlExpressToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
