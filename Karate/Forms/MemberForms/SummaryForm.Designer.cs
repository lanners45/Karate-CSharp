namespace Karate.Forms
{
	partial class SummaryForm
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
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label12;
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.BirthDateTextBox = new System.Windows.Forms.TextBox();
			this.StartDateTextBox = new System.Windows.Forms.TextBox();
			this.ClassTextBox = new System.Windows.Forms.TextBox();
			this.NotesTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.EmailAdressTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.MobileNumberTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.LandlineTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.AddressTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.LicenceExpiryDateTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.GradingsTabPage = new System.Windows.Forms.TabPage();
			this.MemberGradeListView = new System.Windows.Forms.ListView();
			this.DateAcheivedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GradeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BeltDescriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CurrentBeltColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BadgesTabPage = new System.Windows.Forms.TabPage();
			this.MemberBadgeListView = new System.Windows.Forms.ListView();
			this.DateAchievedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BadgeTypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BadgeDescriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BadgesListView = new System.Windows.Forms.ListView();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.FilesListView = new System.Windows.Forms.ListView();
			this.FileNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DateCreatedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SizeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PrintButton = new System.Windows.Forms.Button();
			label2 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.GradingsTabPage.SuspendLayout();
			this.BadgesTabPage.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(34, 52);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(35, 13);
			label2.TabIndex = 1;
			label2.Text = "Name";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(250, 164);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(32, 13);
			label12.TabIndex = 20;
			label12.Text = "Class";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.NameTextBox);
			this.groupBox1.Controls.Add(this.BirthDateTextBox);
			this.groupBox1.Controls.Add(this.StartDateTextBox);
			this.groupBox1.Controls.Add(this.ClassTextBox);
			this.groupBox1.Controls.Add(label12);
			this.groupBox1.Controls.Add(this.NotesTextBox);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.EmailAdressTextBox);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.MobileNumberTextBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.LandlineTextBox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.AddressTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(label2);
			this.groupBox1.Location = new System.Drawing.Point(22, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(492, 283);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Member Details";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(97, 49);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.ReadOnly = true;
			this.NameTextBox.Size = new System.Drawing.Size(145, 20);
			this.NameTextBox.TabIndex = 27;
			this.NameTextBox.TabStop = false;
			// 
			// BirthDateTextBox
			// 
			this.BirthDateTextBox.Location = new System.Drawing.Point(97, 237);
			this.BirthDateTextBox.Name = "BirthDateTextBox";
			this.BirthDateTextBox.ReadOnly = true;
			this.BirthDateTextBox.Size = new System.Drawing.Size(100, 20);
			this.BirthDateTextBox.TabIndex = 26;
			this.BirthDateTextBox.TabStop = false;
			// 
			// StartDateTextBox
			// 
			this.StartDateTextBox.Location = new System.Drawing.Point(313, 46);
			this.StartDateTextBox.Name = "StartDateTextBox";
			this.StartDateTextBox.ReadOnly = true;
			this.StartDateTextBox.Size = new System.Drawing.Size(100, 20);
			this.StartDateTextBox.TabIndex = 25;
			this.StartDateTextBox.TabStop = false;
			// 
			// ClassTextBox
			// 
			this.ClassTextBox.Location = new System.Drawing.Point(313, 159);
			this.ClassTextBox.Name = "ClassTextBox";
			this.ClassTextBox.ReadOnly = true;
			this.ClassTextBox.Size = new System.Drawing.Size(145, 20);
			this.ClassTextBox.TabIndex = 21;
			this.ClassTextBox.TabStop = false;
			// 
			// NotesTextBox
			// 
			this.NotesTextBox.Location = new System.Drawing.Point(313, 73);
			this.NotesTextBox.Multiline = true;
			this.NotesTextBox.Name = "NotesTextBox";
			this.NotesTextBox.ReadOnly = true;
			this.NotesTextBox.Size = new System.Drawing.Size(145, 77);
			this.NotesTextBox.TabIndex = 19;
			this.NotesTextBox.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(272, 76);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Notes";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(34, 240);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Birth Date";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(252, 49);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Start Date";
			// 
			// EmailAdressTextBox
			// 
			this.EmailAdressTextBox.Location = new System.Drawing.Point(97, 208);
			this.EmailAdressTextBox.Name = "EmailAdressTextBox";
			this.EmailAdressTextBox.ReadOnly = true;
			this.EmailAdressTextBox.Size = new System.Drawing.Size(145, 20);
			this.EmailAdressTextBox.TabIndex = 13;
			this.EmailAdressTextBox.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(18, 211);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Email Address";
			// 
			// MobileNumberTextBox
			// 
			this.MobileNumberTextBox.Location = new System.Drawing.Point(97, 182);
			this.MobileNumberTextBox.Name = "MobileNumberTextBox";
			this.MobileNumberTextBox.ReadOnly = true;
			this.MobileNumberTextBox.Size = new System.Drawing.Size(145, 20);
			this.MobileNumberTextBox.TabIndex = 11;
			this.MobileNumberTextBox.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 185);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Mobile Number";
			// 
			// LandlineTextBox
			// 
			this.LandlineTextBox.Location = new System.Drawing.Point(97, 156);
			this.LandlineTextBox.Name = "LandlineTextBox";
			this.LandlineTextBox.ReadOnly = true;
			this.LandlineTextBox.Size = new System.Drawing.Size(145, 20);
			this.LandlineTextBox.TabIndex = 9;
			this.LandlineTextBox.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Landline Number";
			// 
			// AddressTextBox
			// 
			this.AddressTextBox.Location = new System.Drawing.Point(97, 73);
			this.AddressTextBox.Multiline = true;
			this.AddressTextBox.Name = "AddressTextBox";
			this.AddressTextBox.ReadOnly = true;
			this.AddressTextBox.Size = new System.Drawing.Size(145, 77);
			this.AddressTextBox.TabIndex = 7;
			this.AddressTextBox.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(46, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Address";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.LicenceExpiryDateTextBox);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Location = new System.Drawing.Point(520, 17);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(210, 62);
			this.groupBox2.TabIndex = 23;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Licence";
			// 
			// LicenceExpiryDateTextBox
			// 
			this.LicenceExpiryDateTextBox.Location = new System.Drawing.Point(70, 22);
			this.LicenceExpiryDateTextBox.Name = "LicenceExpiryDateTextBox";
			this.LicenceExpiryDateTextBox.ReadOnly = true;
			this.LicenceExpiryDateTextBox.Size = new System.Drawing.Size(100, 20);
			this.LicenceExpiryDateTextBox.TabIndex = 24;
			this.LicenceExpiryDateTextBox.TabStop = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 25);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(61, 13);
			this.label11.TabIndex = 23;
			this.label11.Text = "Expiry Date";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.ShowPasswordCheckBox);
			this.groupBox3.Controls.Add(this.PasswordTextBox);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.UsernameTextBox);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Location = new System.Drawing.Point(526, 88);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(204, 100);
			this.groupBox3.TabIndex = 24;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Web Credentials";
			// 
			// ShowPasswordCheckBox
			// 
			this.ShowPasswordCheckBox.AutoSize = true;
			this.ShowPasswordCheckBox.Location = new System.Drawing.Point(6, 79);
			this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
			this.ShowPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
			this.ShowPasswordCheckBox.TabIndex = 18;
			this.ShowPasswordCheckBox.Text = "Show Password";
			this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
			this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(82, 53);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.ReadOnly = true;
			this.PasswordTextBox.Size = new System.Drawing.Size(107, 20);
			this.PasswordTextBox.TabIndex = 17;
			this.PasswordTextBox.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Password";
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Location = new System.Drawing.Point(82, 27);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.ReadOnly = true;
			this.UsernameTextBox.Size = new System.Drawing.Size(107, 20);
			this.UsernameTextBox.TabIndex = 15;
			this.UsernameTextBox.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(-2, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Username";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.GradingsTabPage);
			this.tabControl1.Controls.Add(this.BadgesTabPage);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(29, 302);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(555, 266);
			this.tabControl1.TabIndex = 25;
			// 
			// GradingsTabPage
			// 
			this.GradingsTabPage.Controls.Add(this.MemberGradeListView);
			this.GradingsTabPage.Location = new System.Drawing.Point(4, 22);
			this.GradingsTabPage.Name = "GradingsTabPage";
			this.GradingsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.GradingsTabPage.Size = new System.Drawing.Size(547, 240);
			this.GradingsTabPage.TabIndex = 0;
			this.GradingsTabPage.Text = "Gradings";
			this.GradingsTabPage.UseVisualStyleBackColor = true;
			// 
			// MemberGradeListView
			// 
			this.MemberGradeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateAcheivedColumnHeader,
            this.GradeColumnHeader,
            this.BeltDescriptionColumnHeader,
            this.CurrentBeltColumnHeader});
			this.MemberGradeListView.FullRowSelect = true;
			this.MemberGradeListView.GridLines = true;
			this.MemberGradeListView.Location = new System.Drawing.Point(10, 6);
			this.MemberGradeListView.Name = "MemberGradeListView";
			this.MemberGradeListView.Size = new System.Drawing.Size(523, 228);
			this.MemberGradeListView.TabIndex = 3;
			this.MemberGradeListView.UseCompatibleStateImageBehavior = false;
			this.MemberGradeListView.View = System.Windows.Forms.View.Details;
			this.MemberGradeListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.MemberGradeListView_ColumnClick);
			this.MemberGradeListView.SelectedIndexChanged += new System.EventHandler(this.MemberGradeListView_SelectedIndexChanged);
			// 
			// DateAcheivedColumnHeader
			// 
			this.DateAcheivedColumnHeader.Text = "Date Acheived";
			this.DateAcheivedColumnHeader.Width = 100;
			// 
			// GradeColumnHeader
			// 
			this.GradeColumnHeader.Text = "Grade";
			this.GradeColumnHeader.Width = 120;
			// 
			// BeltDescriptionColumnHeader
			// 
			this.BeltDescriptionColumnHeader.Text = "Belt ";
			this.BeltDescriptionColumnHeader.Width = 200;
			// 
			// CurrentBeltColumnHeader
			// 
			this.CurrentBeltColumnHeader.Text = "Current belt";
			this.CurrentBeltColumnHeader.Width = 92;
			// 
			// BadgesTabPage
			// 
			this.BadgesTabPage.Controls.Add(this.MemberBadgeListView);
			this.BadgesTabPage.Controls.Add(this.BadgesListView);
			this.BadgesTabPage.Location = new System.Drawing.Point(4, 22);
			this.BadgesTabPage.Name = "BadgesTabPage";
			this.BadgesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.BadgesTabPage.Size = new System.Drawing.Size(547, 240);
			this.BadgesTabPage.TabIndex = 1;
			this.BadgesTabPage.Text = "Badges";
			this.BadgesTabPage.UseVisualStyleBackColor = true;
			// 
			// MemberBadgeListView
			// 
			this.MemberBadgeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateAchievedColumnHeader,
            this.BadgeTypeColumnHeader,
            this.BadgeDescriptionColumnHeader});
			this.MemberBadgeListView.FullRowSelect = true;
			this.MemberBadgeListView.GridLines = true;
			this.MemberBadgeListView.Location = new System.Drawing.Point(10, 6);
			this.MemberBadgeListView.Name = "MemberBadgeListView";
			this.MemberBadgeListView.Size = new System.Drawing.Size(531, 218);
			this.MemberBadgeListView.TabIndex = 3;
			this.MemberBadgeListView.UseCompatibleStateImageBehavior = false;
			this.MemberBadgeListView.View = System.Windows.Forms.View.Details;
			this.MemberBadgeListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.MemberBadgeListView_ColumnClick);
			// 
			// DateAchievedColumnHeader
			// 
			this.DateAchievedColumnHeader.Text = "Date Achieved";
			this.DateAchievedColumnHeader.Width = 100;
			// 
			// BadgeTypeColumnHeader
			// 
			this.BadgeTypeColumnHeader.Text = "Badge Type";
			this.BadgeTypeColumnHeader.Width = 120;
			// 
			// BadgeDescriptionColumnHeader
			// 
			this.BadgeDescriptionColumnHeader.Text = "Badge Description";
			this.BadgeDescriptionColumnHeader.Width = 200;
			// 
			// BadgesListView
			// 
			this.BadgesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BadgesListView.Location = new System.Drawing.Point(3, 3);
			this.BadgesListView.Name = "BadgesListView";
			this.BadgesListView.Size = new System.Drawing.Size(541, 234);
			this.BadgesListView.TabIndex = 0;
			this.BadgesListView.UseCompatibleStateImageBehavior = false;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.FilesListView);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(547, 240);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Documents";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// FilesListView
			// 
			this.FilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNameColumnHeader,
            this.DateCreatedColumnHeader,
            this.SizeColumnHeader});
			this.FilesListView.FullRowSelect = true;
			this.FilesListView.GridLines = true;
			this.FilesListView.Location = new System.Drawing.Point(10, 6);
			this.FilesListView.Name = "FilesListView";
			this.FilesListView.Size = new System.Drawing.Size(531, 228);
			this.FilesListView.TabIndex = 1;
			this.FilesListView.UseCompatibleStateImageBehavior = false;
			this.FilesListView.View = System.Windows.Forms.View.Details;
			this.FilesListView.DoubleClick += new System.EventHandler(this.FilesListView_DoubleClick);
			// 
			// FileNameColumnHeader
			// 
			this.FileNameColumnHeader.Text = "File name";
			this.FileNameColumnHeader.Width = 252;
			// 
			// DateCreatedColumnHeader
			// 
			this.DateCreatedColumnHeader.Text = "Date Created";
			this.DateCreatedColumnHeader.Width = 100;
			// 
			// SizeColumnHeader
			// 
			this.SizeColumnHeader.Text = "Size";
			this.SizeColumnHeader.Width = 100;
			// 
			// PrintButton
			// 
			this.PrintButton.Image = global::Karate.Properties.Resources.print_icon;
			this.PrintButton.Location = new System.Drawing.Point(683, 520);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.Size = new System.Drawing.Size(49, 44);
			this.PrintButton.TabIndex = 29;
			this.PrintButton.UseVisualStyleBackColor = true;
			this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// SummaryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 569);
			this.Controls.Add(this.PrintButton);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "SummaryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Summary ";
			this.Load += new System.EventHandler(this.MemberForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.GradingsTabPage.ResumeLayout(false);
			this.BadgesTabPage.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox NotesTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox EmailAdressTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox MobileNumberTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox LandlineTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox AddressTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage GradingsTabPage;
		private System.Windows.Forms.TabPage BadgesTabPage;
		private System.Windows.Forms.ListView BadgesListView;
		private System.Windows.Forms.ListView MemberGradeListView;
		private System.Windows.Forms.ColumnHeader DateAcheivedColumnHeader;
		private System.Windows.Forms.ColumnHeader GradeColumnHeader;
		private System.Windows.Forms.ColumnHeader BeltDescriptionColumnHeader;
		private System.Windows.Forms.ColumnHeader CurrentBeltColumnHeader;
		private System.Windows.Forms.ListView MemberBadgeListView;
		private System.Windows.Forms.ColumnHeader BadgeTypeColumnHeader;
		private System.Windows.Forms.ColumnHeader BadgeDescriptionColumnHeader;
		private System.Windows.Forms.TextBox ClassTextBox;
		private System.Windows.Forms.Button PrintButton;
		private System.Windows.Forms.TextBox BirthDateTextBox;
		private System.Windows.Forms.TextBox StartDateTextBox;
		private System.Windows.Forms.TextBox LicenceExpiryDateTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ListView FilesListView;
		private System.Windows.Forms.ColumnHeader FileNameColumnHeader;
		private System.Windows.Forms.ColumnHeader DateCreatedColumnHeader;
		private System.Windows.Forms.ColumnHeader SizeColumnHeader;
		private System.Windows.Forms.ColumnHeader DateAchievedColumnHeader;
	}
}