namespace DeeMirror.GUI
{
	partial class ExcludedItemsControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.wildcardTextBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.removeButton = new System.Windows.Forms.Button();
            this.addWildcardButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.browseButton = new System.Windows.Forms.Button();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // wildcardTextBox
            // 
            this.wildcardTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wildcardTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.wildcardTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wildcardTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.wildcardTextBox.Location = new System.Drawing.Point(7, 123);
            this.wildcardTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.wildcardTextBox.Name = "wildcardTextBox";
            this.wildcardTextBox.Size = new System.Drawing.Size(119, 18);
            this.wildcardTextBox.TabIndex = 2;
            this.wildcardTextBox.TextChanged += new System.EventHandler(this.wildcardTextBox_TextChanged);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox.IntegralHeight = false;
            this.listBox.ItemHeight = 17;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox.Size = new System.Drawing.Size(374, 187);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_KeyDown);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.removeButton.Enabled = false;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.removeButton.Image = global::DeeMirror.Properties.Resources.delete2;
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.Location = new System.Drawing.Point(6, 38);
            this.removeButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Padding = new System.Windows.Forms.Padding(10, 0, 23, 0);
            this.removeButton.Size = new System.Drawing.Size(120, 30);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.removeButton, "Remove the selected item(s) from the list.");
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addWildcardButton
            // 
            this.addWildcardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addWildcardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.addWildcardButton.Enabled = false;
            this.addWildcardButton.FlatAppearance.BorderSize = 0;
            this.addWildcardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWildcardButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addWildcardButton.Image = global::DeeMirror.Properties.Resources.document_find;
            this.addWildcardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addWildcardButton.Location = new System.Drawing.Point(6, 157);
            this.addWildcardButton.Margin = new System.Windows.Forms.Padding(0);
            this.addWildcardButton.Name = "addWildcardButton";
            this.addWildcardButton.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.addWildcardButton.Size = new System.Drawing.Size(120, 30);
            this.addWildcardButton.TabIndex = 3;
            this.addWildcardButton.Text = "Add wildcard";
            this.addWildcardButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addWildcardButton.UseVisualStyleBackColor = false;
            this.addWildcardButton.Click += new System.EventHandler(this.addWildcardButton_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Please select a subfolder to be excluded with all of its contents.";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.browseButton);
            this.rightPanel.Controls.Add(this.removeButton);
            this.rightPanel.Controls.Add(this.wildcardTextBox);
            this.rightPanel.Controls.Add(this.addWildcardButton);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(374, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(126, 187);
            this.rightPanel.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.browseButton.FlatAppearance.BorderSize = 0;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.browseButton.Image = global::DeeMirror.Properties.Resources.folder_view;
            this.browseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseButton.Location = new System.Drawing.Point(6, 0);
            this.browseButton.Margin = new System.Windows.Forms.Padding(0);
            this.browseButton.Name = "browseButton";
            this.browseButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.browseButton.Size = new System.Drawing.Size(120, 30);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse...";
            this.browseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // ExcludedItemsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.rightPanel);
            this.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExcludedItemsControl";
            this.Size = new System.Drawing.Size(500, 187);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addWildcardButton;
		private System.Windows.Forms.TextBox wildcardTextBox;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Panel rightPanel;
	}
}
