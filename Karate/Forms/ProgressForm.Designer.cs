namespace Karate.Forms
{
	partial class ProgressForm
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
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.ProgressInformationLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ProgressBar
			// 
			this.ProgressBar.Location = new System.Drawing.Point(62, 28);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(177, 23);
			this.ProgressBar.TabIndex = 0;
			// 
			// ProgressInformationLabel
			// 
			this.ProgressInformationLabel.AutoSize = true;
			this.ProgressInformationLabel.Location = new System.Drawing.Point(59, 67);
			this.ProgressInformationLabel.Name = "ProgressInformationLabel";
			this.ProgressInformationLabel.Size = new System.Drawing.Size(35, 13);
			this.ProgressInformationLabel.TabIndex = 1;
			this.ProgressInformationLabel.Text = "label1";
			// 
			// ProgressForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 98);
			this.Controls.Add(this.ProgressInformationLabel);
			this.Controls.Add(this.ProgressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProgressForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProcessingForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.ProgressBar ProgressBar;
		public System.Windows.Forms.Label ProgressInformationLabel;
	}
}