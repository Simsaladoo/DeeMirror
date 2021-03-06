﻿namespace DeeMirror.GUI
{
	partial class SimulationResultDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationResultDialog));
            this.abortButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proceedButton = new System.Windows.Forms.Button();
            this.deletedFoldersLabel = new System.Windows.Forms.Label();
            this.copiedFoldersLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.deletedFilesLabel = new System.Windows.Forms.Label();
            this.copiedFilesLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // abortButton
            // 
            this.abortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.abortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.abortButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abortButton.FlatAppearance.BorderSize = 0;
            this.abortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.abortButton.Image = global::DeeMirror.Properties.Resources.delete;
            this.abortButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abortButton.Location = new System.Drawing.Point(593, 375);
            this.abortButton.Name = "abortButton";
            this.abortButton.Padding = new System.Windows.Forms.Padding(17, 0, 32, 0);
            this.abortButton.Size = new System.Drawing.Size(134, 40);
            this.abortButton.TabIndex = 14;
            this.abortButton.Text = "Abort";
            this.abortButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.abortButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pictureBox3.Image = global::DeeMirror.Properties.Resources.data_information32;
            this.pictureBox3.Location = new System.Drawing.Point(688, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 40);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(16, 0, 74, 0);
            this.label1.Size = new System.Drawing.Size(746, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here are the pending changes to {0}.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // proceedButton
            // 
            this.proceedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.proceedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.proceedButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.proceedButton.FlatAppearance.BorderSize = 0;
            this.proceedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.proceedButton.Image = global::DeeMirror.Properties.Resources.check;
            this.proceedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proceedButton.Location = new System.Drawing.Point(439, 375);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Padding = new System.Windows.Forms.Padding(17, 0, 21, 0);
            this.proceedButton.Size = new System.Drawing.Size(134, 40);
            this.proceedButton.TabIndex = 13;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.proceedButton.UseVisualStyleBackColor = false;
            // 
            // deletedFoldersLabel
            // 
            this.deletedFoldersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletedFoldersLabel.AutoSize = true;
            this.deletedFoldersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.deletedFoldersLabel.Location = new System.Drawing.Point(497, 107);
            this.deletedFoldersLabel.Name = "deletedFoldersLabel";
            this.deletedFoldersLabel.Size = new System.Drawing.Size(97, 13);
            this.deletedFoldersLabel.TabIndex = 8;
            this.deletedFoldersLabel.Text = "666 out of 666 666";
            // 
            // copiedFoldersLabel
            // 
            this.copiedFoldersLabel.AutoSize = true;
            this.copiedFoldersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.copiedFoldersLabel.Location = new System.Drawing.Point(120, 107);
            this.copiedFoldersLabel.Name = "copiedFoldersLabel";
            this.copiedFoldersLabel.Size = new System.Drawing.Size(97, 13);
            this.copiedFoldersLabel.TabIndex = 3;
            this.copiedFoldersLabel.Text = "666 out of 666 666";
            this.copiedFoldersLabel.Click += new System.EventHandler(this.copiedFoldersLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeeMirror.Properties.Resources.redo24;
            this.pictureBox1.Location = new System.Drawing.Point(19, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(435, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Folders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(58, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Folders:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBox1.Location = new System.Drawing.Point(3, 186);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(743, 170);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // deletedFilesLabel
            // 
            this.deletedFilesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletedFilesLabel.AutoSize = true;
            this.deletedFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.deletedFilesLabel.Location = new System.Drawing.Point(497, 134);
            this.deletedFilesLabel.Name = "deletedFilesLabel";
            this.deletedFilesLabel.Size = new System.Drawing.Size(89, 26);
            this.deletedFilesLabel.TabIndex = 10;
            this.deletedFilesLabel.Text = "666 666\r\n546 321.5 gbytes";
            // 
            // copiedFilesLabel
            // 
            this.copiedFilesLabel.AutoSize = true;
            this.copiedFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.copiedFilesLabel.Location = new System.Drawing.Point(120, 134);
            this.copiedFilesLabel.Name = "copiedFilesLabel";
            this.copiedFilesLabel.Size = new System.Drawing.Size(185, 26);
            this.copiedFilesLabel.TabIndex = 5;
            this.copiedFilesLabel.Text = "666 out of 666 666\r\n128.1 mbytes out of 546 321.5 gbytes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::DeeMirror.Properties.Resources.delete224;
            this.pictureBox2.Location = new System.Drawing.Point(397, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(435, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Files:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(58, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Files:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(58, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "To be copied:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(435, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "To be deleted:";
            // 
            // SimulationResultDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CancelButton = this.abortButton;
            this.ClientSize = new System.Drawing.Size(746, 429);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deletedFilesLabel);
            this.Controls.Add(this.copiedFilesLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.deletedFoldersLabel);
            this.Controls.Add(this.copiedFoldersLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(729, 296);
            this.Name = "SimulationResultDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pending changes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label copiedFoldersLabel;
		private System.Windows.Forms.Label deletedFoldersLabel;
		private System.Windows.Forms.Button abortButton;
		private System.Windows.Forms.Button proceedButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label deletedFilesLabel;
		private System.Windows.Forms.Label copiedFilesLabel;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}