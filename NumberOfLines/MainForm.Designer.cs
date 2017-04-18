namespace NumberOfLines
{
	partial class MainForm
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
			this.tbFolderPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.labelNumberOfLines = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbSearchPattern = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbFolderPath
			// 
			this.tbFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFolderPath.Location = new System.Drawing.Point(12, 32);
			this.tbFolderPath.Name = "tbFolderPath";
			this.tbFolderPath.ReadOnly = true;
			this.tbFolderPath.Size = new System.Drawing.Size(206, 20);
			this.tbFolderPath.TabIndex = 0;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(262, 28);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(68, 28);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Folder path:";
			// 
			// labelNumberOfLines
			// 
			this.labelNumberOfLines.AutoSize = true;
			this.labelNumberOfLines.Location = new System.Drawing.Point(92, 60);
			this.labelNumberOfLines.Name = "labelNumberOfLines";
			this.labelNumberOfLines.Size = new System.Drawing.Size(94, 13);
			this.labelNumberOfLines.TabIndex = 3;
			this.labelNumberOfLines.Text = "                             ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "# of lines:";
			// 
			// tbSearchPattern
			// 
			this.tbSearchPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSearchPattern.Location = new System.Drawing.Point(218, 32);
			this.tbSearchPattern.Name = "tbSearchPattern";
			this.tbSearchPattern.Size = new System.Drawing.Size(44, 20);
			this.tbSearchPattern.TabIndex = 5;
			this.tbSearchPattern.Text = "*.cs";
			this.tbSearchPattern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 91);
			this.Controls.Add(this.tbSearchPattern);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelNumberOfLines);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.tbFolderPath);
			this.MaximumSize = new System.Drawing.Size(1000, 129);
			this.MinimumSize = new System.Drawing.Size(300, 129);
			this.Name = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbFolderPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelNumberOfLines;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbSearchPattern;
	}
}

