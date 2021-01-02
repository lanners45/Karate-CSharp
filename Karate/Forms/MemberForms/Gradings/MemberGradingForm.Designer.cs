namespace Karate.Forms.MemberForms
{
	partial class MemberGradingForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.MemberGradeListView = new System.Windows.Forms.ListView();
			this.DateAcheivedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GradeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BeltDescriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CurrentBeltColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DeleteStyleButton = new System.Windows.Forms.Button();
			this.AddStyleButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name : ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(63, 10);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(189, 20);
			this.textBox1.TabIndex = 1;
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
			this.MemberGradeListView.Location = new System.Drawing.Point(16, 36);
			this.MemberGradeListView.Name = "MemberGradeListView";
			this.MemberGradeListView.Size = new System.Drawing.Size(523, 119);
			this.MemberGradeListView.TabIndex = 2;
			this.MemberGradeListView.UseCompatibleStateImageBehavior = false;
			this.MemberGradeListView.View = System.Windows.Forms.View.Details;
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
			// DeleteStyleButton
			// 
			this.DeleteStyleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.DeleteStyleButton.Image = global::Karate.Properties.Resources.delete;
			this.DeleteStyleButton.Location = new System.Drawing.Point(544, 81);
			this.DeleteStyleButton.Name = "DeleteStyleButton";
			this.DeleteStyleButton.Size = new System.Drawing.Size(39, 37);
			this.DeleteStyleButton.TabIndex = 6;
			this.DeleteStyleButton.UseVisualStyleBackColor = true;
			this.DeleteStyleButton.Click += new System.EventHandler(this.DeleteStyleButton_Click);
			// 
			// AddStyleButton
			// 
			this.AddStyleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.AddStyleButton.Image = global::Karate.Properties.Resources.add;
			this.AddStyleButton.Location = new System.Drawing.Point(544, 38);
			this.AddStyleButton.Name = "AddStyleButton";
			this.AddStyleButton.Size = new System.Drawing.Size(39, 37);
			this.AddStyleButton.TabIndex = 5;
			this.AddStyleButton.UseVisualStyleBackColor = true;
			this.AddStyleButton.Click += new System.EventHandler(this.AddStyleButton_Click);
			// 
			// MemberGradingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(595, 171);
			this.Controls.Add(this.DeleteStyleButton);
			this.Controls.Add(this.AddStyleButton);
			this.Controls.Add(this.MemberGradeListView);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MemberGradingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MemberGradingForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListView MemberGradeListView;
		private System.Windows.Forms.Button DeleteStyleButton;
		private System.Windows.Forms.Button AddStyleButton;
		private System.Windows.Forms.ColumnHeader DateAcheivedColumnHeader;
		private System.Windows.Forms.ColumnHeader GradeColumnHeader;
		private System.Windows.Forms.ColumnHeader BeltDescriptionColumnHeader;
		private System.Windows.Forms.ColumnHeader CurrentBeltColumnHeader;
	}
}