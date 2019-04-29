﻿/*
 * Copyright (c) Martin Kinkelin
 *
 * See the "License.txt" file in the root directory for infos
 * about permitted and prohibited uses of this code.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeeMirror.GUI
{
	public partial class MirrorOperationControl : UserControl
	{
		#region Status class
		private class Status : IMirrorOperationStatus
		{
			private readonly MirrorOperationControl _control;

			public bool IsAbortingSupported { set { _control.button2_Abort.Enabled = value; } }

			public double Percentage
			{
				set
				{
					_control.progressBar.Value = (int)(value * 10);
					_control.progressBar.Visible = true;
				}
			}

			public Status(MirrorOperationControl control)
			{
				_control = control;
			}

			public void OnEnterNewStage(string stage, string text)
			{
				_control.statusLabel.Text = (stage == "Mirroring..." ? stage : text);
			}
		}
		#endregion

		private readonly MirrorOperation _operation;

		public bool IsRunning { get { return _operation.HasStarted && !_operation.IsFinished; } }

		public event EventHandler Aborted;

		public MirrorOperationControl(MirrorOperation operation)
		{
			if (operation == null)
				throw new ArgumentNullException("operation");

			InitializeComponent();

			_operation = operation;

			label2.Text = string.Format("{0}\n{1}", _operation.SourceFolder, _operation.DestinationFolder);
			simulateCheckBox.Checked = Properties.Settings.Default.SimulateFirst;

			this.SetStyle(ControlStyles.ResizeRedraw, true);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			label1.Font = label3.Font = new Font(Font, FontStyle.Bold);

			int toolstripButtonHeight = (this.Height - button1_Start.Margin.Vertical - button2_Abort.Margin.Vertical) / 2;

			button1_Start.Height = button2_Abort.Height = toolstripButtonHeight;
		}

		public void Start()
		{
			button1_Start.Enabled = false;
			simulateCheckBox.Visible = false;

			if (!_operation.HasStarted)
			{
				_operation.Start(new Status(this), simulateFirst: simulateCheckBox.Checked);
				label2.Text = string.Format("{0}\n{1}", _operation.SourceFolder, _operation.DestinationFolder);
			}
		}

		public void Abort()
		{
			button2_Abort.Enabled = false;
			_operation.Abort();

			if (Aborted != null)
				Aborted(this, EventArgs.Empty);
		}

		private void button1_Start_Click(object sender, EventArgs e)
		{
			Start();
		}

		private void button2_Abort_Click(object sender, EventArgs e)
		{
			Abort();
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			var rectangle = ClientRectangle;

			using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, 0), new Point(0, rectangle.Height), Color.White, Color.LightGray))
				e.Graphics.FillRectangle(brush, e.ClipRectangle);
		}
	}
}
