namespace Karate.Forms.Maintenance
{
	partial class StyleAndGradeForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.StyleListView = new System.Windows.Forms.ListView();
			this.StyleNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DeleteStyleButton = new System.Windows.Forms.Button();
			this.AddStyleButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.GradesListView = new System.Windows.Forms.ListView();
			this.GradeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BeltDescriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DeleteGradeButton = new System.Windows.Forms.Button();
			this.AddGtradeButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.StyleListView);
			this.groupBox1.Controls.Add(this.DeleteStyleButton);
			this.groupBox1.Controls.Add(this.AddStyleButton);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(275, 148);
			this.groupBox1.TabIndex = 0;
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
			// DeleteStyleButton
			// 
			this.DeleteStyleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.DeleteStyleButton.Image = global::Karate.Properties.Resources.delete;
			this.DeleteStyleButton.Location = new System.Drawing.Point(218, 87);
			this.DeleteStyleButton.Name = "DeleteStyleButton";
			this.DeleteStyleButton.Size = new System.Drawing.Size(39, 37);
			this.DeleteStyleButton.TabIndex = 4;
			this.DeleteStyleButton.UseVisualStyleBackColor = true;
			this.DeleteStyleButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// AddStyleButton
			// 
			this.AddStyleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.AddStyleButton.Image = global::Karate.Properties.Resources.add;
			this.AddStyleButton.Location = new System.Drawing.Point(218, 19);
			this.AddStyleButton.Name = "AddStyleButton";
			this.AddStyleButton.Size = new System.Drawing.Size(39, 37);
			this.AddStyleButton.TabIndex = 3;
			this.AddStyleButton.UseVisualStyleBackColor = true;
			this.AddStyleButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.GradesListView);
			this.groupBox2.Controls.Add(this.DeleteGradeButton);
			this.groupBox2.Controls.Add(this.AddGtradeButton);
			this.groupBox2.Location = new System.Drawing.Point(13, 167);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(523, 148);
			this.groupBox2.TabIndex = 1;
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
			this.GradesListView.Location = new System.Drawing.Point(16, 20);
			this.GradesListView.Name = "GradesListView";
			this.GradesListView.Size = new System.Drawing.Size(433, 122);
			this.GradesListView.TabIndex = 6;
			this.GradesListView.UseCompatibleStateImageBehavior = false;
			this.GradesListView.View = System.Windows.Forms.View.Details;
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
			// DeleteGradeButton
			// 
			this.DeleteGradeButton.Image = global::Karate.Properties.Resources.delete;
			this.DeleteGradeButton.Location = new System.Drawing.Point(466, 87);
			this.DeleteGradeButton.Name = "DeleteGradeButton";
			this.DeleteGradeButton.Size = new System.Drawing.Size(39, 37);
			this.DeleteGradeButton.TabIndex = 4;
			this.DeleteGradeButton.UseVisualStyleBackColor = true;
			this.DeleteGradeButton.Click += new System.EventHandler(this.DeleteGradeButton_Click);
			// 
			// AddGtradeButton
			// 
			this.AddGtradeButton.Image = global::Karate.Properties.Resources.add;
			this.AddGtradeButton.Location = new System.Drawing.Point(466, 20);
			this.AddGtradeButton.Name = "AddGtradeButton";
			this.AddGtradeButton.Size = new System.Drawing.Size(39, 37);
			this.AddGtradeButton.TabIndex = 3;
			this.AddGtradeButton.UseVisualStyleBackColor = true;
			this.AddGtradeButton.Click += new System.EventHandler(this.AddGtradeButton_Click);
			// 
			// StyleAndGradeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 320);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StyleAndGradeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StyleAndGradeForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button DeleteStyleButton;
		private System.Windows.Forms.Button AddStyleButton;
		private System.Windows.Forms.ListView StyleListView;
		private System.Windows.Forms.ColumnHeader StyleNameColumnHeader;
		private System.Windows.Forms.ListView GradesListView;
		private System.Windows.Forms.ColumnHeader GradeColumnHeader;
		private System.Windows.Forms.ColumnHeader BeltDescriptionColumnHeader;
		private System.Windows.Forms.Button DeleteGradeButton;
		private System.Windows.Forms.Button AddGtradeButton;
	}
}