namespace Karate.Forms.MemberForms.Badges
{
	partial class BadgeForm
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BadgeListView = new System.Windows.Forms.ListView();
			this.BadgeTypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BadgeDescriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CancelButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.DateAchievedDatePicker = new System.Windows.Forms.DateTimePicker();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.BadgeListView);
			this.groupBox2.Location = new System.Drawing.Point(12, 43);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(393, 148);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Badges";
			// 
			// BadgeListView
			// 
			this.BadgeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BadgeTypeColumnHeader,
            this.BadgeDescriptionColumnHeader});
			this.BadgeListView.FullRowSelect = true;
			this.BadgeListView.GridLines = true;
			this.BadgeListView.HideSelection = false;
			this.BadgeListView.Location = new System.Drawing.Point(22, 19);
			this.BadgeListView.Name = "BadgeListView";
			this.BadgeListView.Size = new System.Drawing.Size(353, 119);
			this.BadgeListView.TabIndex = 3;
			this.BadgeListView.UseCompatibleStateImageBehavior = false;
			this.BadgeListView.View = System.Windows.Forms.View.Details;
			this.BadgeListView.SelectedIndexChanged += new System.EventHandler(this.BadgeListView_SelectedIndexChanged);
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
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Image = global::Karate.Properties.Resources.delete;
			this.CancelButton.Location = new System.Drawing.Point(411, 104);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(49, 44);
			this.CancelButton.TabIndex = 5;
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.SaveButton.Enabled = false;
			this.SaveButton.Image = global::Karate.Properties.Resources.save;
			this.SaveButton.Location = new System.Drawing.Point(411, 54);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(49, 44);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Date";
			// 
			// DateAchievedDatePicker
			// 
			this.DateAchievedDatePicker.Location = new System.Drawing.Point(68, 17);
			this.DateAchievedDatePicker.Name = "DateAchievedDatePicker";
			this.DateAchievedDatePicker.Size = new System.Drawing.Size(145, 20);
			this.DateAchievedDatePicker.TabIndex = 18;
			// 
			// BadgeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 198);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DateAchievedDatePicker);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.groupBox2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BadgeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Addi new badge";
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.ListView BadgeListView;
		private System.Windows.Forms.ColumnHeader BadgeTypeColumnHeader;
		private System.Windows.Forms.ColumnHeader BadgeDescriptionColumnHeader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker DateAchievedDatePicker;
	}
}