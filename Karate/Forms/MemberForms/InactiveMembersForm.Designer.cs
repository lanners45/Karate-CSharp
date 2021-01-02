namespace Karate.Forms
{
	partial class InactiveMembersForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InactiveMembersForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.InActiveMembersListView = new System.Windows.Forms.ListView();
			this.FirstNameHeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LastNameHeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.InActiveDaysColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PrintButton = new System.Windows.Forms.Button();
			this.ReactiveMemberButton = new System.Windows.Forms.Button();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.InActiveMembersListView);
			this.groupBox1.Controls.Add(this.PrintButton);
			this.groupBox1.Controls.Add(this.ReactiveMemberButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(405, 282);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Inactive Members";
			// 
			// InActiveMembersListView
			// 
			this.InActiveMembersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNameHeaderColumn,
            this.LastNameHeaderColumn,
            this.InActiveDaysColumnHeader});
			this.InActiveMembersListView.FullRowSelect = true;
			this.InActiveMembersListView.GridLines = true;
			this.InActiveMembersListView.Location = new System.Drawing.Point(7, 16);
			this.InActiveMembersListView.Name = "InActiveMembersListView";
			this.InActiveMembersListView.Size = new System.Drawing.Size(334, 261);
			this.InActiveMembersListView.TabIndex = 27;
			this.toolTip1.SetToolTip(this.InActiveMembersListView, "Select member");
			this.InActiveMembersListView.UseCompatibleStateImageBehavior = false;
			this.InActiveMembersListView.View = System.Windows.Forms.View.Details;
			this.InActiveMembersListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.InActiveMembersListView_ColumnClick);
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
			// InActiveDaysColumnHeader
			// 
			this.InActiveDaysColumnHeader.Text = "Inactive Days";
			this.InActiveDaysColumnHeader.Width = 100;
			// 
			// PrintButton
			// 
			this.PrintButton.Image = global::Karate.Properties.Resources.print_icon;
			this.PrintButton.Location = new System.Drawing.Point(347, 64);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.Size = new System.Drawing.Size(49, 44);
			this.PrintButton.TabIndex = 28;
			this.toolTip1.SetToolTip(this.PrintButton, "Print Inactive Members List");
			this.PrintButton.UseVisualStyleBackColor = true;
			this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// ReactiveMemberButton
			// 
			this.ReactiveMemberButton.Image = global::Karate.Properties.Resources.Reactivate;
			this.ReactiveMemberButton.Location = new System.Drawing.Point(347, 14);
			this.ReactiveMemberButton.Name = "ReactiveMemberButton";
			this.ReactiveMemberButton.Size = new System.Drawing.Size(49, 44);
			this.ReactiveMemberButton.TabIndex = 19;
			this.toolTip1.SetToolTip(this.ReactiveMemberButton, "Reactive Member");
			this.ReactiveMemberButton.UseVisualStyleBackColor = true;
			this.ReactiveMemberButton.Click += new System.EventHandler(this.ReactiveMemberButton_Click);
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
			// InactiveMembersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 302);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InactiveMembersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Licence Information";
			this.Load += new System.EventHandler(this.ActiveMembersForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button ReactiveMemberButton;
		private System.Windows.Forms.ListView InActiveMembersListView;
		private System.Windows.Forms.ColumnHeader FirstNameHeaderColumn;
		private System.Windows.Forms.ColumnHeader LastNameHeaderColumn;
		private System.Windows.Forms.ColumnHeader InActiveDaysColumnHeader;
		private System.Windows.Forms.Button PrintButton;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}