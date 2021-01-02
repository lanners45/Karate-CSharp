namespace Karate.Forms
{
	partial class ActiveMembersForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveMembersForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BadgesButton = new System.Windows.Forms.Button();
			this.PrintButton = new System.Windows.Forms.Button();
			this.ActiveMembersListView = new System.Windows.Forms.ListView();
			this.FirstNameHeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LastNameHeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StartDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AgeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ClassColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DeActivateButton = new System.Windows.Forms.Button();
			this.SummaryButton = new System.Windows.Forms.Button();
			this.GradingsButton = new System.Windows.Forms.Button();
			this.DocumentButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ClearFilterButton = new System.Windows.Forms.Button();
			this.ApplyFilterButton = new System.Windows.Forms.Button();
			this.ClassComboBox = new System.Windows.Forms.ComboBox();
			this.AgeTextBox = new System.Windows.Forms.TextBox();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.FirstNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BadgesButton);
			this.groupBox1.Controls.Add(this.PrintButton);
			this.groupBox1.Controls.Add(this.ActiveMembersListView);
			this.groupBox1.Controls.Add(this.DeActivateButton);
			this.groupBox1.Controls.Add(this.SummaryButton);
			this.groupBox1.Controls.Add(this.GradingsButton);
			this.groupBox1.Controls.Add(this.DocumentButton);
			this.groupBox1.Controls.Add(this.EditButton);
			this.groupBox1.Controls.Add(this.AddButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 100);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(579, 418);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Active Members";
			// 
			// BadgesButton
			// 
			this.BadgesButton.Image = global::Karate.Properties.Resources.Badges;
			this.BadgesButton.Location = new System.Drawing.Point(523, 216);
			this.BadgesButton.Name = "BadgesButton";
			this.BadgesButton.Size = new System.Drawing.Size(49, 44);
			this.BadgesButton.TabIndex = 29;
			this.toolTip1.SetToolTip(this.BadgesButton, "Badges management");
			this.BadgesButton.UseVisualStyleBackColor = true;
			this.BadgesButton.Click += new System.EventHandler(this.BadgesButton_Click);
			// 
			// PrintButton
			// 
			this.PrintButton.Image = global::Karate.Properties.Resources.print_icon;
			this.PrintButton.Location = new System.Drawing.Point(523, 360);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.Size = new System.Drawing.Size(49, 44);
			this.PrintButton.TabIndex = 28;
			this.toolTip1.SetToolTip(this.PrintButton, "Print Active members list");
			this.PrintButton.UseVisualStyleBackColor = true;
			this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// ActiveMembersListView
			// 
			this.ActiveMembersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameHeaderColumn,
            this.LastNameHeaderColumn,
            this.StartDateColumnHeader,
            this.AgeColumnHeader,
            this.ClassColumnHeader});
			this.ActiveMembersListView.FullRowSelect = true;
			this.ActiveMembersListView.GridLines = true;
			this.ActiveMembersListView.Location = new System.Drawing.Point(7, 16);
			this.ActiveMembersListView.Name = "ActiveMembersListView";
			this.ActiveMembersListView.Size = new System.Drawing.Size(510, 388);
			this.ActiveMembersListView.TabIndex = 27;
			this.toolTip1.SetToolTip(this.ActiveMembersListView, "Select member");
			this.ActiveMembersListView.UseCompatibleStateImageBehavior = false;
			this.ActiveMembersListView.View = System.Windows.Forms.View.Details;
			this.ActiveMembersListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ActiveMembersListView_ColumnClick);
			// 
			// FirstNameHeaderColumn
			// 
			this.FirstNameHeaderColumn.Text = "First name";
			this.FirstNameHeaderColumn.Width = 100;
			// 
			// LastNameHeaderColumn
			// 
			this.LastNameHeaderColumn.Text = "Last name";
			this.LastNameHeaderColumn.Width = 120;
			// 
			// StartDateColumnHeader
			// 
			this.StartDateColumnHeader.Text = "Start Date";
			this.StartDateColumnHeader.Width = 100;
			// 
			// AgeColumnHeader
			// 
			this.AgeColumnHeader.Text = "Age";
			this.AgeColumnHeader.Width = 70;
			// 
			// ClassColumnHeader
			// 
			this.ClassColumnHeader.Text = "Class";
			// 
			// DeActivateButton
			// 
			this.DeActivateButton.Image = global::Karate.Properties.Resources.delete;
			this.DeActivateButton.Location = new System.Drawing.Point(523, 310);
			this.DeActivateButton.Name = "DeActivateButton";
			this.DeActivateButton.Size = new System.Drawing.Size(49, 44);
			this.DeActivateButton.TabIndex = 26;
			this.toolTip1.SetToolTip(this.DeActivateButton, "Deactivate a member");
			this.DeActivateButton.UseVisualStyleBackColor = true;
			this.DeActivateButton.Click += new System.EventHandler(this.DeActivateButton_Click);
			// 
			// SummaryButton
			// 
			this.SummaryButton.Image = global::Karate.Properties.Resources.Summary;
			this.SummaryButton.Location = new System.Drawing.Point(523, 260);
			this.SummaryButton.Name = "SummaryButton";
			this.SummaryButton.Size = new System.Drawing.Size(49, 44);
			this.SummaryButton.TabIndex = 25;
			this.toolTip1.SetToolTip(this.SummaryButton, "Member Summary");
			this.SummaryButton.UseVisualStyleBackColor = true;
			this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
			// 
			// GradingsButton
			// 
			this.GradingsButton.Image = ((System.Drawing.Image)(resources.GetObject("GradingsButton.Image")));
			this.GradingsButton.Location = new System.Drawing.Point(523, 166);
			this.GradingsButton.Name = "GradingsButton";
			this.GradingsButton.Size = new System.Drawing.Size(49, 44);
			this.GradingsButton.TabIndex = 24;
			this.toolTip1.SetToolTip(this.GradingsButton, "Gradings management");
			this.GradingsButton.UseVisualStyleBackColor = true;
			this.GradingsButton.Click += new System.EventHandler(this.GradingsButton_Click);
			// 
			// DocumentButton
			// 
			this.DocumentButton.Image = global::Karate.Properties.Resources.Documents;
			this.DocumentButton.Location = new System.Drawing.Point(523, 116);
			this.DocumentButton.Name = "DocumentButton";
			this.DocumentButton.Size = new System.Drawing.Size(49, 44);
			this.DocumentButton.TabIndex = 22;
			this.toolTip1.SetToolTip(this.DocumentButton, "Manage Documents");
			this.DocumentButton.UseVisualStyleBackColor = true;
			this.DocumentButton.Click += new System.EventHandler(this.DocumentButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Image = global::Karate.Properties.Resources.edit;
			this.EditButton.Location = new System.Drawing.Point(523, 66);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(49, 44);
			this.EditButton.TabIndex = 20;
			this.toolTip1.SetToolTip(this.EditButton, "Edit member");
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
			this.AddButton.Location = new System.Drawing.Point(523, 16);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(49, 44);
			this.AddButton.TabIndex = 19;
			this.toolTip1.SetToolTip(this.AddButton, "Add new member");
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ClearFilterButton);
			this.groupBox2.Controls.Add(this.ApplyFilterButton);
			this.groupBox2.Controls.Add(this.ClassComboBox);
			this.groupBox2.Controls.Add(this.AgeTextBox);
			this.groupBox2.Controls.Add(this.SurnameTextBox);
			this.groupBox2.Controls.Add(this.FirstNameTextBox);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(19, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(565, 82);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filter ";
			// 
			// ClearFilterButton
			// 
			this.ClearFilterButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.ClearFilterButton.Location = new System.Drawing.Point(471, 46);
			this.ClearFilterButton.Name = "ClearFilterButton";
			this.ClearFilterButton.Size = new System.Drawing.Size(75, 23);
			this.ClearFilterButton.TabIndex = 18;
			this.ClearFilterButton.Text = "Clear";
			this.ClearFilterButton.UseVisualStyleBackColor = true;
			this.ClearFilterButton.Click += new System.EventHandler(this.ClearFilterButton_Click);
			// 
			// ApplyFilterButton
			// 
			this.ApplyFilterButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.ApplyFilterButton.Location = new System.Drawing.Point(471, 17);
			this.ApplyFilterButton.Name = "ApplyFilterButton";
			this.ApplyFilterButton.Size = new System.Drawing.Size(75, 23);
			this.ApplyFilterButton.TabIndex = 17;
			this.ApplyFilterButton.Text = "Apply";
			this.ApplyFilterButton.UseVisualStyleBackColor = true;
			this.ApplyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
			// 
			// ClassComboBox
			// 
			this.ClassComboBox.FormattingEnabled = true;
			this.ClassComboBox.Location = new System.Drawing.Point(234, 48);
			this.ClassComboBox.Name = "ClassComboBox";
			this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
			this.ClassComboBox.TabIndex = 16;
			// 
			// AgeTextBox
			// 
			this.AgeTextBox.Location = new System.Drawing.Point(234, 19);
			this.AgeTextBox.Name = "AgeTextBox";
			this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
			this.AgeTextBox.TabIndex = 15;
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Location = new System.Drawing.Point(75, 48);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
			this.SurnameTextBox.TabIndex = 14;
			// 
			// FirstNameTextBox
			// 
			this.FirstNameTextBox.Location = new System.Drawing.Point(75, 19);
			this.FirstNameTextBox.Name = "FirstNameTextBox";
			this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.FirstNameTextBox.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(190, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Class";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(190, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Age";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Last Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "First Name";
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "HtmlHelp\\KarakteHelp.chm";
			this.helpProvider1.Tag = "";
			// 
			// ActiveMembersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 526);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.helpProvider1.SetHelpString(this, "1000");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ActiveMembersForm";
			this.helpProvider1.SetShowHelp(this, true);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Active Members";
			this.Load += new System.EventHandler(this.ActiveMembersForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button ClearFilterButton;
		private System.Windows.Forms.Button ApplyFilterButton;
		private System.Windows.Forms.ComboBox ClassComboBox;
		private System.Windows.Forms.TextBox AgeTextBox;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.Windows.Forms.TextBox FirstNameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button DocumentButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button DeActivateButton;
		private System.Windows.Forms.Button SummaryButton;
		private System.Windows.Forms.Button GradingsButton;
		private System.Windows.Forms.ListView ActiveMembersListView;
		private System.Windows.Forms.ColumnHeader FirstNameHeaderColumn;
		private System.Windows.Forms.ColumnHeader LastNameHeaderColumn;
		private System.Windows.Forms.ColumnHeader StartDateColumnHeader;
		private System.Windows.Forms.ColumnHeader AgeColumnHeader;
		private System.Windows.Forms.ColumnHeader ClassColumnHeader;
		private System.Windows.Forms.Button PrintButton;
		private System.Windows.Forms.Button BadgesButton;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.HelpProvider helpProvider1;
	}
}