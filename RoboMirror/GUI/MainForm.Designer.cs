namespace DeeMirror.GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.historyButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.restoreButton = new System.Windows.Forms.Button();
            this.backupButton = new System.Windows.Forms.Button();
            this.mirrorOperationsQueueControl = new DeeMirror.GUI.MirrorOperationsQueueControl();
            this.label2 = new System.Windows.Forms.Label();
            this.queuePanel = new System.Windows.Forms.Panel();
            this.shutdownWhenDoneCheckBox = new System.Windows.Forms.CheckBox();
            this.mainPanel.SuspendLayout();
            this.queuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "data_copy.png");
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Control;
            // 
            // historyButton
            // 
            this.historyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.historyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.historyButton.Enabled = false;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.historyButton.Image = global::DeeMirror.Properties.Resources.history;
            this.historyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyButton.Location = new System.Drawing.Point(1119, 98);
            this.historyButton.Margin = new System.Windows.Forms.Padding(2);
            this.historyButton.Name = "historyButton";
            this.historyButton.Padding = new System.Windows.Forms.Padding(8, 0, 17, 0);
            this.historyButton.Size = new System.Drawing.Size(100, 24);
            this.historyButton.TabIndex = 4;
            this.historyButton.Text = "History...";
            this.historyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.historyButton, "Display the history of the selected mirror task.");
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.scheduleButton.Enabled = false;
            this.scheduleButton.FlatAppearance.BorderSize = 0;
            this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.scheduleButton.Image = global::DeeMirror.Properties.Resources.clock;
            this.scheduleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scheduleButton.Location = new System.Drawing.Point(1119, 136);
            this.scheduleButton.Margin = new System.Windows.Forms.Padding(2);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.scheduleButton.Size = new System.Drawing.Size(100, 24);
            this.scheduleButton.TabIndex = 5;
            this.scheduleButton.Text = "Schedule...";
            this.scheduleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.scheduleButton, "Schedule the selected mirror task.");
            this.scheduleButton.UseVisualStyleBackColor = false;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.addButton.Image = global::DeeMirror.Properties.Resources.data_copy_add;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(1119, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.addButton.Size = new System.Drawing.Size(100, 24);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add task...";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.addButton, "Add a new mirror task.");
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.editButton.Enabled = false;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.editButton.Image = global::DeeMirror.Properties.Resources.data_copy;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(1119, 28);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Padding = new System.Windows.Forms.Padding(8, 0, 28, 0);
            this.editButton.Size = new System.Drawing.Size(100, 24);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit...";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.editButton, "Edit the selected mirror task.");
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.removeButton.Enabled = false;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.removeButton.Image = global::DeeMirror.Properties.Resources.data_copy_delete;
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.Location = new System.Drawing.Point(1119, 58);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Padding = new System.Windows.Forms.Padding(8, 0, 20, 0);
            this.removeButton.Size = new System.Drawing.Size(100, 24);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.removeButton, "Remove the selected mirror task.");
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPanel.Controls.Add(this.historyButton);
            this.mainPanel.Controls.Add(this.scheduleButton);
            this.mainPanel.Controls.Add(this.listView1);
            this.mainPanel.Controls.Add(this.restoreButton);
            this.mainPanel.Controls.Add(this.addButton);
            this.mainPanel.Controls.Add(this.backupButton);
            this.mainPanel.Controls.Add(this.editButton);
            this.mainPanel.Controls.Add(this.removeButton);
            this.mainPanel.Location = new System.Drawing.Point(12, 19);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1220, 480);
            this.mainPanel.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ForeColor = System.Drawing.SystemColors.Control;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 1);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1115, 423);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Source";
            this.columnHeader2.Width = 450;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Target";
            this.columnHeader3.Width = 450;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Last successful operation";
            this.columnHeader4.Width = 179;
            // 
            // restoreButton
            // 
            this.restoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.restoreButton.Enabled = false;
            this.restoreButton.FlatAppearance.BorderSize = 0;
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.restoreButton.ForeColor = System.Drawing.SystemColors.Control;
            this.restoreButton.Image = global::DeeMirror.Properties.Resources.data_previous24;
            this.restoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restoreButton.Location = new System.Drawing.Point(995, 440);
            this.restoreButton.Margin = new System.Windows.Forms.Padding(2);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Padding = new System.Windows.Forms.Padding(17, 0, 26, 0);
            this.restoreButton.Size = new System.Drawing.Size(120, 40);
            this.restoreButton.TabIndex = 7;
            this.restoreButton.Text = "Restore";
            this.restoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.backupButton.Enabled = false;
            this.backupButton.FlatAppearance.BorderSize = 0;
            this.backupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.backupButton.Image = global::DeeMirror.Properties.Resources.data_next24;
            this.backupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupButton.Location = new System.Drawing.Point(1, 440);
            this.backupButton.Margin = new System.Windows.Forms.Padding(2);
            this.backupButton.Name = "backupButton";
            this.backupButton.Padding = new System.Windows.Forms.Padding(17, 0, 23, 0);
            this.backupButton.Size = new System.Drawing.Size(120, 40);
            this.backupButton.TabIndex = 6;
            this.backupButton.Text = "Backup";
            this.backupButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backupButton.UseVisualStyleBackColor = false;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // mirrorOperationsQueueControl
            // 
            this.mirrorOperationsQueueControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mirrorOperationsQueueControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mirrorOperationsQueueControl.ForeColor = System.Drawing.Color.DimGray;
            this.mirrorOperationsQueueControl.Location = new System.Drawing.Point(0, 22);
            this.mirrorOperationsQueueControl.Margin = new System.Windows.Forms.Padding(2);
            this.mirrorOperationsQueueControl.Name = "mirrorOperationsQueueControl";
            this.mirrorOperationsQueueControl.Size = new System.Drawing.Size(1220, 164);
            this.mirrorOperationsQueueControl.TabIndex = 1;
            this.mirrorOperationsQueueControl.AllFinished += new System.EventHandler(this.mirrorOperationsQueueControl_AllFinished);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Operations queue:";
            // 
            // queuePanel
            // 
            this.queuePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queuePanel.Controls.Add(this.shutdownWhenDoneCheckBox);
            this.queuePanel.Controls.Add(this.mirrorOperationsQueueControl);
            this.queuePanel.Controls.Add(this.label2);
            this.queuePanel.Location = new System.Drawing.Point(12, 503);
            this.queuePanel.Margin = new System.Windows.Forms.Padding(2);
            this.queuePanel.Name = "queuePanel";
            this.queuePanel.Size = new System.Drawing.Size(1220, 207);
            this.queuePanel.TabIndex = 1;
            // 
            // shutdownWhenDoneCheckBox
            // 
            this.shutdownWhenDoneCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shutdownWhenDoneCheckBox.AutoSize = true;
            this.shutdownWhenDoneCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.shutdownWhenDoneCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.shutdownWhenDoneCheckBox.Location = new System.Drawing.Point(4, 188);
            this.shutdownWhenDoneCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.shutdownWhenDoneCheckBox.Name = "shutdownWhenDoneCheckBox";
            this.shutdownWhenDoneCheckBox.Size = new System.Drawing.Size(130, 17);
            this.shutdownWhenDoneCheckBox.TabIndex = 2;
            this.shutdownWhenDoneCheckBox.Text = "Shutdown when done";
            this.shutdownWhenDoneCheckBox.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1244, 719);
            this.Controls.Add(this.queuePanel);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(531, 320);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeeMirror";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.mainPanel.ResumeLayout(false);
            this.queuePanel.ResumeLayout(false);
            this.queuePanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button backupButton;
		private System.Windows.Forms.Button restoreButton;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button scheduleButton;
		private System.Windows.Forms.Button historyButton;
		private MirrorOperationsQueueControl mirrorOperationsQueueControl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel queuePanel;
		private System.Windows.Forms.CheckBox shutdownWhenDoneCheckBox;
    }
}