namespace Karate.Forms
{
	partial class PrintForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
			this.PrintButton = new System.Windows.Forms.Button();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.richTextBoxPrintCtrl1 = new Karate.UserControls.RichTextBoxPrintCtrl();
			this.SuspendLayout();
			// 
			// PrintButton
			// 
			this.PrintButton.Location = new System.Drawing.Point(642, 421);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.Size = new System.Drawing.Size(75, 23);
			this.PrintButton.TabIndex = 1;
			this.PrintButton.Text = "Print";
			this.PrintButton.UseVisualStyleBackColor = true;
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
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
			// richTextBoxPrintCtrl1
			// 
			this.richTextBoxPrintCtrl1.Location = new System.Drawing.Point(12, 12);
			this.richTextBoxPrintCtrl1.Name = "richTextBoxPrintCtrl1";
			this.richTextBoxPrintCtrl1.Size = new System.Drawing.Size(705, 403);
			this.richTextBoxPrintCtrl1.TabIndex = 2;
			this.richTextBoxPrintCtrl1.Text = "";
			// 
			// PrintForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 456);
			this.Controls.Add(this.richTextBoxPrintCtrl1);
			this.Controls.Add(this.PrintButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PrintForm";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button PrintButton;
		private UserControls.RichTextBoxPrintCtrl richTextBoxPrintCtrl1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
	}
}