namespace DaysCounter
{
	partial class MainWindow
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripSplitButtonStayOnTop = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripMenuItemStayNotOnTop = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemStayOnTop = new System.Windows.Forms.ToolStripMenuItem();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.dateTimePickerDateOfTheBirth = new System.Windows.Forms.DateTimePicker();
			this.contextMenuStripDateContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemSwitch = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemInsertDateToday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCopyDateToClipboard = new System.Windows.Forms.ToolStripMenuItem();
			this.labelDateOfTheBirth = new System.Windows.Forms.Label();
			this.dateTimePickerDateIn = new System.Windows.Forms.DateTimePicker();
			this.numericUpDownDays = new System.Windows.Forms.NumericUpDown();
			this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
			this.labelDateIn = new System.Windows.Forms.Label();
			this.labelDateOut = new System.Windows.Forms.Label();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
			this.labelDateBegin = new System.Windows.Forms.Label();
			this.labelDateEnd = new System.Windows.Forms.Label();
			this.labelDays = new System.Windows.Forms.Label();
			this.labelDaysCounted = new System.Windows.Forms.Label();
			this.labelDaysOld = new System.Windows.Forms.Label();
			this.labelDaysSpan = new System.Windows.Forms.Label();
			this.buttonSwitchDateEnd = new System.Windows.Forms.Button();
			this.buttonSwitchDateBegin = new System.Windows.Forms.Button();
			this.buttonSwitchDateIn = new System.Windows.Forms.Button();
			this.buttonSwitchDateOfTheBirth = new System.Windows.Forms.Button();
			this.buttonInsertDateTodayBegin = new System.Windows.Forms.Button();
			this.buttonCopyDateBegin = new System.Windows.Forms.Button();
			this.buttonCopyDateEnd = new System.Windows.Forms.Button();
			this.buttonInsertDateTodayEnd = new System.Windows.Forms.Button();
			this.buttonCopyDateIn = new System.Windows.Forms.Button();
			this.buttonInsertDateIn = new System.Windows.Forms.Button();
			this.buttonCopyDateOut = new System.Windows.Forms.Button();
			this.buttonCopyDateOfTheBirth = new System.Windows.Forms.Button();
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageDateToDate = new System.Windows.Forms.TabPage();
			this.tabPageDaySpan = new System.Windows.Forms.TabPage();
			this.labelDaysPlusMinus = new System.Windows.Forms.Label();
			this.tabPageDaysOfLife = new System.Windows.Forms.TabPage();
			this.tabPageAbout = new System.Windows.Forms.TabPage();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.statusStrip.SuspendLayout();
			this.contextMenuStripDateContext.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageDateToDate.SuspendLayout();
			this.tabPageDaySpan.SuspendLayout();
			this.tabPageDaysOfLife.SuspendLayout();
			this.tabPageAbout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "calendar-select-days.png");
			this.imageList.Images.SetKeyName(1, "calendar-select-days-span.png");
			this.imageList.Images.SetKeyName(2, "calendar-select.png");
			this.imageList.Images.SetKeyName(3, "information-button.png");
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Show the statusbar with some information";
			this.statusStrip.AccessibleName = "Statusbar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation,
            this.toolStripSplitButtonStayOnTop});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(354, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip";
			this.toolTip.SetToolTip(this.statusStrip, "Statusbar with some information");
			this.statusStrip.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.statusStrip.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.statusStrip.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.statusStrip.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelInformation
			// 
			this.labelInformation.AccessibleDescription = "Show some information";
			this.labelInformation.AccessibleName = "Information";
			this.labelInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelInformation.AutoToolTip = true;
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(307, 17);
			this.labelInformation.Spring = true;
			this.labelInformation.Text = "information";
			this.labelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripSplitButtonStayOnTop
			// 
			this.toolStripSplitButtonStayOnTop.AccessibleDescription = "Set or unset the window to the top";
			this.toolStripSplitButtonStayOnTop.AccessibleName = "Stay on top";
			this.toolStripSplitButtonStayOnTop.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.toolStripSplitButtonStayOnTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButtonStayOnTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStayNotOnTop,
            this.toolStripMenuItemStayOnTop});
			this.toolStripSplitButtonStayOnTop.Image = global::DaysCounter.Properties.Resources.application;
			this.toolStripSplitButtonStayOnTop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButtonStayOnTop.Name = "toolStripSplitButtonStayOnTop";
			this.toolStripSplitButtonStayOnTop.Size = new System.Drawing.Size(32, 20);
			this.toolStripSplitButtonStayOnTop.Text = "Stay not on top";
			this.toolStripSplitButtonStayOnTop.ButtonClick += new System.EventHandler(this.ToolStripSplitButtonStayOnTop_ButtonClick);
			this.toolStripSplitButtonStayOnTop.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripSplitButtonStayOnTop.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemStayNotOnTop
			// 
			this.toolStripMenuItemStayNotOnTop.AccessibleDescription = "Unset the window from the top";
			this.toolStripMenuItemStayNotOnTop.AccessibleName = "Stay on top";
			this.toolStripMenuItemStayNotOnTop.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemStayNotOnTop.AutoToolTip = true;
			this.toolStripMenuItemStayNotOnTop.Checked = true;
			this.toolStripMenuItemStayNotOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemStayNotOnTop.Image = global::DaysCounter.Properties.Resources.application;
			this.toolStripMenuItemStayNotOnTop.Name = "toolStripMenuItemStayNotOnTop";
			this.toolStripMenuItemStayNotOnTop.ShortcutKeyDisplayString = "";
			this.toolStripMenuItemStayNotOnTop.Size = new System.Drawing.Size(155, 22);
			this.toolStripMenuItemStayNotOnTop.Text = "Stay &not on top";
			this.toolStripMenuItemStayNotOnTop.Click += new System.EventHandler(this.ToolStripMenuItemStayNotOnTop_Click);
			this.toolStripMenuItemStayNotOnTop.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemStayNotOnTop.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemStayOnTop
			// 
			this.toolStripMenuItemStayOnTop.AccessibleDescription = "Set the window to the top";
			this.toolStripMenuItemStayOnTop.AccessibleName = "Stay on top";
			this.toolStripMenuItemStayOnTop.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
			this.toolStripMenuItemStayOnTop.AutoToolTip = true;
			this.toolStripMenuItemStayOnTop.Image = global::DaysCounter.Properties.Resources.application_blue;
			this.toolStripMenuItemStayOnTop.Name = "toolStripMenuItemStayOnTop";
			this.toolStripMenuItemStayOnTop.Size = new System.Drawing.Size(155, 22);
			this.toolStripMenuItemStayOnTop.Text = "&Stay on top";
			this.toolStripMenuItemStayOnTop.Click += new System.EventHandler(this.ToolStripMenuItemStayOnTop_Click);
			this.toolStripMenuItemStayOnTop.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemStayOnTop.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelTitle
			// 
			this.labelTitle.AccessibleDescription = "Show the title and the version";
			this.labelTitle.AccessibleName = "Title/version";
			this.labelTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(47, 9);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(165, 30);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "[Title + Version]";
			this.toolTip.SetToolTip(this.labelTitle, "Title/version");
			this.labelTitle.UseCompatibleTextRendering = true;
			this.labelTitle.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTitle.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelTitle.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTitle.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDescription
			// 
			this.labelDescription.AccessibleDescription = "Show the description";
			this.labelDescription.AccessibleName = "Description";
			this.labelDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(47, 39);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(67, 17);
			this.labelDescription.TabIndex = 1;
			this.labelDescription.Text = "[Description]";
			this.toolTip.SetToolTip(this.labelDescription, "Description");
			this.labelDescription.UseCompatibleTextRendering = true;
			this.labelDescription.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDescription.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDescription.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDescription.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelCopyright
			// 
			this.labelCopyright.AccessibleDescription = "Show the copyright and the company name";
			this.labelCopyright.AccessibleName = "Copyright/company";
			this.labelCopyright.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCopyright.AutoSize = true;
			this.labelCopyright.Location = new System.Drawing.Point(47, 56);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(120, 17);
			this.labelCopyright.TabIndex = 2;
			this.labelCopyright.Text = "[Copyright + Company]";
			this.toolTip.SetToolTip(this.labelCopyright, "Copyright/company");
			this.labelCopyright.UseCompatibleTextRendering = true;
			this.labelCopyright.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCopyright.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCopyright.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCopyright.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerDateOfTheBirth
			// 
			this.dateTimePickerDateOfTheBirth.AccessibleDescription = "Show the date of the birth";
			this.dateTimePickerDateOfTheBirth.AccessibleName = "Date of the birth";
			this.dateTimePickerDateOfTheBirth.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.dateTimePickerDateOfTheBirth.ContextMenuStrip = this.contextMenuStripDateContext;
			this.dateTimePickerDateOfTheBirth.Location = new System.Drawing.Point(95, 6);
			this.dateTimePickerDateOfTheBirth.Name = "dateTimePickerDateOfTheBirth";
			this.dateTimePickerDateOfTheBirth.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerDateOfTheBirth.TabIndex = 1;
			this.toolTip.SetToolTip(this.dateTimePickerDateOfTheBirth, "date of the birth");
			this.dateTimePickerDateOfTheBirth.ValueChanged += new System.EventHandler(this.DateTimePickerDateOfTheBirth_ValueChanged);
			this.dateTimePickerDateOfTheBirth.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerDateOfTheBirth.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerDateOfTheBirth.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerDateOfTheBirth.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// contextMenuStripDateContext
			// 
			this.contextMenuStripDateContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSwitch,
            this.toolStripMenuItemInsertDateToday,
            this.toolStripMenuItemCopyDateToClipboard});
			this.contextMenuStripDateContext.Name = "contextMenuStripDateContext";
			this.contextMenuStripDateContext.Size = new System.Drawing.Size(206, 70);
			this.contextMenuStripDateContext.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.contextMenuStripDateContext.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemSwitch
			// 
			this.toolStripMenuItemSwitch.AutoToolTip = true;
			this.toolStripMenuItemSwitch.Image = global::DaysCounter.Properties.Resources.switch_small;
			this.toolStripMenuItemSwitch.Name = "toolStripMenuItemSwitch";
			this.toolStripMenuItemSwitch.Size = new System.Drawing.Size(205, 22);
			this.toolStripMenuItemSwitch.Text = "Switch the input method";
			this.toolStripMenuItemSwitch.Click += new System.EventHandler(this.ToolStripMenuItemSwitch_Click);
			this.toolStripMenuItemSwitch.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemSwitch.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemInsertDateToday
			// 
			this.toolStripMenuItemInsertDateToday.AutoToolTip = true;
			this.toolStripMenuItemInsertDateToday.Image = global::DaysCounter.Properties.Resources.calendar_small;
			this.toolStripMenuItemInsertDateToday.Name = "toolStripMenuItemInsertDateToday";
			this.toolStripMenuItemInsertDateToday.Size = new System.Drawing.Size(205, 22);
			this.toolStripMenuItemInsertDateToday.Text = "Insert date today";
			this.toolStripMenuItemInsertDateToday.Click += new System.EventHandler(this.ToolStripMenuItemInsertDateToday_Click);
			this.toolStripMenuItemInsertDateToday.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemInsertDateToday.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// toolStripMenuItemCopyDateToClipboard
			// 
			this.toolStripMenuItemCopyDateToClipboard.AutoToolTip = true;
			this.toolStripMenuItemCopyDateToClipboard.Image = global::DaysCounter.Properties.Resources.document_small;
			this.toolStripMenuItemCopyDateToClipboard.Name = "toolStripMenuItemCopyDateToClipboard";
			this.toolStripMenuItemCopyDateToClipboard.Size = new System.Drawing.Size(205, 22);
			this.toolStripMenuItemCopyDateToClipboard.Text = "Copy date to clipboard";
			this.toolStripMenuItemCopyDateToClipboard.Click += new System.EventHandler(this.ToolStripMenuItemCopyDateToClipboard_Click);
			this.toolStripMenuItemCopyDateToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.toolStripMenuItemCopyDateToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateOfTheBirth
			// 
			this.labelDateOfTheBirth.AccessibleDescription = "Show the description of the date of the birth";
			this.labelDateOfTheBirth.AccessibleName = "Description of the date of the birth";
			this.labelDateOfTheBirth.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDateOfTheBirth.AutoSize = true;
			this.labelDateOfTheBirth.Location = new System.Drawing.Point(3, 10);
			this.labelDateOfTheBirth.Name = "labelDateOfTheBirth";
			this.labelDateOfTheBirth.Size = new System.Drawing.Size(86, 13);
			this.labelDateOfTheBirth.TabIndex = 0;
			this.labelDateOfTheBirth.Text = "Date of the &birth:";
			this.toolTip.SetToolTip(this.labelDateOfTheBirth, "Description of the date of the birth");
			this.labelDateOfTheBirth.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateOfTheBirth.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateOfTheBirth.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateOfTheBirth.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerDateIn
			// 
			this.dateTimePickerDateIn.AccessibleDescription = "Show the beginning date";
			this.dateTimePickerDateIn.AccessibleName = "Beginning date";
			this.dateTimePickerDateIn.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.dateTimePickerDateIn.ContextMenuStrip = this.contextMenuStripDateContext;
			this.dateTimePickerDateIn.Location = new System.Drawing.Point(66, 6);
			this.dateTimePickerDateIn.Name = "dateTimePickerDateIn";
			this.dateTimePickerDateIn.Size = new System.Drawing.Size(199, 20);
			this.dateTimePickerDateIn.TabIndex = 1;
			this.toolTip.SetToolTip(this.dateTimePickerDateIn, "Beginning date");
			this.dateTimePickerDateIn.ValueChanged += new System.EventHandler(this.DateTimePickerDateIn_ValueChanged);
			this.dateTimePickerDateIn.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerDateIn.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerDateIn.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerDateIn.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// numericUpDownDays
			// 
			this.numericUpDownDays.AccessibleDescription = "Change the day span";
			this.numericUpDownDays.AccessibleName = "Day span";
			this.numericUpDownDays.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.numericUpDownDays.Location = new System.Drawing.Point(66, 32);
			this.numericUpDownDays.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDownDays.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numericUpDownDays.Name = "numericUpDownDays";
			this.numericUpDownDays.Size = new System.Drawing.Size(75, 20);
			this.numericUpDownDays.TabIndex = 6;
			this.numericUpDownDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.numericUpDownDays, "Day span");
			this.numericUpDownDays.ValueChanged += new System.EventHandler(this.NumericUpDownDays_ValueChanged);
			this.numericUpDownDays.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericUpDownDays.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerDateOut
			// 
			this.dateTimePickerDateOut.AccessibleDescription = "Show the ending date";
			this.dateTimePickerDateOut.AccessibleName = "Ending date";
			this.dateTimePickerDateOut.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.dateTimePickerDateOut.Enabled = false;
			this.dateTimePickerDateOut.Location = new System.Drawing.Point(66, 58);
			this.dateTimePickerDateOut.Name = "dateTimePickerDateOut";
			this.dateTimePickerDateOut.Size = new System.Drawing.Size(199, 20);
			this.dateTimePickerDateOut.TabIndex = 8;
			this.toolTip.SetToolTip(this.dateTimePickerDateOut, "Ending date");
			this.dateTimePickerDateOut.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerDateOut.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerDateOut.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerDateOut.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateIn
			// 
			this.labelDateIn.AccessibleDescription = "Show the description of the beginning date";
			this.labelDateIn.AccessibleName = "Description of the beginning date";
			this.labelDateIn.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDateIn.AutoSize = true;
			this.labelDateIn.Location = new System.Drawing.Point(8, 10);
			this.labelDateIn.Name = "labelDateIn";
			this.labelDateIn.Size = new System.Drawing.Size(44, 13);
			this.labelDateIn.TabIndex = 0;
			this.labelDateIn.Text = "Date &in:";
			this.toolTip.SetToolTip(this.labelDateIn, "Description of the beginning date");
			this.labelDateIn.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateIn.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateIn.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateIn.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateOut
			// 
			this.labelDateOut.AccessibleDescription = "Show the description of the ending date";
			this.labelDateOut.AccessibleName = "Description of the ending date";
			this.labelDateOut.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDateOut.AutoSize = true;
			this.labelDateOut.Location = new System.Drawing.Point(8, 62);
			this.labelDateOut.Name = "labelDateOut";
			this.labelDateOut.Size = new System.Drawing.Size(51, 13);
			this.labelDateOut.TabIndex = 7;
			this.labelDateOut.Text = "Date &out:";
			this.toolTip.SetToolTip(this.labelDateOut, "Description of the ending date");
			this.labelDateOut.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateOut.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateOut.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateOut.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.AccessibleDescription = "Show the ending date";
			this.dateTimePickerEnd.AccessibleName = "Ending date";
			this.dateTimePickerEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.dateTimePickerEnd.ContextMenuStrip = this.contextMenuStripDateContext;
			this.dateTimePickerEnd.Location = new System.Drawing.Point(49, 32);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerEnd.TabIndex = 6;
			this.toolTip.SetToolTip(this.dateTimePickerEnd, "Ending date");
			this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.DateTimePickerEnd_ValueChanged);
			this.dateTimePickerEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerBegin
			// 
			this.dateTimePickerBegin.AccessibleDescription = "Show the beginning date";
			this.dateTimePickerBegin.AccessibleName = "Beginning date";
			this.dateTimePickerBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.dateTimePickerBegin.ContextMenuStrip = this.contextMenuStripDateContext;
			this.dateTimePickerBegin.Location = new System.Drawing.Point(49, 6);
			this.dateTimePickerBegin.Name = "dateTimePickerBegin";
			this.dateTimePickerBegin.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerBegin.TabIndex = 1;
			this.toolTip.SetToolTip(this.dateTimePickerBegin, "Beginning");
			this.dateTimePickerBegin.ValueChanged += new System.EventHandler(this.DateTimePickerBegin_ValueChanged);
			this.dateTimePickerBegin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerBegin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerBegin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerBegin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateBegin
			// 
			this.labelDateBegin.AccessibleDescription = "Show the description of the beginning date";
			this.labelDateBegin.AccessibleName = "Description of the beginning date";
			this.labelDateBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDateBegin.AutoSize = true;
			this.labelDateBegin.Location = new System.Drawing.Point(8, 10);
			this.labelDateBegin.Name = "labelDateBegin";
			this.labelDateBegin.Size = new System.Drawing.Size(33, 13);
			this.labelDateBegin.TabIndex = 0;
			this.labelDateBegin.Text = "&From:";
			this.toolTip.SetToolTip(this.labelDateBegin, "Description of the first date");
			this.labelDateBegin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateBegin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateBegin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateBegin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateEnd
			// 
			this.labelDateEnd.AccessibleDescription = "Show the description of the ending date";
			this.labelDateEnd.AccessibleName = "Description of the ending date";
			this.labelDateEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDateEnd.AutoSize = true;
			this.labelDateEnd.Location = new System.Drawing.Point(8, 36);
			this.labelDateEnd.Name = "labelDateEnd";
			this.labelDateEnd.Size = new System.Drawing.Size(23, 13);
			this.labelDateEnd.TabIndex = 5;
			this.labelDateEnd.Text = "&To:";
			this.toolTip.SetToolTip(this.labelDateEnd, "Description of the second date");
			this.labelDateEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDays
			// 
			this.labelDays.AccessibleDescription = "Show the description of the counted days";
			this.labelDays.AccessibleName = "Description of the counted days";
			this.labelDays.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDays.AutoSize = true;
			this.labelDays.Location = new System.Drawing.Point(8, 59);
			this.labelDays.Name = "labelDays";
			this.labelDays.Size = new System.Drawing.Size(34, 13);
			this.labelDays.TabIndex = 10;
			this.labelDays.Text = "&Days:";
			this.toolTip.SetToolTip(this.labelDays, "Description of the counted days");
			this.labelDays.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDays.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDays.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDays.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDaysCounted
			// 
			this.labelDaysCounted.AccessibleDescription = "Show the the counted days";
			this.labelDaysCounted.AccessibleName = "Counted days";
			this.labelDaysCounted.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDaysCounted.AutoSize = true;
			this.labelDaysCounted.Location = new System.Drawing.Point(51, 59);
			this.labelDaysCounted.Name = "labelDaysCounted";
			this.labelDaysCounted.Size = new System.Drawing.Size(105, 13);
			this.labelDaysCounted.TabIndex = 11;
			this.labelDaysCounted.Text = "They are xxxxx days.";
			this.toolTip.SetToolTip(this.labelDaysCounted, "Counted days");
			this.labelDaysCounted.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysCounted.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDaysCounted.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysCounted.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDaysOld
			// 
			this.labelDaysOld.AccessibleDescription = "Show how old you are in days";
			this.labelDaysOld.AccessibleName = "How old you are in days";
			this.labelDaysOld.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDaysOld.AutoSize = true;
			this.labelDaysOld.Location = new System.Drawing.Point(92, 40);
			this.labelDaysOld.Name = "labelDaysOld";
			this.labelDaysOld.Size = new System.Drawing.Size(117, 13);
			this.labelDaysOld.TabIndex = 5;
			this.labelDaysOld.Text = "You are xxxxx days old.";
			this.toolTip.SetToolTip(this.labelDaysOld, "How old you are in days");
			this.labelDaysOld.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysOld.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDaysOld.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysOld.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDaysSpan
			// 
			this.labelDaysSpan.AccessibleDescription = "Show the description of the counted days";
			this.labelDaysSpan.AccessibleName = "Description of the counted days";
			this.labelDaysSpan.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDaysSpan.AutoSize = true;
			this.labelDaysSpan.Location = new System.Drawing.Point(3, 40);
			this.labelDaysSpan.Name = "labelDaysSpan";
			this.labelDaysSpan.Size = new System.Drawing.Size(34, 13);
			this.labelDaysSpan.TabIndex = 4;
			this.labelDaysSpan.Text = "&Days:";
			this.toolTip.SetToolTip(this.labelDaysSpan, "Description of the counted days");
			this.labelDaysSpan.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysSpan.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDaysSpan.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysSpan.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSwitchDateEnd
			// 
			this.buttonSwitchDateEnd.AccessibleDescription = "Switch the input method of the ending date";
			this.buttonSwitchDateEnd.AccessibleName = "Change the input method of the ending date";
			this.buttonSwitchDateEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSwitchDateEnd.Image = global::DaysCounter.Properties.Resources.switch_small;
			this.buttonSwitchDateEnd.Location = new System.Drawing.Point(255, 32);
			this.buttonSwitchDateEnd.Name = "buttonSwitchDateEnd";
			this.buttonSwitchDateEnd.Size = new System.Drawing.Size(20, 20);
			this.buttonSwitchDateEnd.TabIndex = 7;
			this.toolTip.SetToolTip(this.buttonSwitchDateEnd, "Change the input method of the ending date");
			this.buttonSwitchDateEnd.UseVisualStyleBackColor = true;
			this.buttonSwitchDateEnd.Click += new System.EventHandler(this.ButtonSwitchDateEnd_Click);
			this.buttonSwitchDateEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSwitchDateEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSwitchDateBegin
			// 
			this.buttonSwitchDateBegin.AccessibleDescription = "Switch the input method of the beginning date";
			this.buttonSwitchDateBegin.AccessibleName = "Change the input method of the beginning date";
			this.buttonSwitchDateBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSwitchDateBegin.Image = global::DaysCounter.Properties.Resources.switch_small;
			this.buttonSwitchDateBegin.Location = new System.Drawing.Point(255, 6);
			this.buttonSwitchDateBegin.Name = "buttonSwitchDateBegin";
			this.buttonSwitchDateBegin.Size = new System.Drawing.Size(20, 20);
			this.buttonSwitchDateBegin.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonSwitchDateBegin, "Change the input method of the beginning date");
			this.buttonSwitchDateBegin.UseVisualStyleBackColor = true;
			this.buttonSwitchDateBegin.Click += new System.EventHandler(this.ButtonSwitchDateBegin_Click);
			this.buttonSwitchDateBegin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateBegin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSwitchDateBegin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateBegin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSwitchDateIn
			// 
			this.buttonSwitchDateIn.AccessibleDescription = "Switch the input method of the beginning date";
			this.buttonSwitchDateIn.AccessibleName = "Change the input method of the ending date";
			this.buttonSwitchDateIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSwitchDateIn.Image = global::DaysCounter.Properties.Resources.switch_small;
			this.buttonSwitchDateIn.Location = new System.Drawing.Point(271, 6);
			this.buttonSwitchDateIn.Name = "buttonSwitchDateIn";
			this.buttonSwitchDateIn.Size = new System.Drawing.Size(20, 20);
			this.buttonSwitchDateIn.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonSwitchDateIn, "Change the input method of the ending date");
			this.buttonSwitchDateIn.UseVisualStyleBackColor = true;
			this.buttonSwitchDateIn.Click += new System.EventHandler(this.ButtonSwitchDateDays_Click);
			this.buttonSwitchDateIn.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateIn.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSwitchDateIn.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateIn.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSwitchDateOfTheBirth
			// 
			this.buttonSwitchDateOfTheBirth.AccessibleDescription = "Switch the input method of the date of the birth";
			this.buttonSwitchDateOfTheBirth.AccessibleName = "Change the input method of the date of the birth";
			this.buttonSwitchDateOfTheBirth.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSwitchDateOfTheBirth.Image = global::DaysCounter.Properties.Resources.switch_small;
			this.buttonSwitchDateOfTheBirth.Location = new System.Drawing.Point(301, 6);
			this.buttonSwitchDateOfTheBirth.Name = "buttonSwitchDateOfTheBirth";
			this.buttonSwitchDateOfTheBirth.Size = new System.Drawing.Size(20, 20);
			this.buttonSwitchDateOfTheBirth.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonSwitchDateOfTheBirth, "Change the input method of the date of the birth");
			this.buttonSwitchDateOfTheBirth.UseVisualStyleBackColor = true;
			this.buttonSwitchDateOfTheBirth.Click += new System.EventHandler(this.ButtonSwitchDateOfTheBirth_Click);
			this.buttonSwitchDateOfTheBirth.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateOfTheBirth.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSwitchDateOfTheBirth.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateOfTheBirth.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonInsertDateTodayBegin
			// 
			this.buttonInsertDateTodayBegin.AccessibleDescription = "Switch the input method of the beginning date";
			this.buttonInsertDateTodayBegin.AccessibleName = "Change the input method of the beginning date";
			this.buttonInsertDateTodayBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonInsertDateTodayBegin.Image = global::DaysCounter.Properties.Resources.calendar_small;
			this.buttonInsertDateTodayBegin.Location = new System.Drawing.Point(281, 6);
			this.buttonInsertDateTodayBegin.Name = "buttonInsertDateTodayBegin";
			this.buttonInsertDateTodayBegin.Size = new System.Drawing.Size(20, 20);
			this.buttonInsertDateTodayBegin.TabIndex = 3;
			this.toolTip.SetToolTip(this.buttonInsertDateTodayBegin, "Change the input method of the beginning date");
			this.buttonInsertDateTodayBegin.UseVisualStyleBackColor = true;
			this.buttonInsertDateTodayBegin.Click += new System.EventHandler(this.ButtonInsertDateTodayBegin_Click);
			this.buttonInsertDateTodayBegin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInsertDateTodayBegin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonInsertDateTodayBegin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInsertDateTodayBegin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCopyDateBegin
			// 
			this.buttonCopyDateBegin.AccessibleDescription = "Switch the input method of the beginning date";
			this.buttonCopyDateBegin.AccessibleName = "Change the input method of the beginning date";
			this.buttonCopyDateBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCopyDateBegin.Image = global::DaysCounter.Properties.Resources.document_small;
			this.buttonCopyDateBegin.Location = new System.Drawing.Point(307, 6);
			this.buttonCopyDateBegin.Name = "buttonCopyDateBegin";
			this.buttonCopyDateBegin.Size = new System.Drawing.Size(20, 20);
			this.buttonCopyDateBegin.TabIndex = 4;
			this.toolTip.SetToolTip(this.buttonCopyDateBegin, "Change the input method of the beginning date");
			this.buttonCopyDateBegin.UseVisualStyleBackColor = true;
			this.buttonCopyDateBegin.Click += new System.EventHandler(this.ButtonCopyDateBegin_Click);
			this.buttonCopyDateBegin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyDateBegin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCopyDateBegin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyDateBegin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCopyDateEnd
			// 
			this.buttonCopyDateEnd.AccessibleDescription = "Switch the input method of the beginning date";
			this.buttonCopyDateEnd.AccessibleName = "Change the input method of the beginning date";
			this.buttonCopyDateEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCopyDateEnd.Image = global::DaysCounter.Properties.Resources.document_small;
			this.buttonCopyDateEnd.Location = new System.Drawing.Point(307, 32);
			this.buttonCopyDateEnd.Name = "buttonCopyDateEnd";
			this.buttonCopyDateEnd.Size = new System.Drawing.Size(20, 20);
			this.buttonCopyDateEnd.TabIndex = 9;
			this.toolTip.SetToolTip(this.buttonCopyDateEnd, "Change the input method of the beginning date");
			this.buttonCopyDateEnd.UseVisualStyleBackColor = true;
			this.buttonCopyDateEnd.Click += new System.EventHandler(this.ButtonCopyDateEnd_Click);
			this.buttonCopyDateEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyDateEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCopyDateEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyDateEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonInsertDateTodayEnd
			// 
			this.buttonInsertDateTodayEnd.AccessibleDescription = "Switch the input method of the beginning date";
			this.buttonInsertDateTodayEnd.AccessibleName = "Change the input method of the beginning date";
			this.buttonInsertDateTodayEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonInsertDateTodayEnd.Image = global::DaysCounter.Properties.Resources.calendar_small;
			this.buttonInsertDateTodayEnd.Location = new System.Drawing.Point(281, 32);
			this.buttonInsertDateTodayEnd.Name = "buttonInsertDateTodayEnd";
			this.buttonInsertDateTodayEnd.Size = new System.Drawing.Size(20, 20);
			this.buttonInsertDateTodayEnd.TabIndex = 8;
			this.toolTip.SetToolTip(this.buttonInsertDateTodayEnd, "Change the input method of the beginning date");
			this.buttonInsertDateTodayEnd.UseVisualStyleBackColor = true;
			this.buttonInsertDateTodayEnd.Click += new System.EventHandler(this.ButtonInsertDateTodayEnd_Click);
			this.buttonInsertDateTodayEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInsertDateTodayEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonInsertDateTodayEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInsertDateTodayEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCopyDateIn
			// 
			this.buttonCopyDateIn.AccessibleDescription = "Switch the input method of the beginning date";
			this.buttonCopyDateIn.AccessibleName = "Change the input method of the beginning date";
			this.buttonCopyDateIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCopyDateIn.Image = global::DaysCounter.Properties.Resources.document_small;
			this.buttonCopyDateIn.Location = new System.Drawing.Point(323, 6);
			this.buttonCopyDateIn.Name = "buttonCopyDateIn";
			this.buttonCopyDateIn.Size = new System.Drawing.Size(20, 20);
			this.buttonCopyDateIn.TabIndex = 4;
			this.toolTip.SetToolTip(this.buttonCopyDateIn, "Change the input method of the beginning date");
			this.buttonCopyDateIn.UseVisualStyleBackColor = true;
			this.buttonCopyDateIn.Click += new System.EventHandler(this.ButtonCopyDateIn_Click);
			this.buttonCopyDateIn.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyDateIn.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCopyDateIn.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyDateIn.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonInsertDateIn
			// 
			this.buttonInsertDateIn.AccessibleDescription = "Switch the input method of the beginning date";
			this.buttonInsertDateIn.AccessibleName = "Change the input method of the beginning date";
			this.buttonInsertDateIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonInsertDateIn.Image = global::DaysCounter.Properties.Resources.calendar_small;
			this.buttonInsertDateIn.Location = new System.Drawing.Point(297, 6);
			this.buttonInsertDateIn.Name = "buttonInsertDateIn";
			this.buttonInsertDateIn.Size = new System.Drawing.Size(20, 20);
			this.buttonInsertDateIn.TabIndex = 3;
			this.toolTip.SetToolTip(this.buttonInsertDateIn, "Change the input method of the beginning date");
			this.buttonInsertDateIn.UseVisualStyleBackColor = true;
			this.buttonInsertDateIn.Click += new System.EventHandler(this.ButtonInsertDateIn_Click);
			this.buttonInsertDateIn.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInsertDateIn.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonInsertDateIn.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonInsertDateIn.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCopyDateOut
			// 
			this.buttonCopyDateOut.AccessibleDescription = "Switch the input method of the beginning date";
			this.buttonCopyDateOut.AccessibleName = "Change the input method of the beginning date";
			this.buttonCopyDateOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCopyDateOut.Image = global::DaysCounter.Properties.Resources.document_small;
			this.buttonCopyDateOut.Location = new System.Drawing.Point(271, 58);
			this.buttonCopyDateOut.Name = "buttonCopyDateOut";
			this.buttonCopyDateOut.Size = new System.Drawing.Size(20, 20);
			this.buttonCopyDateOut.TabIndex = 9;
			this.toolTip.SetToolTip(this.buttonCopyDateOut, "Change the input method of the beginning date");
			this.buttonCopyDateOut.UseVisualStyleBackColor = true;
			this.buttonCopyDateOut.Click += new System.EventHandler(this.ButtonCopyDateOut_Click);
			this.buttonCopyDateOut.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyDateOut.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCopyDateOut.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyDateOut.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonCopyDateOfTheBirth
			// 
			this.buttonCopyDateOfTheBirth.AccessibleDescription = "Switch the input method of the beginning date";
			this.buttonCopyDateOfTheBirth.AccessibleName = "Change the input method of the beginning date";
			this.buttonCopyDateOfTheBirth.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonCopyDateOfTheBirth.Image = global::DaysCounter.Properties.Resources.document_small;
			this.buttonCopyDateOfTheBirth.Location = new System.Drawing.Point(323, 6);
			this.buttonCopyDateOfTheBirth.Name = "buttonCopyDateOfTheBirth";
			this.buttonCopyDateOfTheBirth.Size = new System.Drawing.Size(20, 20);
			this.buttonCopyDateOfTheBirth.TabIndex = 3;
			this.toolTip.SetToolTip(this.buttonCopyDateOfTheBirth, "Change the input method of the beginning date");
			this.buttonCopyDateOfTheBirth.UseVisualStyleBackColor = true;
			this.buttonCopyDateOfTheBirth.Click += new System.EventHandler(this.ButtonCopyDateOfTheBirth_Click);
			this.buttonCopyDateOfTheBirth.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyDateOfTheBirth.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonCopyDateOfTheBirth.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonCopyDateOfTheBirth.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// BottomToolStripPanel
			// 
			this.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 371);
			this.BottomToolStripPanel.Name = "BottomToolStripPanel";
			this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.BottomToolStripPanel.Size = new System.Drawing.Size(622, 0);
			// 
			// TopToolStripPanel
			// 
			this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.TopToolStripPanel.Name = "TopToolStripPanel";
			this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.TopToolStripPanel.Size = new System.Drawing.Size(622, 0);
			// 
			// RightToolStripPanel
			// 
			this.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.RightToolStripPanel.Location = new System.Drawing.Point(357, 0);
			this.RightToolStripPanel.Name = "RightToolStripPanel";
			this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.RightToolStripPanel.Size = new System.Drawing.Size(0, 133);
			// 
			// LeftToolStripPanel
			// 
			this.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftToolStripPanel.Name = "LeftToolStripPanel";
			this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 371);
			// 
			// ContentPanel
			// 
			this.ContentPanel.AutoScroll = true;
			this.ContentPanel.Size = new System.Drawing.Size(357, 133);
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.AccessibleDescription = "Group the toolbars and the statusbar";
			this.toolStripContainer.AccessibleName = "Toolbar container";
			this.toolStripContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.AccessibleDescription = "Lower part of the ToolStripContainer";
			this.toolStripContainer.BottomToolStripPanel.AccessibleName = "Lower part of the ToolStripContainer";
			this.toolStripContainer.BottomToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.AccessibleDescription = "Central part of the ToolStripContainer";
			this.toolStripContainer.ContentPanel.AccessibleName = "Central part of the ToolStripContainer";
			this.toolStripContainer.ContentPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.ContentPanel.AutoScroll = true;
			this.toolStripContainer.ContentPanel.Controls.Add(this.tabControl);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(354, 110);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// toolStripContainer.LeftToolStripPanel
			// 
			this.toolStripContainer.LeftToolStripPanel.AccessibleDescription = "Left part of the ToolStripContainer";
			this.toolStripContainer.LeftToolStripPanel.AccessibleName = "Left part of the ToolStripContainer";
			this.toolStripContainer.LeftToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			// 
			// toolStripContainer.RightToolStripPanel
			// 
			this.toolStripContainer.RightToolStripPanel.AccessibleDescription = "Right part of the ToolStripContainer";
			this.toolStripContainer.RightToolStripPanel.AccessibleName = "Right part of the ToolStripContainer";
			this.toolStripContainer.RightToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.toolStripContainer.Size = new System.Drawing.Size(354, 132);
			this.toolStripContainer.TabIndex = 6;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.AccessibleDescription = "Upper part of the ToolStripContainer";
			this.toolStripContainer.TopToolStripPanel.AccessibleName = "Upper part of the ToolStripContainer";
			this.toolStripContainer.TopToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			// 
			// tabControl
			// 
			this.tabControl.AccessibleDescription = "Show the tabs";
			this.tabControl.AccessibleName = "Show the tabs";
			this.tabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
			this.tabControl.Controls.Add(this.tabPageDateToDate);
			this.tabControl.Controls.Add(this.tabPageDaySpan);
			this.tabControl.Controls.Add(this.tabPageDaysOfLife);
			this.tabControl.Controls.Add(this.tabPageAbout);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.HotTrack = true;
			this.tabControl.ImageList = this.imageList;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.ShowToolTips = true;
			this.tabControl.Size = new System.Drawing.Size(354, 110);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageDateToDate
			// 
			this.tabPageDateToDate.AccessibleDescription = "Show the tab \"From date to date\"";
			this.tabPageDateToDate.AccessibleName = "Tab \"From date to date\"";
			this.tabPageDateToDate.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
			this.tabPageDateToDate.Controls.Add(this.buttonCopyDateEnd);
			this.tabPageDateToDate.Controls.Add(this.buttonInsertDateTodayEnd);
			this.tabPageDateToDate.Controls.Add(this.buttonCopyDateBegin);
			this.tabPageDateToDate.Controls.Add(this.buttonInsertDateTodayBegin);
			this.tabPageDateToDate.Controls.Add(this.labelDaysCounted);
			this.tabPageDateToDate.Controls.Add(this.labelDays);
			this.tabPageDateToDate.Controls.Add(this.labelDateEnd);
			this.tabPageDateToDate.Controls.Add(this.labelDateBegin);
			this.tabPageDateToDate.Controls.Add(this.dateTimePickerBegin);
			this.tabPageDateToDate.Controls.Add(this.buttonSwitchDateEnd);
			this.tabPageDateToDate.Controls.Add(this.buttonSwitchDateBegin);
			this.tabPageDateToDate.Controls.Add(this.dateTimePickerEnd);
			this.tabPageDateToDate.ImageKey = "calendar-select-days.png";
			this.tabPageDateToDate.Location = new System.Drawing.Point(4, 23);
			this.tabPageDateToDate.Name = "tabPageDateToDate";
			this.tabPageDateToDate.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDateToDate.Size = new System.Drawing.Size(346, 83);
			this.tabPageDateToDate.TabIndex = 0;
			this.tabPageDateToDate.Text = "From date to date";
			this.tabPageDateToDate.UseVisualStyleBackColor = true;
			// 
			// tabPageDaySpan
			// 
			this.tabPageDaySpan.AccessibleDescription = "Show the tab \"Days span\"";
			this.tabPageDaySpan.AccessibleName = "Tab \"Days span\"";
			this.tabPageDaySpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
			this.tabPageDaySpan.Controls.Add(this.buttonCopyDateOut);
			this.tabPageDaySpan.Controls.Add(this.buttonCopyDateIn);
			this.tabPageDaySpan.Controls.Add(this.buttonInsertDateIn);
			this.tabPageDaySpan.Controls.Add(this.labelDateOut);
			this.tabPageDaySpan.Controls.Add(this.labelDateIn);
			this.tabPageDaySpan.Controls.Add(this.dateTimePickerDateOut);
			this.tabPageDaySpan.Controls.Add(this.labelDaysPlusMinus);
			this.tabPageDaySpan.Controls.Add(this.numericUpDownDays);
			this.tabPageDaySpan.Controls.Add(this.dateTimePickerDateIn);
			this.tabPageDaySpan.Controls.Add(this.buttonSwitchDateIn);
			this.tabPageDaySpan.ImageKey = "calendar-select-days-span.png";
			this.tabPageDaySpan.Location = new System.Drawing.Point(4, 23);
			this.tabPageDaySpan.Name = "tabPageDaySpan";
			this.tabPageDaySpan.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDaySpan.Size = new System.Drawing.Size(346, 83);
			this.tabPageDaySpan.TabIndex = 1;
			this.tabPageDaySpan.Text = "Days span";
			this.tabPageDaySpan.UseVisualStyleBackColor = true;
			// 
			// labelDaysPlusMinus
			// 
			this.labelDaysPlusMinus.AccessibleDescription = "Show the description of the ending date";
			this.labelDaysPlusMinus.AccessibleName = "Description of the day span";
			this.labelDaysPlusMinus.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDaysPlusMinus.AutoSize = true;
			this.labelDaysPlusMinus.Location = new System.Drawing.Point(8, 34);
			this.labelDaysPlusMinus.Name = "labelDaysPlusMinus";
			this.labelDaysPlusMinus.Size = new System.Drawing.Size(57, 13);
			this.labelDaysPlusMinus.TabIndex = 5;
			this.labelDaysPlusMinus.Text = "&Days (-/+):";
			this.labelDaysPlusMinus.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysPlusMinus.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDaysPlusMinus.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysPlusMinus.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tabPageDaysOfLife
			// 
			this.tabPageDaysOfLife.AccessibleDescription = "Show the tab \"Days of life\"";
			this.tabPageDaysOfLife.AccessibleName = "Tab \"Days of life\"";
			this.tabPageDaysOfLife.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
			this.tabPageDaysOfLife.Controls.Add(this.buttonCopyDateOfTheBirth);
			this.tabPageDaysOfLife.Controls.Add(this.labelDaysSpan);
			this.tabPageDaysOfLife.Controls.Add(this.labelDaysOld);
			this.tabPageDaysOfLife.Controls.Add(this.labelDateOfTheBirth);
			this.tabPageDaysOfLife.Controls.Add(this.dateTimePickerDateOfTheBirth);
			this.tabPageDaysOfLife.Controls.Add(this.buttonSwitchDateOfTheBirth);
			this.tabPageDaysOfLife.ImageKey = "calendar-select.png";
			this.tabPageDaysOfLife.Location = new System.Drawing.Point(4, 23);
			this.tabPageDaysOfLife.Name = "tabPageDaysOfLife";
			this.tabPageDaysOfLife.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDaysOfLife.Size = new System.Drawing.Size(346, 83);
			this.tabPageDaysOfLife.TabIndex = 3;
			this.tabPageDaysOfLife.Text = "Days of life";
			this.tabPageDaysOfLife.UseVisualStyleBackColor = true;
			// 
			// tabPageAbout
			// 
			this.tabPageAbout.AccessibleDescription = "Show the tab \"About\"";
			this.tabPageAbout.AccessibleName = "Tab \"About\"";
			this.tabPageAbout.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
			this.tabPageAbout.Controls.Add(this.labelCopyright);
			this.tabPageAbout.Controls.Add(this.labelDescription);
			this.tabPageAbout.Controls.Add(this.labelTitle);
			this.tabPageAbout.Controls.Add(this.pictureBox);
			this.tabPageAbout.ImageKey = "information-button.png";
			this.tabPageAbout.Location = new System.Drawing.Point(4, 23);
			this.tabPageAbout.Name = "tabPageAbout";
			this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAbout.Size = new System.Drawing.Size(346, 83);
			this.tabPageAbout.TabIndex = 2;
			this.tabPageAbout.Text = "About";
			this.tabPageAbout.UseVisualStyleBackColor = true;
			// 
			// pictureBox
			// 
			this.pictureBox.AccessibleDescription = "Show the application logo";
			this.pictureBox.AccessibleName = "Apllication logo";
			this.pictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.pictureBox.Image = global::DaysCounter.Properties.Resources.calendar_day;
			this.pictureBox.Location = new System.Drawing.Point(9, 7);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(32, 32);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.pictureBox.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// MainWindow
			// 
			this.AccessibleDescription = "This is the main window of the application";
			this.AccessibleName = "Main window";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 132);
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Days Counter";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.contextMenuStripDateContext.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageDateToDate.ResumeLayout(false);
			this.tabPageDateToDate.PerformLayout();
			this.tabPageDaySpan.ResumeLayout(false);
			this.tabPageDaySpan.PerformLayout();
			this.tabPageDaysOfLife.ResumeLayout(false);
			this.tabPageDaysOfLife.PerformLayout();
			this.tabPageAbout.ResumeLayout(false);
			this.tabPageAbout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageDateToDate;
		private System.Windows.Forms.Label labelDaysCounted;
		private System.Windows.Forms.Label labelDays;
		private System.Windows.Forms.Label labelDateEnd;
		private System.Windows.Forms.Label labelDateBegin;
		private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
		private System.Windows.Forms.Button buttonSwitchDateEnd;
		private System.Windows.Forms.Button buttonSwitchDateBegin;
		private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
		private System.Windows.Forms.TabPage tabPageDaySpan;
		private System.Windows.Forms.Label labelDateOut;
		private System.Windows.Forms.Label labelDateIn;
		private System.Windows.Forms.DateTimePicker dateTimePickerDateOut;
		private System.Windows.Forms.Label labelDaysPlusMinus;
		private System.Windows.Forms.NumericUpDown numericUpDownDays;
		private System.Windows.Forms.DateTimePicker dateTimePickerDateIn;
		private System.Windows.Forms.Button buttonSwitchDateIn;
		private System.Windows.Forms.TabPage tabPageDaysOfLife;
		private System.Windows.Forms.Label labelDaysOld;
		private System.Windows.Forms.Label labelDateOfTheBirth;
		private System.Windows.Forms.DateTimePicker dateTimePickerDateOfTheBirth;
		private System.Windows.Forms.Button buttonSwitchDateOfTheBirth;
		private System.Windows.Forms.TabPage tabPageAbout;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.Label labelDaysSpan;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonStayOnTop;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStayNotOnTop;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStayOnTop;
		private System.Windows.Forms.Button buttonInsertDateTodayBegin;
		private System.Windows.Forms.Button buttonCopyDateBegin;
		private System.Windows.Forms.Button buttonCopyDateEnd;
		private System.Windows.Forms.Button buttonInsertDateTodayEnd;
		private System.Windows.Forms.Button buttonCopyDateOut;
		private System.Windows.Forms.Button buttonCopyDateIn;
		private System.Windows.Forms.Button buttonInsertDateIn;
		private System.Windows.Forms.Button buttonCopyDateOfTheBirth;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripDateContext;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSwitch;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInsertDateToday;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopyDateToClipboard;
	}
}

