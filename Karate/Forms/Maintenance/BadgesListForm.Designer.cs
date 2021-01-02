namespace Karate.Forms
{
	partial class BadgesListForm
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
			this.DeleteButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.BadgesListView = new System.Windows.Forms.ListView();
			this.BadgeTypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BadgeDescriptionColunHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// DeleteButton
			// 
			this.DeleteButton.Image = global::Karate.Properties.Resources.delete;
			this.DeleteButton.Location = new System.Drawing.Point(379, 64);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(39, 37);
			this.DeleteButton.TabIndex = 5;
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Image = global::Karate.Properties.Resources.add;
			this.AddButton.Location = new System.Drawing.Point(379, 21);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(39, 37);
			this.AddButton.TabIndex = 4;
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// BadgesListView
			// 
			this.BadgesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BadgeTypeColumnHeader,
            this.BadgeDescriptionColunHeader});
			this.BadgesListView.FullRowSelect = true;
			this.BadgesListView.GridLines = true;
			this.BadgesListView.Location = new System.Drawing.Point(12, 21);
			this.BadgesListView.Name = "BadgesListView";
			this.BadgesListView.Size = new System.Drawing.Size(361, 249);
			this.BadgesListView.TabIndex = 3;
			this.BadgesListView.UseCompatibleStateImageBehavior = false;
			this.BadgesListView.View = System.Windows.Forms.View.Details;
			// 
			// BadgeTypeColumnHeader
			// 
			this.BadgeTypeColumnHeader.Text = "Badge Type";
			this.BadgeTypeColumnHeader.Width = 150;
			// 
			// BadgeDescriptionColunHeader
			// 
			this.BadgeDescriptionColunHeader.Text = "Badge Description";
			this.BadgeDescriptionColunHeader.Width = 144;
			// 
			// BadgesListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 282);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.BadgesListView);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BadgesListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Badges";
			this.Load += new System.EventHandler(this.BadgesForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.ListView BadgesListView;
		private System.Windows.Forms.ColumnHeader BadgeTypeColumnHeader;
		private System.Windows.Forms.ColumnHeader BadgeDescriptionColunHeader;
	}
}