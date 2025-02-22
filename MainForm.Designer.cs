namespace DaysCounter
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			imageList = new ImageList(components);
			toolTip = new ToolTip(components);
			statusStrip = new StatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolStripSplitButtonStayOnTop = new ToolStripSplitButton();
			toolStripMenuItemStayNotOnTop = new ToolStripMenuItem();
			toolStripMenuItemStayOnTop = new ToolStripMenuItem();
			labelTitle = new Label();
			labelDescription = new Label();
			labelCopyright = new Label();
			dateTimePickerDateOfTheBirth = new DateTimePicker();
			labelDateOfTheBirth = new Label();
			dateTimePickerDateIn = new DateTimePicker();
			numericUpDownDays = new NumericUpDown();
			dateTimePickerDateOut = new DateTimePicker();
			labelDateIn = new Label();
			labelDateOut = new Label();
			dateTimePickerEnd = new DateTimePicker();
			dateTimePickerBegin = new DateTimePicker();
			labelDateBegin = new Label();
			labelDateEnd = new Label();
			labelDays = new Label();
			labelDaysCounted = new Label();
			labelDaysOld = new Label();
			labelDaysSpan = new Label();
			buttonSwitchDateEnd = new Button();
			buttonSwitchDateBegin = new Button();
			buttonSwitchDateIn = new Button();
			buttonDateOfTheBirth = new Button();
			textBoxLicense = new TextBox();
			labelDaysPlusMinus = new Label();
			tabControl = new TabControl();
			tabPageDateToDate = new TabPage();
			tabPageDaySpan = new TabPage();
			tabPageDaysOfLife = new TabPage();
			tabPageDaysOfYear = new TabPage();
			labelDate = new Label();
			dateTimePickerDaysOfYear = new DateTimePicker();
			buttonDaysOfYear = new Button();
			labelDaysOfYearPassed = new Label();
			tabPageAbout = new TabPage();
			pictureBox = new PictureBox();
			tabPageLicense = new TabPage();
			BottomToolStripPanel = new ToolStripPanel();
			TopToolStripPanel = new ToolStripPanel();
			RightToolStripPanel = new ToolStripPanel();
			LeftToolStripPanel = new ToolStripPanel();
			ContentPanel = new ToolStripContentPanel();
			toolStripContainer = new ToolStripContainer();
			labelDaysOfYear = new Label();
			statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownDays).BeginInit();
			tabControl.SuspendLayout();
			tabPageDateToDate.SuspendLayout();
			tabPageDaySpan.SuspendLayout();
			tabPageDaysOfLife.SuspendLayout();
			tabPageDaysOfYear.SuspendLayout();
			tabPageAbout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			tabPageLicense.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			SuspendLayout();
			// 
			// imageList
			// 
			imageList.ColorDepth = ColorDepth.Depth8Bit;
			imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
			imageList.TransparentColor = Color.Transparent;
			imageList.Images.SetKeyName(0, "calendar-select-days.png");
			imageList.Images.SetKeyName(1, "calendar-select-days-span.png");
			imageList.Images.SetKeyName(2, "calendar-select.png");
			imageList.Images.SetKeyName(3, "calendar-day.png");
			imageList.Images.SetKeyName(4, "information-button.png");
			imageList.Images.SetKeyName(5, "script-text.png");
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Shows the statusbar with some information";
			statusStrip.AccessibleName = "Statusbar";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation, toolStripSplitButtonStayOnTop });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(413, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 0;
			statusStrip.Text = "statusStrip";
			toolTip.SetToolTip(statusStrip, "Statusbar with some information");
			statusStrip.Enter += SetStatusbar_Enter;
			statusStrip.Leave += ClearStatusbar_Leave;
			statusStrip.MouseEnter += SetStatusbar_Enter;
			statusStrip.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelInformation
			// 
			labelInformation.AccessibleDescription = "Shows some information";
			labelInformation.AccessibleName = "Information";
			labelInformation.AccessibleRole = AccessibleRole.StaticText;
			labelInformation.AutoToolTip = true;
			labelInformation.Name = "labelInformation";
			labelInformation.Size = new Size(366, 17);
			labelInformation.Spring = true;
			labelInformation.Text = "information";
			labelInformation.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// toolStripSplitButtonStayOnTop
			// 
			toolStripSplitButtonStayOnTop.AccessibleDescription = "Sets or unset the window to the top";
			toolStripSplitButtonStayOnTop.AccessibleName = "Stay on top";
			toolStripSplitButtonStayOnTop.AccessibleRole = AccessibleRole.SplitButton;
			toolStripSplitButtonStayOnTop.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripSplitButtonStayOnTop.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemStayNotOnTop, toolStripMenuItemStayOnTop });
			toolStripSplitButtonStayOnTop.Image = Properties.Resources.application;
			toolStripSplitButtonStayOnTop.ImageTransparentColor = Color.Magenta;
			toolStripSplitButtonStayOnTop.Name = "toolStripSplitButtonStayOnTop";
			toolStripSplitButtonStayOnTop.Size = new Size(32, 20);
			toolStripSplitButtonStayOnTop.Text = "Stay not on top";
			toolStripSplitButtonStayOnTop.ButtonClick += ToolStripSplitButtonStayOnTop_ButtonClick;
			toolStripSplitButtonStayOnTop.MouseEnter += SetStatusbar_Enter;
			toolStripSplitButtonStayOnTop.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemStayNotOnTop
			// 
			toolStripMenuItemStayNotOnTop.AccessibleDescription = "Unsets the window from the top";
			toolStripMenuItemStayNotOnTop.AccessibleName = "Stay on top";
			toolStripMenuItemStayNotOnTop.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemStayNotOnTop.AutoToolTip = true;
			toolStripMenuItemStayNotOnTop.Checked = true;
			toolStripMenuItemStayNotOnTop.CheckState = CheckState.Checked;
			toolStripMenuItemStayNotOnTop.Image = Properties.Resources.application;
			toolStripMenuItemStayNotOnTop.Name = "toolStripMenuItemStayNotOnTop";
			toolStripMenuItemStayNotOnTop.ShortcutKeyDisplayString = "";
			toolStripMenuItemStayNotOnTop.Size = new Size(155, 22);
			toolStripMenuItemStayNotOnTop.Text = "Stay &not on top";
			toolStripMenuItemStayNotOnTop.Click += ToolStripMenuItemStayNotOnTop_Click;
			toolStripMenuItemStayNotOnTop.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemStayNotOnTop.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemStayOnTop
			// 
			toolStripMenuItemStayOnTop.AccessibleDescription = "Sets the window to the top";
			toolStripMenuItemStayOnTop.AccessibleName = "Stay on top";
			toolStripMenuItemStayOnTop.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemStayOnTop.AutoToolTip = true;
			toolStripMenuItemStayOnTop.Image = Properties.Resources.application_blue;
			toolStripMenuItemStayOnTop.Name = "toolStripMenuItemStayOnTop";
			toolStripMenuItemStayOnTop.Size = new Size(155, 22);
			toolStripMenuItemStayOnTop.Text = "&Stay on top";
			toolStripMenuItemStayOnTop.Click += ToolStripMenuItemStayOnTop_Click;
			toolStripMenuItemStayOnTop.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemStayOnTop.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelTitle
			// 
			labelTitle.AccessibleDescription = "Shows the title and the version";
			labelTitle.AccessibleName = "Title/version";
			labelTitle.AccessibleRole = AccessibleRole.StaticText;
			labelTitle.AutoEllipsis = true;
			labelTitle.AutoSize = true;
			labelTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
			labelTitle.Location = new Point(55, 10);
			labelTitle.Margin = new Padding(4, 0, 4, 0);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(165, 30);
			labelTitle.TabIndex = 0;
			labelTitle.Text = "[Title + Version]";
			toolTip.SetToolTip(labelTitle, "Title/version");
			labelTitle.UseCompatibleTextRendering = true;
			labelTitle.Enter += SetStatusbar_Enter;
			labelTitle.Leave += ClearStatusbar_Leave;
			labelTitle.MouseEnter += SetStatusbar_Enter;
			labelTitle.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDescription
			// 
			labelDescription.AccessibleDescription = "Shows the description";
			labelDescription.AccessibleName = "Description";
			labelDescription.AccessibleRole = AccessibleRole.StaticText;
			labelDescription.AutoEllipsis = true;
			labelDescription.AutoSize = true;
			labelDescription.Location = new Point(55, 45);
			labelDescription.Margin = new Padding(4, 0, 4, 0);
			labelDescription.Name = "labelDescription";
			labelDescription.Size = new Size(74, 21);
			labelDescription.TabIndex = 1;
			labelDescription.Text = "[Description]";
			toolTip.SetToolTip(labelDescription, "Description");
			labelDescription.UseCompatibleTextRendering = true;
			labelDescription.Enter += SetStatusbar_Enter;
			labelDescription.Leave += ClearStatusbar_Leave;
			labelDescription.MouseEnter += SetStatusbar_Enter;
			labelDescription.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelCopyright
			// 
			labelCopyright.AccessibleDescription = "Shows the copyright and the company name";
			labelCopyright.AccessibleName = "Copyright/company";
			labelCopyright.AccessibleRole = AccessibleRole.StaticText;
			labelCopyright.AutoEllipsis = true;
			labelCopyright.AutoSize = true;
			labelCopyright.Location = new Point(55, 65);
			labelCopyright.Margin = new Padding(4, 0, 4, 0);
			labelCopyright.Name = "labelCopyright";
			labelCopyright.Size = new Size(133, 21);
			labelCopyright.TabIndex = 2;
			labelCopyright.Text = "[Copyright + Company]";
			toolTip.SetToolTip(labelCopyright, "Copyright/company");
			labelCopyright.UseCompatibleTextRendering = true;
			labelCopyright.Enter += SetStatusbar_Enter;
			labelCopyright.Leave += ClearStatusbar_Leave;
			labelCopyright.MouseEnter += SetStatusbar_Enter;
			labelCopyright.MouseLeave += ClearStatusbar_Leave;
			// 
			// dateTimePickerDateOfTheBirth
			// 
			dateTimePickerDateOfTheBirth.AccessibleDescription = "Shows the date of the birth";
			dateTimePickerDateOfTheBirth.AccessibleName = "Date of the birth";
			dateTimePickerDateOfTheBirth.AccessibleRole = AccessibleRole.SpinButton;
			dateTimePickerDateOfTheBirth.Location = new Point(117, 7);
			dateTimePickerDateOfTheBirth.Margin = new Padding(4, 3, 4, 3);
			dateTimePickerDateOfTheBirth.Name = "dateTimePickerDateOfTheBirth";
			dateTimePickerDateOfTheBirth.Size = new Size(233, 23);
			dateTimePickerDateOfTheBirth.TabIndex = 1;
			toolTip.SetToolTip(dateTimePickerDateOfTheBirth, "Date of the birth");
			dateTimePickerDateOfTheBirth.ValueChanged += DateTimePickerDateOfTheBirth_ValueChanged;
			dateTimePickerDateOfTheBirth.Enter += SetStatusbar_Enter;
			dateTimePickerDateOfTheBirth.Leave += ClearStatusbar_Leave;
			dateTimePickerDateOfTheBirth.MouseEnter += SetStatusbar_Enter;
			dateTimePickerDateOfTheBirth.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateOfTheBirth
			// 
			labelDateOfTheBirth.AccessibleDescription = "Shows the description of the date of the birth";
			labelDateOfTheBirth.AccessibleName = "Description of the date of the birth";
			labelDateOfTheBirth.AccessibleRole = AccessibleRole.StaticText;
			labelDateOfTheBirth.AutoEllipsis = true;
			labelDateOfTheBirth.AutoSize = true;
			labelDateOfTheBirth.Location = new Point(9, 12);
			labelDateOfTheBirth.Margin = new Padding(4, 0, 4, 0);
			labelDateOfTheBirth.Name = "labelDateOfTheBirth";
			labelDateOfTheBirth.Size = new Size(96, 15);
			labelDateOfTheBirth.TabIndex = 0;
			labelDateOfTheBirth.Text = "Date of the &birth:";
			toolTip.SetToolTip(labelDateOfTheBirth, "Description of the date of the birth");
			labelDateOfTheBirth.Enter += SetStatusbar_Enter;
			labelDateOfTheBirth.Leave += ClearStatusbar_Leave;
			labelDateOfTheBirth.MouseEnter += SetStatusbar_Enter;
			labelDateOfTheBirth.MouseLeave += ClearStatusbar_Leave;
			// 
			// dateTimePickerDateIn
			// 
			dateTimePickerDateIn.AccessibleDescription = "Shows the beginning date";
			dateTimePickerDateIn.AccessibleName = "Beginning date";
			dateTimePickerDateIn.AccessibleRole = AccessibleRole.SpinButton;
			dateTimePickerDateIn.Location = new Point(77, 7);
			dateTimePickerDateIn.Margin = new Padding(4, 3, 4, 3);
			dateTimePickerDateIn.Name = "dateTimePickerDateIn";
			dateTimePickerDateIn.Size = new Size(231, 23);
			dateTimePickerDateIn.TabIndex = 1;
			toolTip.SetToolTip(dateTimePickerDateIn, "Beginning date");
			dateTimePickerDateIn.ValueChanged += DateTimePickerDateIn_ValueChanged;
			dateTimePickerDateIn.Enter += SetStatusbar_Enter;
			dateTimePickerDateIn.Leave += ClearStatusbar_Leave;
			dateTimePickerDateIn.MouseEnter += SetStatusbar_Enter;
			dateTimePickerDateIn.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownDays
			// 
			numericUpDownDays.AccessibleDescription = "Changes the day span";
			numericUpDownDays.AccessibleName = "Day span";
			numericUpDownDays.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownDays.Location = new Point(77, 37);
			numericUpDownDays.Margin = new Padding(4, 3, 4, 3);
			numericUpDownDays.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
			numericUpDownDays.Minimum = new decimal(new int[] { 99999, 0, 0, int.MinValue });
			numericUpDownDays.Name = "numericUpDownDays";
			numericUpDownDays.Size = new Size(88, 23);
			numericUpDownDays.TabIndex = 4;
			numericUpDownDays.TextAlign = HorizontalAlignment.Center;
			toolTip.SetToolTip(numericUpDownDays, "Day span");
			numericUpDownDays.ValueChanged += NumericUpDownDays_ValueChanged;
			numericUpDownDays.Enter += SetStatusbar_Enter;
			numericUpDownDays.Leave += ClearStatusbar_Leave;
			// 
			// dateTimePickerDateOut
			// 
			dateTimePickerDateOut.AccessibleDescription = "Shows the ending date";
			dateTimePickerDateOut.AccessibleName = "Ending date";
			dateTimePickerDateOut.AccessibleRole = AccessibleRole.SpinButton;
			dateTimePickerDateOut.Enabled = false;
			dateTimePickerDateOut.Location = new Point(77, 67);
			dateTimePickerDateOut.Margin = new Padding(4, 3, 4, 3);
			dateTimePickerDateOut.Name = "dateTimePickerDateOut";
			dateTimePickerDateOut.Size = new Size(231, 23);
			dateTimePickerDateOut.TabIndex = 6;
			toolTip.SetToolTip(dateTimePickerDateOut, "Ending date");
			dateTimePickerDateOut.Enter += SetStatusbar_Enter;
			dateTimePickerDateOut.Leave += ClearStatusbar_Leave;
			dateTimePickerDateOut.MouseEnter += SetStatusbar_Enter;
			dateTimePickerDateOut.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateIn
			// 
			labelDateIn.AccessibleDescription = "Shows the description of the beginning date";
			labelDateIn.AccessibleName = "Description of the beginning date";
			labelDateIn.AccessibleRole = AccessibleRole.StaticText;
			labelDateIn.AutoEllipsis = true;
			labelDateIn.AutoSize = true;
			labelDateIn.Location = new Point(9, 12);
			labelDateIn.Margin = new Padding(4, 0, 4, 0);
			labelDateIn.Name = "labelDateIn";
			labelDateIn.Size = new Size(47, 15);
			labelDateIn.TabIndex = 0;
			labelDateIn.Text = "Date &in:";
			toolTip.SetToolTip(labelDateIn, "Description of the beginning date");
			labelDateIn.Enter += SetStatusbar_Enter;
			labelDateIn.Leave += ClearStatusbar_Leave;
			labelDateIn.MouseEnter += SetStatusbar_Enter;
			labelDateIn.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateOut
			// 
			labelDateOut.AccessibleDescription = "Shows the description of the ending date";
			labelDateOut.AccessibleName = "Description of the ending date";
			labelDateOut.AccessibleRole = AccessibleRole.StaticText;
			labelDateOut.AutoEllipsis = true;
			labelDateOut.AutoSize = true;
			labelDateOut.Location = new Point(9, 72);
			labelDateOut.Margin = new Padding(4, 0, 4, 0);
			labelDateOut.Name = "labelDateOut";
			labelDateOut.Size = new Size(55, 15);
			labelDateOut.TabIndex = 5;
			labelDateOut.Text = "Date &out:";
			toolTip.SetToolTip(labelDateOut, "Description of the ending date");
			labelDateOut.Enter += SetStatusbar_Enter;
			labelDateOut.Leave += ClearStatusbar_Leave;
			labelDateOut.MouseEnter += SetStatusbar_Enter;
			labelDateOut.MouseLeave += ClearStatusbar_Leave;
			// 
			// dateTimePickerEnd
			// 
			dateTimePickerEnd.AccessibleDescription = "Shows the ending date";
			dateTimePickerEnd.AccessibleName = "Ending date";
			dateTimePickerEnd.AccessibleRole = AccessibleRole.SpinButton;
			dateTimePickerEnd.Location = new Point(57, 37);
			dateTimePickerEnd.Margin = new Padding(4, 3, 4, 3);
			dateTimePickerEnd.Name = "dateTimePickerEnd";
			dateTimePickerEnd.Size = new Size(233, 23);
			dateTimePickerEnd.TabIndex = 4;
			toolTip.SetToolTip(dateTimePickerEnd, "Ending date");
			dateTimePickerEnd.ValueChanged += DateTimePickerEnd_ValueChanged;
			dateTimePickerEnd.Enter += SetStatusbar_Enter;
			dateTimePickerEnd.Leave += ClearStatusbar_Leave;
			dateTimePickerEnd.MouseEnter += SetStatusbar_Enter;
			dateTimePickerEnd.MouseLeave += ClearStatusbar_Leave;
			// 
			// dateTimePickerBegin
			// 
			dateTimePickerBegin.AccessibleDescription = "Shows the beginning date";
			dateTimePickerBegin.AccessibleName = "Beginning date";
			dateTimePickerBegin.AccessibleRole = AccessibleRole.SpinButton;
			dateTimePickerBegin.Location = new Point(57, 7);
			dateTimePickerBegin.Margin = new Padding(4, 3, 4, 3);
			dateTimePickerBegin.Name = "dateTimePickerBegin";
			dateTimePickerBegin.Size = new Size(233, 23);
			dateTimePickerBegin.TabIndex = 1;
			toolTip.SetToolTip(dateTimePickerBegin, "Beginning");
			dateTimePickerBegin.ValueChanged += DateTimePickerBegin_ValueChanged;
			dateTimePickerBegin.Enter += SetStatusbar_Enter;
			dateTimePickerBegin.Leave += ClearStatusbar_Leave;
			dateTimePickerBegin.MouseEnter += SetStatusbar_Enter;
			dateTimePickerBegin.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateBegin
			// 
			labelDateBegin.AccessibleDescription = "Shows the description of the beginning date";
			labelDateBegin.AccessibleName = "Description of the beginning date";
			labelDateBegin.AccessibleRole = AccessibleRole.StaticText;
			labelDateBegin.AutoEllipsis = true;
			labelDateBegin.AutoSize = true;
			labelDateBegin.Location = new Point(9, 12);
			labelDateBegin.Margin = new Padding(4, 0, 4, 0);
			labelDateBegin.Name = "labelDateBegin";
			labelDateBegin.Size = new Size(38, 15);
			labelDateBegin.TabIndex = 0;
			labelDateBegin.Text = "&From:";
			toolTip.SetToolTip(labelDateBegin, "Description of the first date");
			labelDateBegin.Enter += SetStatusbar_Enter;
			labelDateBegin.Leave += ClearStatusbar_Leave;
			labelDateBegin.MouseEnter += SetStatusbar_Enter;
			labelDateBegin.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDateEnd
			// 
			labelDateEnd.AccessibleDescription = "Shows the description of the ending date";
			labelDateEnd.AccessibleName = "Description of the ending date";
			labelDateEnd.AccessibleRole = AccessibleRole.StaticText;
			labelDateEnd.AutoEllipsis = true;
			labelDateEnd.AutoSize = true;
			labelDateEnd.Location = new Point(9, 42);
			labelDateEnd.Margin = new Padding(4, 0, 4, 0);
			labelDateEnd.Name = "labelDateEnd";
			labelDateEnd.Size = new Size(22, 15);
			labelDateEnd.TabIndex = 3;
			labelDateEnd.Text = "&To:";
			toolTip.SetToolTip(labelDateEnd, "Description of the second date");
			labelDateEnd.Enter += SetStatusbar_Enter;
			labelDateEnd.Leave += ClearStatusbar_Leave;
			labelDateEnd.MouseEnter += SetStatusbar_Enter;
			labelDateEnd.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDays
			// 
			labelDays.AccessibleDescription = "Shows the description of the counted days";
			labelDays.AccessibleName = "Description of the counted days";
			labelDays.AccessibleRole = AccessibleRole.StaticText;
			labelDays.AutoEllipsis = true;
			labelDays.AutoSize = true;
			labelDays.Location = new Point(9, 68);
			labelDays.Margin = new Padding(4, 0, 4, 0);
			labelDays.Name = "labelDays";
			labelDays.Size = new Size(35, 15);
			labelDays.TabIndex = 6;
			labelDays.Text = "&Days:";
			toolTip.SetToolTip(labelDays, "Description of the counted days");
			labelDays.Enter += SetStatusbar_Enter;
			labelDays.Leave += ClearStatusbar_Leave;
			labelDays.MouseEnter += SetStatusbar_Enter;
			labelDays.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDaysCounted
			// 
			labelDaysCounted.AccessibleDescription = "Shows the the counted days";
			labelDaysCounted.AccessibleName = "Counted days";
			labelDaysCounted.AccessibleRole = AccessibleRole.StaticText;
			labelDaysCounted.AutoEllipsis = true;
			labelDaysCounted.AutoSize = true;
			labelDaysCounted.Location = new Point(59, 68);
			labelDaysCounted.Margin = new Padding(4, 0, 4, 0);
			labelDaysCounted.Name = "labelDaysCounted";
			labelDaysCounted.Size = new Size(114, 15);
			labelDaysCounted.TabIndex = 7;
			labelDaysCounted.Text = "They are xxxxx days.";
			toolTip.SetToolTip(labelDaysCounted, "Counted days");
			labelDaysCounted.Enter += SetStatusbar_Enter;
			labelDaysCounted.Leave += ClearStatusbar_Leave;
			labelDaysCounted.MouseEnter += SetStatusbar_Enter;
			labelDaysCounted.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDaysOld
			// 
			labelDaysOld.AccessibleDescription = "Shows how old you are in days";
			labelDaysOld.AccessibleName = "How old you are in days";
			labelDaysOld.AccessibleRole = AccessibleRole.StaticText;
			labelDaysOld.AutoEllipsis = true;
			labelDaysOld.AutoSize = true;
			labelDaysOld.Location = new Point(113, 46);
			labelDaysOld.Margin = new Padding(4, 0, 4, 0);
			labelDaysOld.Name = "labelDaysOld";
			labelDaysOld.Size = new Size(129, 15);
			labelDaysOld.TabIndex = 4;
			labelDaysOld.Text = "You are xxxxx days old.";
			toolTip.SetToolTip(labelDaysOld, "How old you are in days");
			labelDaysOld.Enter += SetStatusbar_Enter;
			labelDaysOld.Leave += ClearStatusbar_Leave;
			labelDaysOld.MouseEnter += SetStatusbar_Enter;
			labelDaysOld.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDaysSpan
			// 
			labelDaysSpan.AccessibleDescription = "Shows the description of the counted days";
			labelDaysSpan.AccessibleName = "Description of the counted days";
			labelDaysSpan.AccessibleRole = AccessibleRole.StaticText;
			labelDaysSpan.AutoEllipsis = true;
			labelDaysSpan.AutoSize = true;
			labelDaysSpan.Location = new Point(9, 46);
			labelDaysSpan.Margin = new Padding(4, 0, 4, 0);
			labelDaysSpan.Name = "labelDaysSpan";
			labelDaysSpan.Size = new Size(35, 15);
			labelDaysSpan.TabIndex = 3;
			labelDaysSpan.Text = "&Days:";
			toolTip.SetToolTip(labelDaysSpan, "Description of the counted days");
			labelDaysSpan.Enter += SetStatusbar_Enter;
			labelDaysSpan.Leave += ClearStatusbar_Leave;
			labelDaysSpan.MouseEnter += SetStatusbar_Enter;
			labelDaysSpan.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSwitchDateEnd
			// 
			buttonSwitchDateEnd.AccessibleDescription = "Switchs the input method of the ending date";
			buttonSwitchDateEnd.AccessibleName = "Changes the input method of the ending date";
			buttonSwitchDateEnd.AccessibleRole = AccessibleRole.PushButton;
			buttonSwitchDateEnd.AutoEllipsis = true;
			buttonSwitchDateEnd.Image = Properties.Resources.switch_small;
			buttonSwitchDateEnd.Location = new Point(298, 37);
			buttonSwitchDateEnd.Margin = new Padding(4, 3, 4, 3);
			buttonSwitchDateEnd.Name = "buttonSwitchDateEnd";
			buttonSwitchDateEnd.Size = new Size(23, 23);
			buttonSwitchDateEnd.TabIndex = 5;
			toolTip.SetToolTip(buttonSwitchDateEnd, "Changes the input method of the ending date");
			buttonSwitchDateEnd.UseVisualStyleBackColor = true;
			buttonSwitchDateEnd.Click += ButtonSwitchDateEnd_Click;
			buttonSwitchDateEnd.Enter += SetStatusbar_Enter;
			buttonSwitchDateEnd.Leave += ClearStatusbar_Leave;
			buttonSwitchDateEnd.MouseEnter += SetStatusbar_Enter;
			buttonSwitchDateEnd.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSwitchDateBegin
			// 
			buttonSwitchDateBegin.AccessibleDescription = "Switchs the input method of the beginning date";
			buttonSwitchDateBegin.AccessibleName = "Changes the input method of the beginning date";
			buttonSwitchDateBegin.AccessibleRole = AccessibleRole.PushButton;
			buttonSwitchDateBegin.AutoEllipsis = true;
			buttonSwitchDateBegin.Image = Properties.Resources.switch_small;
			buttonSwitchDateBegin.Location = new Point(298, 7);
			buttonSwitchDateBegin.Margin = new Padding(4, 3, 4, 3);
			buttonSwitchDateBegin.Name = "buttonSwitchDateBegin";
			buttonSwitchDateBegin.Size = new Size(23, 23);
			buttonSwitchDateBegin.TabIndex = 2;
			toolTip.SetToolTip(buttonSwitchDateBegin, "Changes the input method of the beginning date");
			buttonSwitchDateBegin.UseVisualStyleBackColor = true;
			buttonSwitchDateBegin.Click += ButtonSwitchDateBegin_Click;
			buttonSwitchDateBegin.Enter += SetStatusbar_Enter;
			buttonSwitchDateBegin.Leave += ClearStatusbar_Leave;
			buttonSwitchDateBegin.MouseEnter += SetStatusbar_Enter;
			buttonSwitchDateBegin.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSwitchDateIn
			// 
			buttonSwitchDateIn.AccessibleDescription = "Switchs the input method of the beginning date";
			buttonSwitchDateIn.AccessibleName = "Changes the input method of the ending date";
			buttonSwitchDateIn.AccessibleRole = AccessibleRole.PushButton;
			buttonSwitchDateIn.AutoEllipsis = true;
			buttonSwitchDateIn.Image = Properties.Resources.switch_small;
			buttonSwitchDateIn.Location = new Point(316, 7);
			buttonSwitchDateIn.Margin = new Padding(4, 3, 4, 3);
			buttonSwitchDateIn.Name = "buttonSwitchDateIn";
			buttonSwitchDateIn.Size = new Size(23, 23);
			buttonSwitchDateIn.TabIndex = 2;
			toolTip.SetToolTip(buttonSwitchDateIn, "Changes the input method of the ending date");
			buttonSwitchDateIn.UseVisualStyleBackColor = true;
			buttonSwitchDateIn.Click += ButtonSwitchDateDays_Click;
			buttonSwitchDateIn.Enter += SetStatusbar_Enter;
			buttonSwitchDateIn.Leave += ClearStatusbar_Leave;
			buttonSwitchDateIn.MouseEnter += SetStatusbar_Enter;
			buttonSwitchDateIn.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonDateOfTheBirth
			// 
			buttonDateOfTheBirth.AccessibleDescription = "Switchs the input method of the date of the birth";
			buttonDateOfTheBirth.AccessibleName = "Changes the input method of the date of the birth";
			buttonDateOfTheBirth.AccessibleRole = AccessibleRole.PushButton;
			buttonDateOfTheBirth.AutoEllipsis = true;
			buttonDateOfTheBirth.Image = Properties.Resources.switch_small;
			buttonDateOfTheBirth.Location = new Point(357, 7);
			buttonDateOfTheBirth.Margin = new Padding(4, 3, 4, 3);
			buttonDateOfTheBirth.Name = "buttonDateOfTheBirth";
			buttonDateOfTheBirth.Size = new Size(23, 23);
			buttonDateOfTheBirth.TabIndex = 2;
			toolTip.SetToolTip(buttonDateOfTheBirth, "Changes the input method of the date of the birth");
			buttonDateOfTheBirth.UseVisualStyleBackColor = true;
			buttonDateOfTheBirth.Click += ButtonDateOfTheBirth_Click;
			buttonDateOfTheBirth.Enter += SetStatusbar_Enter;
			buttonDateOfTheBirth.Leave += ClearStatusbar_Leave;
			buttonDateOfTheBirth.MouseEnter += SetStatusbar_Enter;
			buttonDateOfTheBirth.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxLicense
			// 
			textBoxLicense.AccessibleDescription = "Shows the license";
			textBoxLicense.AccessibleName = "License";
			textBoxLicense.AccessibleRole = AccessibleRole.Text;
			textBoxLicense.Dock = DockStyle.Fill;
			textBoxLicense.Location = new Point(0, 0);
			textBoxLicense.Margin = new Padding(7, 3, 4, 3);
			textBoxLicense.MaxLength = 9999999;
			textBoxLicense.Multiline = true;
			textBoxLicense.Name = "textBoxLicense";
			textBoxLicense.PlaceholderText = "license here... 😉";
			textBoxLicense.ReadOnly = true;
			textBoxLicense.ScrollBars = ScrollBars.Both;
			textBoxLicense.Size = new Size(405, 96);
			textBoxLicense.TabIndex = 0;
			textBoxLicense.Text = resources.GetString("textBoxLicense.Text");
			toolTip.SetToolTip(textBoxLicense, "License");
			textBoxLicense.Enter += SetStatusbar_Enter;
			textBoxLicense.Leave += ClearStatusbar_Leave;
			textBoxLicense.MouseEnter += SetStatusbar_Enter;
			textBoxLicense.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDaysPlusMinus
			// 
			labelDaysPlusMinus.AccessibleDescription = "Shows the description of the ending date";
			labelDaysPlusMinus.AccessibleName = "Description of the day span";
			labelDaysPlusMinus.AccessibleRole = AccessibleRole.StaticText;
			labelDaysPlusMinus.AutoEllipsis = true;
			labelDaysPlusMinus.AutoSize = true;
			labelDaysPlusMinus.Location = new Point(9, 39);
			labelDaysPlusMinus.Margin = new Padding(4, 0, 4, 0);
			labelDaysPlusMinus.Name = "labelDaysPlusMinus";
			labelDaysPlusMinus.Size = new Size(64, 15);
			labelDaysPlusMinus.TabIndex = 3;
			labelDaysPlusMinus.Text = "&Days (-/+):";
			toolTip.SetToolTip(labelDaysPlusMinus, "Description of the day span");
			labelDaysPlusMinus.Enter += SetStatusbar_Enter;
			labelDaysPlusMinus.Leave += ClearStatusbar_Leave;
			labelDaysPlusMinus.MouseEnter += SetStatusbar_Enter;
			labelDaysPlusMinus.MouseLeave += ClearStatusbar_Leave;
			// 
			// tabControl
			// 
			tabControl.AccessibleDescription = "Shows the tabs";
			tabControl.AccessibleName = "Shows the tabs";
			tabControl.AccessibleRole = AccessibleRole.PageTab;
			tabControl.Controls.Add(tabPageDateToDate);
			tabControl.Controls.Add(tabPageDaySpan);
			tabControl.Controls.Add(tabPageDaysOfLife);
			tabControl.Controls.Add(tabPageDaysOfYear);
			tabControl.Controls.Add(tabPageAbout);
			tabControl.Controls.Add(tabPageLicense);
			tabControl.Dock = DockStyle.Fill;
			tabControl.HotTrack = true;
			tabControl.ImageList = imageList;
			tabControl.Location = new Point(0, 0);
			tabControl.Margin = new Padding(4, 3, 4, 3);
			tabControl.Multiline = true;
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.ShowToolTips = true;
			tabControl.Size = new Size(413, 144);
			tabControl.TabIndex = 0;
			toolTip.SetToolTip(tabControl, "Shows the tabs");
			tabControl.Enter += SetStatusbar_Enter;
			tabControl.Leave += ClearStatusbar_Leave;
			tabControl.MouseEnter += SetStatusbar_Enter;
			tabControl.MouseLeave += ClearStatusbar_Leave;
			// 
			// tabPageDateToDate
			// 
			tabPageDateToDate.AccessibleDescription = "Shows the tab page \"From date to date\"";
			tabPageDateToDate.AccessibleName = "Tab page \"From date to date\"";
			tabPageDateToDate.AccessibleRole = AccessibleRole.PageTab;
			tabPageDateToDate.Controls.Add(labelDaysCounted);
			tabPageDateToDate.Controls.Add(labelDays);
			tabPageDateToDate.Controls.Add(labelDateEnd);
			tabPageDateToDate.Controls.Add(labelDateBegin);
			tabPageDateToDate.Controls.Add(dateTimePickerBegin);
			tabPageDateToDate.Controls.Add(buttonSwitchDateEnd);
			tabPageDateToDate.Controls.Add(buttonSwitchDateBegin);
			tabPageDateToDate.Controls.Add(dateTimePickerEnd);
			tabPageDateToDate.ImageKey = "calendar-select-days.png";
			tabPageDateToDate.Location = new Point(4, 44);
			tabPageDateToDate.Margin = new Padding(4, 3, 4, 3);
			tabPageDateToDate.Name = "tabPageDateToDate";
			tabPageDateToDate.Padding = new Padding(4, 3, 4, 3);
			tabPageDateToDate.Size = new Size(405, 71);
			tabPageDateToDate.TabIndex = 0;
			tabPageDateToDate.Text = "From date to date";
			toolTip.SetToolTip(tabPageDateToDate, "Shows the tab page \"From date to date\"");
			tabPageDateToDate.ToolTipText = "From date to date";
			tabPageDateToDate.UseVisualStyleBackColor = true;
			tabPageDateToDate.Enter += SetStatusbar_Enter;
			tabPageDateToDate.Leave += ClearStatusbar_Leave;
			tabPageDateToDate.MouseEnter += SetStatusbar_Enter;
			tabPageDateToDate.MouseHover += ClearStatusbar_Leave;
			// 
			// tabPageDaySpan
			// 
			tabPageDaySpan.AccessibleDescription = "Shows the tab page \"Days span\"";
			tabPageDaySpan.AccessibleName = "Tab page \"Days span\"";
			tabPageDaySpan.AccessibleRole = AccessibleRole.PageTab;
			tabPageDaySpan.Controls.Add(labelDateOut);
			tabPageDaySpan.Controls.Add(labelDateIn);
			tabPageDaySpan.Controls.Add(dateTimePickerDateOut);
			tabPageDaySpan.Controls.Add(labelDaysPlusMinus);
			tabPageDaySpan.Controls.Add(numericUpDownDays);
			tabPageDaySpan.Controls.Add(dateTimePickerDateIn);
			tabPageDaySpan.Controls.Add(buttonSwitchDateIn);
			tabPageDaySpan.ImageKey = "calendar-select-days-span.png";
			tabPageDaySpan.Location = new Point(4, 44);
			tabPageDaySpan.Margin = new Padding(4, 3, 4, 3);
			tabPageDaySpan.Name = "tabPageDaySpan";
			tabPageDaySpan.Padding = new Padding(4, 3, 4, 3);
			tabPageDaySpan.Size = new Size(405, 96);
			tabPageDaySpan.TabIndex = 1;
			tabPageDaySpan.Text = "Days span";
			toolTip.SetToolTip(tabPageDaySpan, "Shows the tab page \"Days span\"");
			tabPageDaySpan.ToolTipText = "Day span";
			tabPageDaySpan.UseVisualStyleBackColor = true;
			tabPageDaySpan.Enter += SetStatusbar_Enter;
			tabPageDaySpan.Leave += ClearStatusbar_Leave;
			tabPageDaySpan.MouseEnter += SetStatusbar_Enter;
			tabPageDaySpan.MouseLeave += ClearStatusbar_Leave;
			// 
			// tabPageDaysOfLife
			// 
			tabPageDaysOfLife.AccessibleDescription = "Shows the tab page \"Days of life\"";
			tabPageDaysOfLife.AccessibleName = "Tab page \"Days of life\"";
			tabPageDaysOfLife.AccessibleRole = AccessibleRole.PageTab;
			tabPageDaysOfLife.Controls.Add(labelDaysSpan);
			tabPageDaysOfLife.Controls.Add(labelDaysOld);
			tabPageDaysOfLife.Controls.Add(labelDateOfTheBirth);
			tabPageDaysOfLife.Controls.Add(dateTimePickerDateOfTheBirth);
			tabPageDaysOfLife.Controls.Add(buttonDateOfTheBirth);
			tabPageDaysOfLife.ImageKey = "calendar-select.png";
			tabPageDaysOfLife.Location = new Point(4, 44);
			tabPageDaysOfLife.Margin = new Padding(4, 3, 4, 3);
			tabPageDaysOfLife.Name = "tabPageDaysOfLife";
			tabPageDaysOfLife.Padding = new Padding(4, 3, 4, 3);
			tabPageDaysOfLife.Size = new Size(405, 96);
			tabPageDaysOfLife.TabIndex = 3;
			tabPageDaysOfLife.Text = "Days of life";
			toolTip.SetToolTip(tabPageDaysOfLife, "Shows the tab page \"Days of life\"");
			tabPageDaysOfLife.ToolTipText = "Days of life";
			tabPageDaysOfLife.UseVisualStyleBackColor = true;
			tabPageDaysOfLife.Enter += SetStatusbar_Enter;
			tabPageDaysOfLife.Leave += ClearStatusbar_Leave;
			tabPageDaysOfLife.MouseEnter += SetStatusbar_Enter;
			tabPageDaysOfLife.MouseLeave += ClearStatusbar_Leave;
			// 
			// tabPageDaysOfYear
			// 
			tabPageDaysOfYear.AccessibleDescription = "Shows the tab page \"Days of year\"";
			tabPageDaysOfYear.AccessibleName = "Tab page \"Days of year\"";
			tabPageDaysOfYear.AccessibleRole = AccessibleRole.PageTab;
			tabPageDaysOfYear.Controls.Add(labelDaysOfYear);
			tabPageDaysOfYear.Controls.Add(labelDate);
			tabPageDaysOfYear.Controls.Add(dateTimePickerDaysOfYear);
			tabPageDaysOfYear.Controls.Add(buttonDaysOfYear);
			tabPageDaysOfYear.Controls.Add(labelDaysOfYearPassed);
			tabPageDaysOfYear.ImageKey = "calendar-day.png";
			tabPageDaysOfYear.Location = new Point(4, 44);
			tabPageDaysOfYear.Name = "tabPageDaysOfYear";
			tabPageDaysOfYear.Padding = new Padding(3);
			tabPageDaysOfYear.Size = new Size(405, 96);
			tabPageDaysOfYear.TabIndex = 5;
			tabPageDaysOfYear.Text = "Days of year";
			toolTip.SetToolTip(tabPageDaysOfYear, "Shows the tab page \"Days of year\"");
			tabPageDaysOfYear.ToolTipText = "Days of year";
			tabPageDaysOfYear.UseVisualStyleBackColor = true;
			tabPageDaysOfYear.Enter += SetStatusbar_Enter;
			tabPageDaysOfYear.Leave += ClearStatusbar_Leave;
			tabPageDaysOfYear.MouseEnter += SetStatusbar_Enter;
			tabPageDaysOfYear.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelDate
			// 
			labelDate.AccessibleDescription = "Shows the description of the date";
			labelDate.AccessibleName = "Description of the date";
			labelDate.AccessibleRole = AccessibleRole.StaticText;
			labelDate.AutoEllipsis = true;
			labelDate.AutoSize = true;
			labelDate.Location = new Point(9, 13);
			labelDate.Margin = new Padding(4, 0, 4, 0);
			labelDate.Name = "labelDate";
			labelDate.Size = new Size(34, 15);
			labelDate.TabIndex = 0;
			labelDate.Text = "&Date:";
			toolTip.SetToolTip(labelDate, "Description of the date");
			labelDate.Enter += SetStatusbar_Enter;
			labelDate.Leave += ClearStatusbar_Leave;
			labelDate.MouseEnter += SetStatusbar_Enter;
			labelDate.MouseHover += ClearStatusbar_Leave;
			// 
			// dateTimePickerDaysOfYear
			// 
			dateTimePickerDaysOfYear.AccessibleDescription = "Shows the date";
			dateTimePickerDaysOfYear.AccessibleName = "date";
			dateTimePickerDaysOfYear.AccessibleRole = AccessibleRole.SpinButton;
			dateTimePickerDaysOfYear.Location = new Point(57, 8);
			dateTimePickerDaysOfYear.Margin = new Padding(4, 3, 4, 3);
			dateTimePickerDaysOfYear.Name = "dateTimePickerDaysOfYear";
			dateTimePickerDaysOfYear.Size = new Size(233, 23);
			dateTimePickerDaysOfYear.TabIndex = 1;
			toolTip.SetToolTip(dateTimePickerDaysOfYear, "Date");
			dateTimePickerDaysOfYear.ValueChanged += DateTimePickerDaysOfYear_ValueChanged;
			dateTimePickerDaysOfYear.Enter += SetStatusbar_Enter;
			dateTimePickerDaysOfYear.Leave += ClearStatusbar_Leave;
			dateTimePickerDaysOfYear.MouseEnter += SetStatusbar_Enter;
			dateTimePickerDaysOfYear.MouseHover += ClearStatusbar_Leave;
			// 
			// buttonDaysOfYear
			// 
			buttonDaysOfYear.AccessibleDescription = "Switchs the input method of of the days of years";
			buttonDaysOfYear.AccessibleName = "Changes the input method of of the days of years";
			buttonDaysOfYear.AccessibleRole = AccessibleRole.PushButton;
			buttonDaysOfYear.AutoEllipsis = true;
			buttonDaysOfYear.Image = Properties.Resources.switch_small;
			buttonDaysOfYear.Location = new Point(298, 8);
			buttonDaysOfYear.Margin = new Padding(4, 3, 4, 3);
			buttonDaysOfYear.Name = "buttonDaysOfYear";
			buttonDaysOfYear.Size = new Size(23, 23);
			buttonDaysOfYear.TabIndex = 2;
			toolTip.SetToolTip(buttonDaysOfYear, "Changes the input method of of the days of years");
			buttonDaysOfYear.UseVisualStyleBackColor = true;
			buttonDaysOfYear.Click += ButtonDaysOfYear_Click;
			buttonDaysOfYear.Enter += SetStatusbar_Enter;
			buttonDaysOfYear.Leave += ClearStatusbar_Leave;
			buttonDaysOfYear.MouseEnter += SetStatusbar_Enter;
			buttonDaysOfYear.MouseHover += ClearStatusbar_Leave;
			// 
			// labelDaysOfYearPassed
			// 
			labelDaysOfYearPassed.AccessibleDescription = "Shows how many days have been since the start of the year";
			labelDaysOfYearPassed.AccessibleName = "How many days have been since the start of the year";
			labelDaysOfYearPassed.AccessibleRole = AccessibleRole.StaticText;
			labelDaysOfYearPassed.AutoEllipsis = true;
			labelDaysOfYearPassed.AutoSize = true;
			labelDaysOfYearPassed.Location = new Point(57, 53);
			labelDaysOfYearPassed.Margin = new Padding(4, 0, 4, 0);
			labelDaysOfYearPassed.Name = "labelDaysOfYearPassed";
			labelDaysOfYearPassed.Size = new Size(255, 15);
			labelDaysOfYearPassed.TabIndex = 4;
			labelDaysOfYearPassed.Text = "It has been XXX days since the start of this year.";
			toolTip.SetToolTip(labelDaysOfYearPassed, "How many days have been since the start of the year");
			labelDaysOfYearPassed.Enter += SetStatusbar_Enter;
			labelDaysOfYearPassed.Leave += ClearStatusbar_Leave;
			labelDaysOfYearPassed.MouseEnter += SetStatusbar_Enter;
			labelDaysOfYearPassed.MouseLeave += ClearStatusbar_Leave;
			labelDaysOfYearPassed.MouseHover += ClearStatusbar_Leave;
			// 
			// tabPageAbout
			// 
			tabPageAbout.AccessibleDescription = "Shows the tab page \"About\"";
			tabPageAbout.AccessibleName = "Tab page \"About\"";
			tabPageAbout.AccessibleRole = AccessibleRole.PageTab;
			tabPageAbout.Controls.Add(labelCopyright);
			tabPageAbout.Controls.Add(labelDescription);
			tabPageAbout.Controls.Add(labelTitle);
			tabPageAbout.Controls.Add(pictureBox);
			tabPageAbout.ImageKey = "information-button.png";
			tabPageAbout.Location = new Point(4, 44);
			tabPageAbout.Margin = new Padding(4, 3, 4, 3);
			tabPageAbout.Name = "tabPageAbout";
			tabPageAbout.Padding = new Padding(4, 3, 4, 3);
			tabPageAbout.Size = new Size(405, 96);
			tabPageAbout.TabIndex = 2;
			tabPageAbout.Text = "About";
			toolTip.SetToolTip(tabPageAbout, "Shows the tab page \"About\"");
			tabPageAbout.ToolTipText = "About";
			tabPageAbout.UseVisualStyleBackColor = true;
			tabPageAbout.Enter += SetStatusbar_Enter;
			tabPageAbout.Leave += ClearStatusbar_Leave;
			tabPageAbout.MouseEnter += SetStatusbar_Enter;
			tabPageAbout.MouseHover += ClearStatusbar_Leave;
			// 
			// pictureBox
			// 
			pictureBox.AccessibleDescription = "Show the application logo";
			pictureBox.AccessibleName = "Apllication logo";
			pictureBox.AccessibleRole = AccessibleRole.Graphic;
			pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
			pictureBox.Location = new Point(10, 8);
			pictureBox.Margin = new Padding(4, 3, 4, 3);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(37, 37);
			pictureBox.TabIndex = 0;
			pictureBox.TabStop = false;
			pictureBox.MouseEnter += SetStatusbar_Enter;
			pictureBox.MouseLeave += ClearStatusbar_Leave;
			// 
			// tabPageLicense
			// 
			tabPageLicense.AccessibleDescription = "Shows the tab page \"License\"";
			tabPageLicense.AccessibleName = "Tab page \"License\"";
			tabPageLicense.Controls.Add(textBoxLicense);
			tabPageLicense.ImageKey = "script-text.png";
			tabPageLicense.Location = new Point(4, 44);
			tabPageLicense.Name = "tabPageLicense";
			tabPageLicense.Size = new Size(405, 96);
			tabPageLicense.TabIndex = 4;
			tabPageLicense.Text = "License";
			toolTip.SetToolTip(tabPageLicense, "Shows the tab page \"License\"");
			tabPageLicense.ToolTipText = "License";
			tabPageLicense.UseVisualStyleBackColor = true;
			tabPageLicense.Enter += SetStatusbar_Enter;
			tabPageLicense.Leave += ClearStatusbar_Leave;
			tabPageLicense.MouseEnter += SetStatusbar_Enter;
			tabPageLicense.MouseLeave += ClearStatusbar_Leave;
			// 
			// BottomToolStripPanel
			// 
			BottomToolStripPanel.AccessibleDescription = "Just a tool strip panel";
			BottomToolStripPanel.AccessibleName = "tool strip panel";
			BottomToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			BottomToolStripPanel.Dock = DockStyle.Bottom;
			BottomToolStripPanel.Location = new Point(0, 371);
			BottomToolStripPanel.Name = "BottomToolStripPanel";
			BottomToolStripPanel.Orientation = Orientation.Horizontal;
			BottomToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
			BottomToolStripPanel.Size = new Size(622, 0);
			// 
			// TopToolStripPanel
			// 
			TopToolStripPanel.AccessibleDescription = "Just a tool strip panel";
			TopToolStripPanel.AccessibleName = "tool strip panel";
			TopToolStripPanel.Dock = DockStyle.Top;
			TopToolStripPanel.Location = new Point(0, 0);
			TopToolStripPanel.Name = "TopToolStripPanel";
			TopToolStripPanel.Orientation = Orientation.Horizontal;
			TopToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
			TopToolStripPanel.Size = new Size(622, 0);
			// 
			// RightToolStripPanel
			// 
			RightToolStripPanel.AccessibleDescription = "Just a tool strip panel";
			RightToolStripPanel.AccessibleName = "tool strip panel";
			RightToolStripPanel.Dock = DockStyle.Right;
			RightToolStripPanel.Location = new Point(357, 0);
			RightToolStripPanel.Name = "RightToolStripPanel";
			RightToolStripPanel.Orientation = Orientation.Vertical;
			RightToolStripPanel.RowMargin = new Padding(0, 3, 0, 0);
			RightToolStripPanel.Size = new Size(0, 133);
			// 
			// LeftToolStripPanel
			// 
			LeftToolStripPanel.AccessibleDescription = "Just a tool strip panel";
			LeftToolStripPanel.AccessibleName = "tool strip panel";
			LeftToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			LeftToolStripPanel.Dock = DockStyle.Left;
			LeftToolStripPanel.Location = new Point(0, 0);
			LeftToolStripPanel.Name = "LeftToolStripPanel";
			LeftToolStripPanel.Orientation = Orientation.Vertical;
			LeftToolStripPanel.RowMargin = new Padding(0, 3, 0, 0);
			LeftToolStripPanel.Size = new Size(0, 371);
			// 
			// ContentPanel
			// 
			ContentPanel.AccessibleDescription = "Just a content panel";
			ContentPanel.AccessibleName = "content panel";
			ContentPanel.AccessibleRole = AccessibleRole.Pane;
			ContentPanel.AutoScroll = true;
			ContentPanel.Size = new Size(357, 133);
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Groups the toolbars and the statusbar";
			toolStripContainer.AccessibleName = "Toolbar container";
			toolStripContainer.AccessibleRole = AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.AccessibleDescription = "Lower part of the ToolStripContainer";
			toolStripContainer.BottomToolStripPanel.AccessibleName = "Lower part of the ToolStripContainer";
			toolStripContainer.BottomToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.AccessibleDescription = "Central part of the ToolStripContainer";
			toolStripContainer.ContentPanel.AccessibleName = "Central part of the ToolStripContainer";
			toolStripContainer.ContentPanel.AccessibleRole = AccessibleRole.Pane;
			toolStripContainer.ContentPanel.AutoScroll = true;
			toolStripContainer.ContentPanel.Controls.Add(tabControl);
			toolStripContainer.ContentPanel.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.ContentPanel.Size = new Size(413, 144);
			toolStripContainer.Dock = DockStyle.Fill;
			// 
			// toolStripContainer.LeftToolStripPanel
			// 
			toolStripContainer.LeftToolStripPanel.AccessibleDescription = "Left part of the ToolStripContainer";
			toolStripContainer.LeftToolStripPanel.AccessibleName = "Left part of the ToolStripContainer";
			toolStripContainer.LeftToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.RightToolStripPanel
			// 
			toolStripContainer.RightToolStripPanel.AccessibleDescription = "Right part of the ToolStripContainer";
			toolStripContainer.RightToolStripPanel.AccessibleName = "Right part of the ToolStripContainer";
			toolStripContainer.RightToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			toolStripContainer.Size = new Size(413, 166);
			toolStripContainer.TabIndex = 6;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			toolStripContainer.TopToolStripPanel.AccessibleDescription = "Upper part of the ToolStripContainer";
			toolStripContainer.TopToolStripPanel.AccessibleName = "Upper part of the ToolStripContainer";
			toolStripContainer.TopToolStripPanel.AccessibleRole = AccessibleRole.Pane;
			// 
			// labelDaysOfYear
			// 
			labelDaysOfYear.AccessibleDescription = "Shows the description of the days of the year";
			labelDaysOfYear.AccessibleName = "Description of the days of the year";
			labelDaysOfYear.AccessibleRole = AccessibleRole.StaticText;
			labelDaysOfYear.AutoEllipsis = true;
			labelDaysOfYear.AutoSize = true;
			labelDaysOfYear.Location = new Point(9, 53);
			labelDaysOfYear.Margin = new Padding(4, 0, 4, 0);
			labelDaysOfYear.Name = "labelDaysOfYear";
			labelDaysOfYear.Size = new Size(35, 15);
			labelDaysOfYear.TabIndex = 3;
			labelDaysOfYear.Text = "&Days:";
			toolTip.SetToolTip(labelDaysOfYear, "Description of the days of the year");
			labelDaysOfYear.Enter += SetStatusbar_Enter;
			labelDaysOfYear.Leave += ClearStatusbar_Leave;
			labelDaysOfYear.MouseEnter += SetStatusbar_Enter;
			labelDaysOfYear.MouseLeave += ClearStatusbar_Leave;
			// 
			// MainForm
			// 
			AccessibleDescription = "This is the main window of the application";
			AccessibleName = "Main window";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(413, 166);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Days Counter";
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDownDays).EndInit();
			tabControl.ResumeLayout(false);
			tabPageDateToDate.ResumeLayout(false);
			tabPageDateToDate.PerformLayout();
			tabPageDaySpan.ResumeLayout(false);
			tabPageDaySpan.PerformLayout();
			tabPageDaysOfLife.ResumeLayout(false);
			tabPageDaysOfLife.PerformLayout();
			tabPageDaysOfYear.ResumeLayout(false);
			tabPageDaysOfYear.PerformLayout();
			tabPageAbout.ResumeLayout(false);
			tabPageAbout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			tabPageLicense.ResumeLayout(false);
			tabPageLicense.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private StatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private ToolTip toolTip;
		private ImageList imageList;
		private ToolStripContainer toolStripContainer;
		private TabControl tabControl;
		private TabPage tabPageDateToDate;
		private Label labelDaysCounted;
		private Label labelDays;
		private Label labelDateEnd;
		private Label labelDateBegin;
		private DateTimePicker dateTimePickerBegin;
		private Button buttonSwitchDateEnd;
		private Button buttonSwitchDateBegin;
		private DateTimePicker dateTimePickerEnd;
		private TabPage tabPageDaySpan;
		private Label labelDateOut;
		private Label labelDateIn;
		private DateTimePicker dateTimePickerDateOut;
		private Label labelDaysPlusMinus;
		private NumericUpDown numericUpDownDays;
		private DateTimePicker dateTimePickerDateIn;
		private Button buttonSwitchDateIn;
		private TabPage tabPageDaysOfLife;
		private Label labelDaysOld;
		private Label labelDateOfTheBirth;
		private DateTimePicker dateTimePickerDateOfTheBirth;
		private Button buttonDateOfTheBirth;
		private TabPage tabPageAbout;
		private Label labelCopyright;
		private Label labelDescription;
		private Label labelTitle;
		private PictureBox pictureBox;
		private ToolStripPanel BottomToolStripPanel;
		private ToolStripPanel TopToolStripPanel;
		private ToolStripPanel RightToolStripPanel;
		private ToolStripPanel LeftToolStripPanel;
		private ToolStripContentPanel ContentPanel;
		private Label labelDaysSpan;
		private ToolStripSplitButton toolStripSplitButtonStayOnTop;
		private ToolStripMenuItem toolStripMenuItemStayNotOnTop;
		private ToolStripMenuItem toolStripMenuItemStayOnTop;
		private TabPage tabPageLicense;
		private TextBox textBoxLicense;
		private TabPage tabPageDaysOfYear;
		private Label labelDaysOfYearPassed;
		private Label labelDate;
		private DateTimePicker dateTimePickerDaysOfYear;
		private Button buttonDaysOfYear;
		private Label labelDaysOfYear;
	}
}

