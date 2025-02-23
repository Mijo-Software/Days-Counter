using System.Diagnostics;
using DaysCounter.Properties;
using NLog;

namespace DaysCounter
{
	/// <summary>
	/// Show the main window of the application
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
	public partial class MainForm : Form
	{
		/// <summary>
		/// Logger instance for logging messages and exceptions
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		#region Helpers

		/// <summary>
		/// Handles exceptions by logging the error and showing a message box
		/// </summary>
		/// <param name="ex">The exception that occurred</param>
		/// <param name="message">The message to log and display</param>
		/// <param name="sender">The source of the event that caused the exception</param>
		/// <param name="e">The event data associated with the exception</param>
		private static void HandleException(Exception ex, string message, object? sender = null, EventArgs? e = null)
		{
			//DateTime date = DateTime.TryParse("2021-09-01", out DateTime parsedDate) ? parsedDate : DateTime.Now;
			/*
			DateTime s;
			if (DateTime.TryParse("2021-09-01", result: out DateTime date))
			{
				s = date;
			}
			else
			{
				s = DateTime.Now;
			}
			*/

			// Implement logging logic here (e.g., log to a file or monitoring system)
			string msg = $"Error: {ex}\nMessage: {ex.Message}\nStackTrace: {ex.StackTrace}\nSender: {sender}, EventArgs: {e}";
			Debug.WriteLine(value: msg);
			Console.WriteLine(value: msg);
			Logger.Error(exception: ex, message: msg);
			_ = MessageBox.Show(text: message, caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

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
		/// Count the days since the start of the year until now
		/// </summary>
		private void CountDaysOfYear()
		{
			labelDaysOfYearPassed.Text = $"It has been {dateTimePickerDaysOfYear.Value.DayOfYear} days since the start of this year.";
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

		/// <summary>
		/// Copies the specified text to the clipboard and displays a confirmation message.
		/// </summary>
		/// <param name="text">The text to be copied.</param>
		private static void CopyToClipboard(string text)
		{
			try
			{
				Clipboard.SetText(text: text);
				_ = MessageBox.Show(text: "Copied to clipboard", caption: "Information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while coping to clipboard.");
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Constructor
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
			ClearStatusbar_Leave(sender: null, e: null);
			CountDaysFromDateToDate();
			CountDaysFromDaySpan();
			CountDaysOfLife();
			CountDaysOfYear();
			labelTitle.Text = $"{AssemblyInfo.AssemblyProduct} {AssemblyInfo.AssemblyVersion}";
			labelDescription.Text = AssemblyInfo.AssemblyDescription;
			labelCopyright.Text = $"{AssemblyInfo.AssemblyCopyright}";
		}

		#endregion

		#region Click event handlers

		/// <summary>
		/// Switch the input method of the beginning date
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void ButtonSwitchDateBegin_Click(object sender, EventArgs e) => dateTimePickerBegin.ShowUpDown = !dateTimePickerBegin.ShowUpDown;

		/// <summary>
		/// Switch the input method of the ending date
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void ButtonSwitchDateEnd_Click(object sender, EventArgs e) => dateTimePickerEnd.ShowUpDown = !dateTimePickerEnd.ShowUpDown;

		/// <summary>
		/// Switch the input method of the date with span
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void ButtonSwitchDateDays_Click(object sender, EventArgs e) => dateTimePickerDateIn.ShowUpDown = !dateTimePickerDateIn.ShowUpDown;

		/// <summary>
		/// Switch the input method of the date of the birth
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void ButtonDateOfTheBirth_Click(object sender, EventArgs e) => dateTimePickerDateOfTheBirth.ShowUpDown = !dateTimePickerDateOfTheBirth.ShowUpDown;

		/// <summary>
		/// Switch the input method of the days of the years
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void ButtonDaysOfYear_Click(object sender, EventArgs e) => dateTimePickerDaysOfYear.ShowUpDown = !dateTimePickerDaysOfYear.ShowUpDown;

		/// <summary>
		/// Don't set the application on top
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void ToolStripMenuItemStayNotOnTop_Click(object sender, EventArgs e) => ApplicationStayNotOnTop();

		/// <summary>
		/// Set the application on top
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void ToolStripMenuItemStayOnTop_Click(object sender, EventArgs e) => ApplicationStayOnTop();

		/// <summary>
		/// Copies the counted days between two dates to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonDateToDateCopyToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: labelDaysCounted.Text);

		/// <summary>
		/// Copies the calculated date from a specific span of days to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonDaysOfSpanCopyToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: dateTimePickerDateOut.Value.ToShortDateString());

		/// <summary>
		/// Copies the calculated days of life to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonDaysOfLifeClopyToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: labelDaysOld.Text);

		/// <summary>
		/// Copies the calculated days of the year to the clipboard.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonDaysOfYearClopyToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: labelDaysOfYearPassed.Text);

		#endregion

		#region ButtonClick event handlers

		/// <summary>
		/// (Don't) set the application on top
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
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
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void DateTimePickerBegin_ValueChanged(object sender, EventArgs e) => CountDaysFromDateToDate();

		/// <summary>
		/// Update the value of the ending date
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void DateTimePickerEnd_ValueChanged(object sender, EventArgs e) => CountDaysFromDateToDate();

		/// <summary>
		/// Update the value of the date with span
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void DateTimePickerDateIn_ValueChanged(object sender, EventArgs e) => CountDaysFromDaySpan();

		/// <summary>
		/// Update the value of the span in days
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void NumericUpDownDays_ValueChanged(object sender, EventArgs e) => CountDaysFromDaySpan();

		/// <summary>
		/// Update the value of the date of the birth
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void DateTimePickerDateOfTheBirth_ValueChanged(object sender, EventArgs e) => CountDaysOfLife();

		/// <summary>
		/// Update the value of the days of the years
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void DateTimePickerDaysOfYear_ValueChanged(object sender, EventArgs e) => CountDaysOfYear();

		#endregion

		#region Enter event handlers

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			try
			{
				if (sender is Control { AccessibleDescription: { } } control)
				{
					SetStatusbarText(text: control.AccessibleDescription);
				}
				else if (sender is ToolStripMenuItem { AccessibleDescription: { } } control2)
				{
					SetStatusbarText(text: control2.AccessibleDescription);
				}
				else if (sender is ToolStripStatusLabel { AccessibleDescription: { } } control3)
				{
					SetStatusbarText(text: control3.AccessibleDescription);
				}
				else if (sender is ToolStripButton { AccessibleDescription: { } } control4)
				{
					SetStatusbarText(text: control4.AccessibleDescription);
				}
				else if (sender is ToolStripDropDownButton { AccessibleDescription: { } } control5)
				{
					SetStatusbarText(text: control5.AccessibleDescription);
				}
				else if (sender is ToolStripSplitButton { AccessibleDescription: { } } control6)
				{
					SetStatusbarText(text: control6.AccessibleDescription);
				}
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while setting the status bar text.", sender: sender, e: e);
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Clear the information text of the status bar
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void ClearStatusbar_Leave(object? sender, EventArgs? e) => SetStatusbarText(text: string.Empty);

		#endregion

		#region KeyDown event handlers

		/// <summary>
		/// Handles the KeyDown event of the MainForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void MainForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		#endregion
	}
}