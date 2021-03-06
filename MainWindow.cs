﻿using System;
using System.Windows.Forms;
using DaysCounter.Properties;
using MijoSoftware.AssemblyInformation;

namespace DaysCounter
{
	/// <summary>
	/// Show the main window of the application
	/// </summary>
	public partial class MainWindow : Form
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
		private void ShowCopiedToClipboardMessage()
		{
		MessageBox.Show(
				text: Resources.copiedToClipboard,
				caption: string.Empty,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information,
				defaultButton: MessageBoxDefaultButton.Button1);
		}

		private void ApplicationStayNotOnTop()
		{
			TopMost = false;
			toolStripMenuItemStayNotOnTop.Checked = !TopMost;
			toolStripMenuItemStayOnTop.Checked = TopMost;
			toolStripSplitButtonStayOnTop.Image = Resources.application;
			toolStripSplitButtonStayOnTop.Text = Resources.stayNotOnTop;
		}

		private void ApplicationStayOnTop()
		{
			TopMost = true;
			toolStripMenuItemStayNotOnTop.Checked = !TopMost;
			toolStripMenuItemStayOnTop.Checked = TopMost;
			toolStripSplitButtonStayOnTop.Image = Resources.application_blue;
			toolStripSplitButtonStayOnTop.Text = Resources.stayOnTop;
		}

		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="text">text with some information</param>
		private void SetStatusbarText(string text)
		{
			labelInformation.Enabled = !string.IsNullOrEmpty(value: text);
			labelInformation.Text = text;
		}

		/// <summary>
		/// Count the days from a date to another date
		/// </summary>
		private void CountDaysFromDateToDate()
		{
			double days = (dateTimePickerBegin.Value - dateTimePickerEnd.Value).TotalDays;
			if (days < 0)
			{
				days *= -1;
			}
			labelDaysCounted.Text = $"They are {Math.Truncate(d: days)} days.";
		}

		/// <summary>
		/// Count the days from a date with a specific span in days
		/// </summary>
		private void CountDaysFromDaySpan() => dateTimePickerDateOut.Value = dateTimePickerDateIn.Value.AddDays(value: (double)numericUpDownDays.Value);

		/// <summary>
		/// Count the days from a date until now
		/// </summary>
		private void CountDaysOfLife()
		{
			double daysOld = (DateTime.Now - dateTimePickerDateOfTheBirth.Value).TotalDays;
			if (daysOld < 0)
			{
				daysOld *= -1;
			}
			labelDaysOld.Text = $"You are {Math.Truncate(d: daysOld)} days old.";
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public MainWindow()
		{
			InitializeComponent();
			ClearStatusbar_Leave(sender: null, e: null);
			CountDaysFromDateToDate();
			CountDaysFromDaySpan();
			CountDaysOfLife();
			labelTitle.Text = $"{AssemblyInfo.AssemblyProduct} {AssemblyInfo.AssemblyVersion}";
			labelDescription.Text = AssemblyInfo.AssemblyDescription;
			labelCopyright.Text = $"{AssemblyInfo.AssemblyCopyright} {AssemblyInfo.AssemblyCompany}";
		}

		/// <summary>
		/// Switch the input method of the beginning date
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSwitchDateBegin_Click(object sender, EventArgs e) => dateTimePickerBegin.ShowUpDown = !dateTimePickerBegin.ShowUpDown;

		/// <summary>
		/// Switch the input method of the ending date
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSwitchDateEnd_Click(object sender, EventArgs e) => dateTimePickerEnd.ShowUpDown = !dateTimePickerEnd.ShowUpDown;

		/// <summary>
		/// Switch the input method of the date with span
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSwitchDateDays_Click(object sender, EventArgs e) => dateTimePickerDateIn.ShowUpDown = !dateTimePickerDateIn.ShowUpDown;

		/// <summary>
		/// Switch the input method of the date of the birth
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSwitchDateOfTheBirth_Click(object sender, EventArgs e) => dateTimePickerDateOfTheBirth.ShowUpDown = !dateTimePickerDateOfTheBirth.ShowUpDown;

		/// <summary>
		/// Update the value of the beginning date
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void DateTimePickerBegin_ValueChanged(object sender, EventArgs e) => CountDaysFromDateToDate();

		/// <summary>
		/// Update the value of the ending date
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void DateTimePickerEnd_ValueChanged(object sender, EventArgs e) => CountDaysFromDateToDate();

		/// <summary>
		/// Update the value of the date with span
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void DateTimePickerDateIn_ValueChanged(object sender, EventArgs e) => CountDaysFromDaySpan();

		/// <summary>
		/// Update the value of the span in days
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void NumericUpDownDays_ValueChanged(object sender, EventArgs e) => CountDaysFromDaySpan();

		/// <summary>
		/// Update the value of the date of the birth
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void DateTimePickerDateOfTheBirth_ValueChanged(object sender, EventArgs e) => CountDaysOfLife();

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			string text = string.Empty;
			if (sender is Control control)
			{
				text = control.AccessibleDescription;
			}
			else if (sender is ToolStripSplitButton toolStripSplitButton)
			{
				text = toolStripSplitButton.AccessibleDescription;
			}
			else if (sender is ToolStripButton toolStripButton)
			{
				text = toolStripButton.AccessibleDescription;
			}
			else if (sender is ToolStripLabel toolStripLabel)
			{
				text = toolStripLabel.AccessibleDescription;
			}
			else if (sender is ToolStripMenuItem toolStripMenuItem)
			{
				text = toolStripMenuItem.AccessibleDescription;
			}
			SetStatusbarText(text: text);
		}

		/// <summary>
		/// Clear the information text of the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		private void ToolStripMenuItemStayNotOnTop_Click(object sender, EventArgs e) => ApplicationStayNotOnTop();

		private void ToolStripMenuItemStayOnTop_Click(object sender, EventArgs e) => ApplicationStayOnTop();

		private void ToolStripSplitButtonStayOnTop_ButtonClick(object sender, EventArgs e)
		{
			if (TopMost)
			{
				ApplicationStayNotOnTop();
			}
			else
			{
				ApplicationStayOnTop();
			}
		}

		private void ButtonInsertDateTodayBegin_Click(object sender, EventArgs e) => dateTimePickerBegin.Value = DateTime.Now;

		private void ButtonInsertDateTodayEnd_Click(object sender, EventArgs e) => dateTimePickerEnd.Value = DateTime.Now;

		private void ButtonInsertDateIn_Click(object sender, EventArgs e) => dateTimePickerDateIn.Value = DateTime.Now;

		private void ButtonCopyDateBegin_Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(data: dateTimePickerBegin.Value.ToLongDateString());
			ShowCopiedToClipboardMessage();
		}

		private void ButtonCopyDateEnd_Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(data: dateTimePickerEnd.Value.ToLongDateString());
			ShowCopiedToClipboardMessage();
		}

		private void ButtonCopyDateIn_Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(data: dateTimePickerDateIn.Value.ToLongDateString());
			ShowCopiedToClipboardMessage();
		}

		private void ButtonCopyDateOut_Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(data: dateTimePickerDateOut.Value.ToLongDateString());
			ShowCopiedToClipboardMessage();
		}

		private void ButtonCopyDateOfTheBirth_Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(data: dateTimePickerDateOfTheBirth.Value.ToLongDateString());
			ShowCopiedToClipboardMessage();
		}

		private void ToolStripMenuItemSwitch_Click(object sender, EventArgs e)
		{
		}

		private void ToolStripMenuItemCopyDateToClipboard_Click(object sender, EventArgs e)
		{
		}

		private void ToolStripMenuItemInsertDateToday_Click(object sender, EventArgs e)
		{
		}
	}
}