namespace Karate.Forms.MemberForms.Gradings
{
	partial class GradeForm
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
			this.GradesListView = new System.Windows.Forms.ListView();
			this.GradeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BeltDescriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.StyleListView = new System.Windows.Forms.ListView();
			this.StyleNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CancelButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.DateAchievedDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.GradesListView);
			this.groupBox2.Location = new System.Drawing.Point(19, 203);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(442, 148);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Grades";
			// 
			// GradesListView
			// 
			this.GradesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GradeColumnHeader,
            this.BeltDescriptionColumnHeader});
			this.GradesListView.FullRowSelect = true;
			this.GradesListView.GridLines = true;
			this.GradesListView.Location = new System.Drawing.Point(6, 19);
			this.GradesListView.Name = "GradesListView";
			this.GradesListView.Size = new System.Drawing.Size(433, 122);
			this.GradesListView.TabIndex = 6;
			this.GradesListView.UseCompatibleStateImageBehavior = false;
			this.GradesListView.View = System.Windows.Forms.View.Details;
			this.GradesListView.SelectedIndexChanged += new System.EventHandler(this.GradesListView_SelectedIndexChanged);
			// 
			// GradeColumnHeader
			// 
			this.GradeColumnHeader.Text = "Grade";
			this.GradeColumnHeader.Width = 161;
			// 
			// BeltDescriptionColumnHeader
			// 
			this.BeltDescriptionColumnHeader.Text = "Belt Description";
			this.BeltDescriptionColumnHeader.Width = 264;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.StyleListView);
			this.groupBox1.Location = new System.Drawing.Point(12, 49);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(214, 148);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Styles";
			// 
			// StyleListView
			// 
			this.StyleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StyleNameColumnHeader});
			this.StyleListView.FullRowSelect = true;
			this.StyleListView.GridLines = true;
			this.StyleListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.StyleListView.Location = new System.Drawing.Point(7, 20);
			this.StyleListView.MultiSelect = false;
			this.StyleListView.Name = "StyleListView";
			this.StyleListView.Size = new System.Drawing.Size(194, 122);
			this.StyleListView.TabIndex = 5;
			this.StyleListView.UseCompatibleStateImageBehavior = false;
			this.StyleListView.View = System.Windows.Forms.View.Details;
			this.StyleListView.SelectedIndexChanged += new System.EventHandler(this.StyleListView_SelectedIndexChanged);
			// 
			// StyleNameColumnHeader
			// 
			this.StyleNameColumnHeader.Width = 180;
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(386, 357);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 5;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// SaveButton
			// 
			this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.SaveButton.Enabled = false;
			this.SaveButton.Location = new System.Drawing.Point(277, 357);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			// 
			// DateAchievedDatePicker
			// 
			this.DateAchievedDatePicker.Location = new System.Drawing.Point(68, 17);
			this.DateAchievedDatePicker.Name = "DateAchievedDatePicker";
			this.DateAchievedDatePicker.Size = new System.Drawing.Size(145, 20);
			this.DateAchievedDatePicker.TabIndex = 18;
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
			// GradeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 391);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DateAchievedDatePicker);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GradeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Adding Grade for ";
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView GradesListView;
		private System.Windows.Forms.ColumnHeader GradeColumnHeader;
		private System.Windows.Forms.ColumnHeader BeltDescriptionColumnHeader;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView StyleListView;
		private System.Windows.Forms.ColumnHeader StyleNameColumnHeader;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.DateTimePicker DateAchievedDatePicker;
		private System.Windows.Forms.Label label1;
	}
}