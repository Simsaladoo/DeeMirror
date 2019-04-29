namespace DeeMirror.GUI
{
	partial class MirrorOperationControl
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.simulateCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2_Abort = new System.Windows.Forms.Button();
            this.button1_Start = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(48, 37);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(330, 6);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.simulateCheckBox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.progressBar);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.statusLabel);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Microsoft NeoGothic", 7F);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(439, 70);
            this.mainPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(44, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "{0}\r\n{1}";
            // 
            // simulateCheckBox
            // 
            this.simulateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simulateCheckBox.AutoSize = true;
            this.simulateCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.simulateCheckBox.Font = new System.Drawing.Font("Microsoft NeoGothic", 8F);
            this.simulateCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.simulateCheckBox.Location = new System.Drawing.Point(285, 48);
            this.simulateCheckBox.Name = "simulateCheckBox";
            this.simulateCheckBox.Size = new System.Drawing.Size(91, 19);
            this.simulateCheckBox.TabIndex = 4;
            this.simulateCheckBox.Text = "Simulate first";
            this.simulateCheckBox.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft NeoGothic", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:\r\nTo:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft NeoGothic", 8F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft NeoGothic", 8F);
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.statusLabel.Location = new System.Drawing.Point(50, 46);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(331, 24);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Pending...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2_Abort);
            this.panel1.Controls.Add(this.button1_Start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(384, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 70);
            this.panel1.TabIndex = 2;
            // 
            // button2_Abort
            // 
            this.button2_Abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2_Abort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button2_Abort.FlatAppearance.BorderSize = 0;
            this.button2_Abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_Abort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2_Abort.Location = new System.Drawing.Point(0, 35);
            this.button2_Abort.Margin = new System.Windows.Forms.Padding(0);
            this.button2_Abort.Name = "button2_Abort";
            this.button2_Abort.Size = new System.Drawing.Size(55, 35);
            this.button2_Abort.TabIndex = 3;
            this.button2_Abort.Text = "Abort";
            this.button2_Abort.UseVisualStyleBackColor = false;
            this.button2_Abort.Click += new System.EventHandler(this.button2_Abort_Click);
            // 
            // button1_Start
            // 
            this.button1_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1_Start.FlatAppearance.BorderSize = 0;
            this.button1_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1_Start.Location = new System.Drawing.Point(0, 0);
            this.button1_Start.Margin = new System.Windows.Forms.Padding(0);
            this.button1_Start.Name = "button1_Start";
            this.button1_Start.Size = new System.Drawing.Size(55, 35);
            this.button1_Start.TabIndex = 2;
            this.button1_Start.Text = "Start";
            this.button1_Start.UseVisualStyleBackColor = false;
            this.button1_Start.Click += new System.EventHandler(this.button1_Start_Click);
            // 
            // MirrorOperationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.mainPanel);
            this.Name = "MirrorOperationControl";
            this.Size = new System.Drawing.Size(439, 70);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox simulateCheckBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1_Start;
        private System.Windows.Forms.Button button2_Abort;
    }
}
