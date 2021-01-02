namespace Karate.Forms.Maintenance
{
	partial class ClassListForm
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
			this.ClassesListView = new System.Windows.Forms.ListView();
			this.ClassNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DeleteButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ClassesListView
			// 
			this.ClassesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassNameColumnHeader});
			this.ClassesListView.FullRowSelect = true;
			this.ClassesListView.GridLines = true;
			this.ClassesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.ClassesListView.Location = new System.Drawing.Point(3, 12);
			this.ClassesListView.Name = "ClassesListView";
			this.ClassesListView.Size = new System.Drawing.Size(184, 105);
			this.ClassesListView.TabIndex = 0;
			this.ClassesListView.UseCompatibleStateImageBehavior = false;
			this.ClassesListView.View = System.Windows.Forms.View.List;
			// 
			// ClassNameColumnHeader
			// 
			this.ClassNameColumnHeader.Text = "Class Name";
			this.ClassNameColumnHeader.Width = 150;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Image = global::Karate.Properties.Resources.delete;
			this.DeleteButton.Location = new System.Drawing.Point(203, 80);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(39, 37);
			this.DeleteButton.TabIndex = 2;
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// AddButton
			// 
			this.AddButton.Image = global::Karate.Properties.Resources.add;
			this.AddButton.Location = new System.Drawing.Point(203, 12);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(39, 37);
			this.AddButton.TabIndex = 1;
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// ClassesList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 131);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.ClassesListView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ClassesList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Classes";
			this.Load += new System.EventHandler(this.ClassesList_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView ClassesListView;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.ColumnHeader ClassNameColumnHeader;
	}
}