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
			this.SuspendLayout();
			// 
			// tbFolderPath
			// 
			this.tbFolderPath.Location = new System.Drawing.Point(12, 32);
			this.tbFolderPath.Name = "tbFolderPath";
			this.tbFolderPath.ReadOnly = true;
			this.tbFolderPath.Size = new System.Drawing.Size(340, 20);
			this.tbFolderPath.TabIndex = 0;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(356, 28);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 91);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelNumberOfLines);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.tbFolderPath);
			this.MaximumSize = new System.Drawing.Size(444, 129);
			this.MinimumSize = new System.Drawing.Size(444, 129);
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
	}
}

