using System.Diagnostics;
using DaysCounter.Properties;
using MijoSoftware.AssemblyInformation;

namespace DaysCounter
{
	/// <summary>
	/// Show the main window of the application
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
	public partial class MainForm : Form
	{
		#region Helpers
		/// <summary>
		/// Get the debugger display
		/// </summary>
		/// <returns>debugger display</returns>
		private string GetDebuggerDisplay() => ToString();

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
		/// Don't set the application on top
		/// </summary>
		private void ApplicationStayNotOnTop()
		{
			TopMost = false;
			toolStripMenuItemStayNotOnTop.Checked = !TopMost;
			toolStripMenuItemStayOnTop.Checked = TopMost;
			toolStripSplitButtonStayOnTop.Image = Resources.application;
			toolStripSplitButtonStayOnTop.Text = Resources.stayNotOnTop;
		}

		/// <summary>
		/// Set the application on top
		/// </summary>
		private void ApplicationStayOnTop()
		{
			TopMost = true;
			toolStripMenuItemStayNotOnTop.Checked = !TopMost;
			toolStripMenuItemStayOnTop.Checked = TopMost;
			toolStripSplitButtonStayOnTop.Image = Resources.application_blue;
			toolStripSplitButtonStayOnTop.Text = Resources.stayOnTop;
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Constructor
		/// </summary>
		public MainForm()
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

		#endregion

		#region Click event handlers

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
		private void ButtonDateOfTheBirth_Click(object sender, EventArgs e) => dateTimePickerDateOfTheBirth.ShowUpDown = !dateTimePickerDateOfTheBirth.ShowUpDown;

		/// <summary>
		/// Don't set the application on top
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemStayNotOnTop_Click(object sender, EventArgs e) => ApplicationStayNotOnTop();

		/// <summary>
		/// Set the application on top
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemStayOnTop_Click(object sender, EventArgs e) => ApplicationStayOnTop();

		#endregion

		#region ButtonClick event handlers

		/// <summary>
		/// (Don't) set the application on top
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
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

		#endregion

		#region ValueChanged event handlers

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

		#endregion

		#region Enter event handlers

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			switch (sender)
			{
				case TextBox textBox: SetStatusbarText(text: textBox.AccessibleDescription); break;
				case Button button: SetStatusbarText(text: button.AccessibleDescription); break;
				case RadioButton radioButton: SetStatusbarText(text: radioButton.AccessibleDescription); break;
				case CheckBox checkBox: SetStatusbarText(text: checkBox.AccessibleDescription); break;
				case DateTimePicker dateTimePicker: SetStatusbarText(text: dateTimePicker.AccessibleDescription); break;
				case Label label: SetStatusbarText(text: label.AccessibleDescription); break;
				case PictureBox pictureBox: SetStatusbarText(text: pictureBox.AccessibleDescription); break;
				case CheckedListBox checkedListBox: SetStatusbarText(text: checkedListBox.AccessibleDescription); break;
				case ComboBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case DataGridView view: SetStatusbarText(text: view.AccessibleDescription); break;
				case GroupBox group: SetStatusbarText(text: group.AccessibleDescription); break;
				case ListBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case ListView view: SetStatusbarText(text: view.AccessibleDescription); break;
				case MaskedTextBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case NumericUpDown numericUpDown: SetStatusbarText(text: numericUpDown.AccessibleDescription); break;
				case MonthCalendar monthCalendar: SetStatusbarText(text: monthCalendar.AccessibleDescription); break;
				case PropertyGrid propertyGrid: SetStatusbarText(text: propertyGrid.AccessibleDescription); break;
				case RichTextBox richTextBox: SetStatusbarText(text: richTextBox.AccessibleDescription); break;
				case ScrollBar scrollBar: SetStatusbarText(text: scrollBar.AccessibleDescription); break;
				case TrackBar trackBar: SetStatusbarText(text: trackBar.AccessibleDescription); break;
				case WebBrowser webBrowser: SetStatusbarText(text: webBrowser.AccessibleDescription); break;
				case DomainUpDown domainUpDown: SetStatusbarText(text: domainUpDown.AccessibleDescription); break;
				case ToolStripButton toolStripButton: SetStatusbarText(text: toolStripButton.AccessibleDescription); break;
				case ToolStripMenuItem toolStripMenuItem: SetStatusbarText(text: toolStripMenuItem.AccessibleDescription); break;
				case ToolStripLabel toolStripLabel: SetStatusbarText(text: toolStripLabel.AccessibleDescription); break;
				case ToolStripComboBox toolStripComboBox: SetStatusbarText(text: toolStripComboBox.AccessibleDescription); break;
				case ToolStripDropDown toolStripDropDown: SetStatusbarText(text: toolStripDropDown.AccessibleDescription); break;
				case ToolStripDropDownButton toolStripDropDownButton: SetStatusbarText(text: toolStripDropDownButton.AccessibleDescription); break;
				case ToolStripDropDownItem toolStripDropDownItem: SetStatusbarText(text: toolStripDropDownItem.AccessibleDescription); break;
				case ToolStripProgressBar progressBar: SetStatusbarText(text: progressBar.AccessibleDescription); break;
				case ToolStripSeparator toolStripSeparator: SetStatusbarText(text: toolStripSeparator.AccessibleDescription); break;
				case ToolStripTextBox toolStripTextBox: SetStatusbarText(text: toolStripTextBox.AccessibleDescription); break;
				default: return;
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Clear the information text of the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		#endregion
	}
}