namespace Karate.Forms
{
	partial class LicienceExpiryForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicienceExpiryForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ActiveMembersListView = new System.Windows.Forms.ListView();
			this.FirstNameHeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LastNameHeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ClassColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AgeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ExpiryDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PrintButton = new System.Windows.Forms.Button();
			this.LicenceButton = new System.Windows.Forms.Button();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.ActiveMembersListView);
			this.groupBox1.Controls.Add(this.PrintButton);
			this.groupBox1.Controls.Add(this.LicenceButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(585, 346);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Licence Expiry";
			// 
			// ActiveMembersListView
			// 
			this.ActiveMembersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameHeaderColumn,
            this.LastNameHeaderColumn,
            this.ClassColumnHeader,
            this.AgeColumnHeader,
            this.ExpiryDateColumnHeader});
			this.ActiveMembersListView.FullRowSelect = true;
			this.ActiveMembersListView.GridLines = true;
			this.ActiveMembersListView.HideSelection = false;
			this.ActiveMembersListView.Location = new System.Drawing.Point(4, 55);
			this.ActiveMembersListView.Name = "ActiveMembersListView";
			this.ActiveMembersListView.Size = new System.Drawing.Size(510, 261);
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
			// ClassColumnHeader
			// 
			this.ClassColumnHeader.Text = "Class";
			// 
			// AgeColumnHeader
			// 
			this.AgeColumnHeader.Text = "Age";
			this.AgeColumnHeader.Width = 70;
			// 
			// ExpiryDateColumnHeader
			// 
			this.ExpiryDateColumnHeader.Text = "Expiry Date";
			this.ExpiryDateColumnHeader.Width = 100;
			// 
			// PrintButton
			// 
			this.PrintButton.Image = global::Karate.Properties.Resources.print_icon;
			this.PrintButton.Location = new System.Drawing.Point(520, 104);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.Size = new System.Drawing.Size(49, 44);
			this.PrintButton.TabIndex = 28;
			this.toolTip1.SetToolTip(this.PrintButton, "Print Licence Expiry Information");
			this.PrintButton.UseVisualStyleBackColor = true;
			this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// LicenceButton
			// 
			this.LicenceButton.Image = global::Karate.Properties.Resources.licence;
			this.LicenceButton.Location = new System.Drawing.Point(520, 54);
			this.LicenceButton.Name = "LicenceButton";
			this.LicenceButton.Size = new System.Drawing.Size(49, 44);
			this.LicenceButton.TabIndex = 23;
			this.toolTip1.SetToolTip(this.LicenceButton, "Licences management");
			this.LicenceButton.UseVisualStyleBackColor = true;
			this.LicenceButton.Click += new System.EventHandler(this.LicenceButton_Click);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(73, 21);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 29;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 30;
			this.label1.Text = "Expiry Date";
			// 
			// LicienceExpiryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 385);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LicienceExpiryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Licence Information";
			this.Load += new System.EventHandler(this.ActiveMembersForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button LicenceButton;
		private System.Windows.Forms.ListView ActiveMembersListView;
		private System.Windows.Forms.ColumnHeader FirstNameHeaderColumn;
		private System.Windows.Forms.ColumnHeader LastNameHeaderColumn;
		private System.Windows.Forms.ColumnHeader ExpiryDateColumnHeader;
		private System.Windows.Forms.ColumnHeader AgeColumnHeader;
		private System.Windows.Forms.ColumnHeader ClassColumnHeader;
		private System.Windows.Forms.Button PrintButton;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}