using System;
using System.Windows.Forms;

namespace Days_Counter
{
	public partial class MainWindow : Form
	{
		private void SetStatusbar(string text)
		{
			labelInformation.Enabled = text == "" ? false : true;
			labelInformation.Text = text;
		}

		private void CountDaysFromDateToDate()
		{
			double days = (dateTimePickerBegin.Value - dateTimePickerEnd.Value).TotalDays;
			if (days < 0)
			{
				days *= -1;
			}
			labelDaysCounted.Text = Math.Truncate(d: days).ToString();
		}

		private void CountDaysFromDaySpan() => dateTimePickerDateOut.Value = dateTimePickerDateIn.Value.AddDays(value: (double)numericUpDownDays.Value);

		public MainWindow()
		{
			InitializeComponent();
			ClearStatusbar_Leave(sender: null, e: null);
			CountDaysFromDateToDate();
			CountDaysFromDaySpan();
			labelTitle.Text = new AssemblyInfo().GetAssemblyProduct() + " " + new AssemblyInfo().GetAssemblyVersion();
			labelDescription.Text = new AssemblyInfo().GetAssemblyDescription();
			labelCopyright.Text = new AssemblyInfo().GetAssemblyCopyright() + " " + new AssemblyInfo().GetAssemblyCompany();
		}

		private void ButtonSwitchDateBegin_Click(object sender, EventArgs e) => dateTimePickerBegin.ShowUpDown = !dateTimePickerBegin.ShowUpDown;

		private void ButtonSwitchDateEnd_Click(object sender, EventArgs e) => dateTimePickerEnd.ShowUpDown = !dateTimePickerEnd.ShowUpDown;

		private void ButtonSwitchDateDays_Click(object sender, EventArgs e) => dateTimePickerDateIn.ShowUpDown = !dateTimePickerDateIn.ShowUpDown;

		private void DateTimePickerBegin_ValueChanged(object sender, EventArgs e) => CountDaysFromDateToDate();

		private void DateTimePickerEnd_ValueChanged(object sender, EventArgs e) => CountDaysFromDateToDate();

		private void DateTimePickerDateIn_ValueChanged(object sender, EventArgs e) => CountDaysFromDaySpan();

		private void NumericUpDownDays_ValueChanged(object sender, EventArgs e) => CountDaysFromDaySpan();

		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			if (sender is TextBox)
			{
				SetStatusbar(text: ((TextBox)sender).AccessibleDescription);
			}
			else if (sender is Button)
			{
				SetStatusbar(text: ((Button)sender).AccessibleDescription);
			}
			else if (sender is RadioButton)
			{
				SetStatusbar(text: ((RadioButton)sender).AccessibleDescription);
			}
			else if (sender is CheckBox)
			{
				SetStatusbar(text: ((CheckBox)sender).AccessibleDescription);
			}
			else if (sender is DateTimePicker)
			{
				SetStatusbar(text: ((DateTimePicker)sender).AccessibleDescription);
			}
			else if (sender is Label)
			{
				SetStatusbar(text: ((Label)sender).AccessibleDescription);
			}
			else if (sender is PictureBox)
			{
				SetStatusbar(text: ((PictureBox)sender).AccessibleDescription);
			}
			else if (sender is ToolStripButton)
			{
				SetStatusbar(text: ((ToolStripButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripMenuItem)
			{
				SetStatusbar(text: ((ToolStripMenuItem)sender).AccessibleDescription);
			}
			else if (sender is ToolStripLabel)
			{
				SetStatusbar(text: ((ToolStripLabel)sender).AccessibleDescription);
			}
			else if (sender is ToolStripComboBox)
			{
				SetStatusbar(text: ((ToolStripComboBox)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDown)
			{
				SetStatusbar(text: ((ToolStripDropDown)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownButton)
			{
				SetStatusbar(text: ((ToolStripDropDownButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownItem)
			{
				SetStatusbar(text: ((ToolStripDropDownItem)sender).AccessibleDescription);
			}
			else if (sender is ToolStripDropDownMenu)
			{
				SetStatusbar(text: ((ToolStripDropDownMenu)sender).AccessibleDescription);
			}
			else if (sender is ToolStripProgressBar)
			{
				SetStatusbar(text: ((ToolStripProgressBar)sender).AccessibleDescription);
			}
			else if (sender is ToolStripSplitButton)
			{
				SetStatusbar(text: ((ToolStripSplitButton)sender).AccessibleDescription);
			}
			else if (sender is ToolStripSeparator)
			{
				SetStatusbar(text: ((ToolStripSeparator)sender).AccessibleDescription);
			}
			else if (sender is ToolStripStatusLabel)
			{
				SetStatusbar(text: ((ToolStripStatusLabel)sender).AccessibleDescription);
			}
			else if (sender is ToolStripTextBox)
			{
				SetStatusbar(text: ((ToolStripTextBox)sender).AccessibleDescription);
			}
		}

		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbar(text: "");
	}
}
