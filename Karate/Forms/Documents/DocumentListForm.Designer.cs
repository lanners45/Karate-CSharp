namespace Karate.Forms.Documents
{
	partial class DocumentListForm
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
			this.MemberNameTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.FilesListView = new System.Windows.Forms.ListView();
			this.FileNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DateCreatedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SizeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AddButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.OpenButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// MemberNameTextBox
			// 
			this.MemberNameTextBox.Location = new System.Drawing.Point(54, 10);
			this.MemberNameTextBox.Name = "MemberNameTextBox";
			this.MemberNameTextBox.ReadOnly = true;
			this.MemberNameTextBox.Size = new System.Drawing.Size(167, 20);
			this.MemberNameTextBox.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.FilesListView);
			this.groupBox1.Location = new System.Drawing.Point(16, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(432, 197);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Documents";
			// 
			// FilesListView
			// 
			this.FilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNameColumnHeader,
            this.DateCreatedColumnHeader,
            this.SizeColumnHeader});
			this.FilesListView.FullRowSelect = true;
			this.FilesListView.GridLines = true;
			this.FilesListView.Location = new System.Drawing.Point(7, 20);
			this.FilesListView.Name = "FilesListView";
			this.FilesListView.Size = new System.Drawing.Size(409, 171);
			this.FilesListView.TabIndex = 0;
			this.FilesListView.UseCompatibleStateImageBehavior = false;
			this.FilesListView.View = System.Windows.Forms.View.Details;
			// 
			// FileNameColumnHeader
			// 
			this.FileNameColumnHeader.Text = "File name";
			this.FileNameColumnHeader.Width = 200;
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
			// AddButton
			// 
			this.AddButton.Image = global::Karate.Properties.Resources.add;
			this.AddButton.Location = new System.Drawing.Point(454, 64);
			this.AddButton.Name = "AddButton";
			this.AddButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.AddButton.Size = new System.Drawing.Size(49, 44);
			this.AddButton.TabIndex = 3;
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Image = global::Karate.Properties.Resources.delete;
			this.DeleteButton.Location = new System.Drawing.Point(454, 114);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.DeleteButton.Size = new System.Drawing.Size(49, 44);
			this.DeleteButton.TabIndex = 4;
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// OpenButton
			// 
			this.OpenButton.Location = new System.Drawing.Point(454, 164);
			this.OpenButton.Name = "OpenButton";
			this.OpenButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.OpenButton.Size = new System.Drawing.Size(49, 44);
			this.OpenButton.TabIndex = 5;
			this.OpenButton.UseVisualStyleBackColor = true;
			this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
			// 
			// DocumentListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 253);
			this.Controls.Add(this.OpenButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.MemberNameTextBox);
			this.Controls.Add(this.label1);
			this.Name = "DocumentListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DocumentListForm";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox MemberNameTextBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView FilesListView;
		private System.Windows.Forms.ColumnHeader FileNameColumnHeader;
		private System.Windows.Forms.ColumnHeader DateCreatedColumnHeader;
		private System.Windows.Forms.ColumnHeader SizeColumnHeader;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button OpenButton;
	}
}