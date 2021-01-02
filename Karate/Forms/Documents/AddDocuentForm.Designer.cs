namespace Karate.Forms.Documents
{
	partial class AddDocuentForm
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
			this.SaveButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.NewStarterFormCheckBox = new System.Windows.Forms.CheckBox();
			this.FilenameTextBox = new System.Windows.Forms.TextBox();
			this.SearchButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.SaveButton.Image = global::Karate.Properties.Resources.save;
			this.SaveButton.Location = new System.Drawing.Point(166, 102);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(49, 44);
			this.SaveButton.TabIndex = 0;
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Image = global::Karate.Properties.Resources.delete;
			this.CancelButton.Location = new System.Drawing.Point(232, 102);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(49, 44);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.NewStarterFormCheckBox);
			this.groupBox1.Controls.Add(this.FilenameTextBox);
			this.groupBox1.Controls.Add(this.SearchButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(267, 84);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filename information";
			// 
			// NewStarterFormCheckBox
			// 
			this.NewStarterFormCheckBox.AutoSize = true;
			this.NewStarterFormCheckBox.Location = new System.Drawing.Point(10, 58);
			this.NewStarterFormCheckBox.Name = "NewStarterFormCheckBox";
			this.NewStarterFormCheckBox.Size = new System.Drawing.Size(108, 17);
			this.NewStarterFormCheckBox.TabIndex = 7;
			this.NewStarterFormCheckBox.Text = "New Starter Form";
			this.NewStarterFormCheckBox.UseVisualStyleBackColor = true;
			// 
			// FilenameTextBox
			// 
			this.FilenameTextBox.Location = new System.Drawing.Point(10, 32);
			this.FilenameTextBox.Name = "FilenameTextBox";
			this.FilenameTextBox.Size = new System.Drawing.Size(194, 20);
			this.FilenameTextBox.TabIndex = 6;
			// 
			// SearchButton
			// 
			this.SearchButton.Image = global::Karate.Properties.Resources.Search;
			this.SearchButton.Location = new System.Drawing.Point(210, 19);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(49, 44);
			this.SearchButton.TabIndex = 5;
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// AddDocuentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 158);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.SaveButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddDocuentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Docment";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox NewStarterFormCheckBox;
		private System.Windows.Forms.TextBox FilenameTextBox;
		private System.Windows.Forms.Button SearchButton;
	}
}