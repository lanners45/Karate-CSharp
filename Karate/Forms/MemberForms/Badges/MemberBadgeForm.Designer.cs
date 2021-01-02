namespace Karate.Forms.MemberForms.Badges
{
	partial class MemberBadgeForm
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
			this.DeleteBadgeButton = new System.Windows.Forms.Button();
			this.AddBageButton = new System.Windows.Forms.Button();
			this.MemberBadgeListView = new System.Windows.Forms.ListView();
			this.GradeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DateAchievedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// DeleteBadgeButton
			// 
			this.DeleteBadgeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.DeleteBadgeButton.Image = global::Karate.Properties.Resources.delete;
			this.DeleteBadgeButton.Location = new System.Drawing.Point(555, 49);
			this.DeleteBadgeButton.Name = "DeleteBadgeButton";
			this.DeleteBadgeButton.Size = new System.Drawing.Size(39, 37);
			this.DeleteBadgeButton.TabIndex = 6;
			this.DeleteBadgeButton.UseVisualStyleBackColor = true;
			this.DeleteBadgeButton.Click += new System.EventHandler(this.DeleteBadgeButton_Click);
			// 
			// AddBageButton
			// 
			this.AddBageButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.AddBageButton.Image = global::Karate.Properties.Resources.add;
			this.AddBageButton.Location = new System.Drawing.Point(555, 6);
			this.AddBageButton.Name = "AddBageButton";
			this.AddBageButton.Size = new System.Drawing.Size(39, 37);
			this.AddBageButton.TabIndex = 5;
			this.AddBageButton.UseVisualStyleBackColor = true;
			this.AddBageButton.Click += new System.EventHandler(this.AddBageButton_Click);
			// 
			// MemberBadgeListView
			// 
			this.MemberBadgeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GradeColumnHeader,
            this.columnHeader1,
            this.DateAchievedColumnHeader});
			this.MemberBadgeListView.FullRowSelect = true;
			this.MemberBadgeListView.GridLines = true;
			this.MemberBadgeListView.Location = new System.Drawing.Point(12, 12);
			this.MemberBadgeListView.Name = "MemberBadgeListView";
			this.MemberBadgeListView.Size = new System.Drawing.Size(530, 122);
			this.MemberBadgeListView.TabIndex = 7;
			this.MemberBadgeListView.UseCompatibleStateImageBehavior = false;
			this.MemberBadgeListView.View = System.Windows.Forms.View.Details;
			// 
			// GradeColumnHeader
			// 
			this.GradeColumnHeader.DisplayIndex = 1;
			this.GradeColumnHeader.Text = "Badge Type";
			this.GradeColumnHeader.Width = 161;
			// 
			// columnHeader1
			// 
			this.columnHeader1.DisplayIndex = 2;
			this.columnHeader1.Text = "Badge Description";
			this.columnHeader1.Width = 264;
			// 
			// DateAchievedColumnHeader
			// 
			this.DateAchievedColumnHeader.DisplayIndex = 0;
			this.DateAchievedColumnHeader.Text = "Date Achieved";
			this.DateAchievedColumnHeader.Width = 100;
			// 
			// MemberBadgeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 150);
			this.Controls.Add(this.MemberBadgeListView);
			this.Controls.Add(this.DeleteBadgeButton);
			this.Controls.Add(this.AddBageButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MemberBadgeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Member Badges";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button DeleteBadgeButton;
		private System.Windows.Forms.Button AddBageButton;
		private System.Windows.Forms.ListView MemberBadgeListView;
		private System.Windows.Forms.ColumnHeader GradeColumnHeader;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader DateAchievedColumnHeader;
	}
}