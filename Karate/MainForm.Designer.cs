namespace Karate
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.activeMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.licenceExpiryListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inactiveMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maintenanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.classesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.stylesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.badgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ExpiredMembersTextBox = new System.Windows.Forms.TextBox();
			this.InactiveMembersTextBox = new System.Windows.Forms.TextBox();
			this.ActiveMembersTextBox = new System.Windows.Forms.TextBox();
			this.AllMembersTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(577, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.maintenanceToolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.fileToolStripMenuItem.Text = "Options";
			// 
			// membersToolStripMenuItem
			// 
			this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeMembersToolStripMenuItem,
            this.licenceExpiryListToolStripMenuItem,
            this.inactiveMembersToolStripMenuItem});
			this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
			this.membersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.membersToolStripMenuItem.Text = "Members";
			// 
			// activeMembersToolStripMenuItem
			// 
			this.activeMembersToolStripMenuItem.Name = "activeMembersToolStripMenuItem";
			this.activeMembersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.activeMembersToolStripMenuItem.Text = "Active Members";
			this.activeMembersToolStripMenuItem.Click += new System.EventHandler(this.activeMembersToolStripMenuItem_Click);
			// 
			// licenceExpiryListToolStripMenuItem
			// 
			this.licenceExpiryListToolStripMenuItem.Name = "licenceExpiryListToolStripMenuItem";
			this.licenceExpiryListToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.licenceExpiryListToolStripMenuItem.Text = "Licence Expiry List";
			this.licenceExpiryListToolStripMenuItem.Click += new System.EventHandler(this.licenceExpiryListToolStripMenuItem_Click);
			// 
			// inactiveMembersToolStripMenuItem
			// 
			this.inactiveMembersToolStripMenuItem.Name = "inactiveMembersToolStripMenuItem";
			this.inactiveMembersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.inactiveMembersToolStripMenuItem.Text = "Inactive Members";
			this.inactiveMembersToolStripMenuItem.Click += new System.EventHandler(this.inactiveMembersToolStripMenuItem_Click);
			// 
			// maintenanceToolStripMenuItem1
			// 
			this.maintenanceToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classesToolStripMenuItem1,
            this.stylesToolStripMenuItem1,
            this.badgesToolStripMenuItem});
			this.maintenanceToolStripMenuItem1.Name = "maintenanceToolStripMenuItem1";
			this.maintenanceToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.maintenanceToolStripMenuItem1.Text = "Maintenance";
			// 
			// classesToolStripMenuItem1
			// 
			this.classesToolStripMenuItem1.Name = "classesToolStripMenuItem1";
			this.classesToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
			this.classesToolStripMenuItem1.Text = "Classes";
			this.classesToolStripMenuItem1.Click += new System.EventHandler(this.classesToolStripMenuItem1_Click);
			// 
			// stylesToolStripMenuItem1
			// 
			this.stylesToolStripMenuItem1.Name = "stylesToolStripMenuItem1";
			this.stylesToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
			this.stylesToolStripMenuItem1.Text = "Styles and Grades";
			this.stylesToolStripMenuItem1.Click += new System.EventHandler(this.stylesToolStripMenuItem1_Click);
			// 
			// badgesToolStripMenuItem
			// 
			this.badgesToolStripMenuItem.Name = "badgesToolStripMenuItem";
			this.badgesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.badgesToolStripMenuItem.Text = "Badges";
			this.badgesToolStripMenuItem.Click += new System.EventHandler(this.badgesToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ExpiredMembersTextBox);
			this.groupBox1.Controls.Add(this.InactiveMembersTextBox);
			this.groupBox1.Controls.Add(this.ActiveMembersTextBox);
			this.groupBox1.Controls.Add(this.AllMembersTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(189, 182);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Summary";
			// 
			// ExpiredMembersTextBox
			// 
			this.ExpiredMembersTextBox.Location = new System.Drawing.Point(100, 130);
			this.ExpiredMembersTextBox.Name = "ExpiredMembersTextBox";
			this.ExpiredMembersTextBox.Size = new System.Drawing.Size(58, 20);
			this.ExpiredMembersTextBox.TabIndex = 7;
			// 
			// InactiveMembersTextBox
			// 
			this.InactiveMembersTextBox.Location = new System.Drawing.Point(100, 97);
			this.InactiveMembersTextBox.Name = "InactiveMembersTextBox";
			this.InactiveMembersTextBox.Size = new System.Drawing.Size(58, 20);
			this.InactiveMembersTextBox.TabIndex = 6;
			// 
			// ActiveMembersTextBox
			// 
			this.ActiveMembersTextBox.Location = new System.Drawing.Point(100, 64);
			this.ActiveMembersTextBox.Name = "ActiveMembersTextBox";
			this.ActiveMembersTextBox.Size = new System.Drawing.Size(58, 20);
			this.ActiveMembersTextBox.TabIndex = 5;
			// 
			// AllMembersTextBox
			// 
			this.AllMembersTextBox.Location = new System.Drawing.Point(100, 31);
			this.AllMembersTextBox.Name = "AllMembersTextBox";
			this.AllMembersTextBox.Size = new System.Drawing.Size(58, 20);
			this.AllMembersTextBox.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Expired";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Inactive";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Active";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Members";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Karate.Properties.Resources.IrukaBadge;
			this.pictureBox1.Location = new System.Drawing.Point(241, 38);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(311, 305);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(577, 349);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Iruka Karate Club";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Enter += new System.EventHandler(this.MainForm_Enter);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox ExpiredMembersTextBox;
		private System.Windows.Forms.TextBox InactiveMembersTextBox;
		private System.Windows.Forms.TextBox ActiveMembersTextBox;
		private System.Windows.Forms.TextBox AllMembersTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem activeMembersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem stylesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem badgesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem licenceExpiryListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inactiveMembersToolStripMenuItem;
	}
}

