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
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.buttonDateOfTheBirth = new System.Windows.Forms.Button();
			this.dateTimePickerDateOfTheBirth = new System.Windows.Forms.DateTimePicker();
			this.labelDateOfTheBirth = new System.Windows.Forms.Label();
			this.buttonSwitchDateIn = new System.Windows.Forms.Button();
			this.dateTimePickerDateIn = new System.Windows.Forms.DateTimePicker();
			this.numericUpDownDays = new System.Windows.Forms.NumericUpDown();
			this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
			this.labelDateIn = new System.Windows.Forms.Label();
			this.labelDateOut = new System.Windows.Forms.Label();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.buttonSwitchDateBegin = new System.Windows.Forms.Button();
			this.buttonSwitchDateEnd = new System.Windows.Forms.Button();
			this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
			this.labelDateBegin = new System.Windows.Forms.Label();
			this.labelDateEnd = new System.Windows.Forms.Label();
			this.labelDays = new System.Windows.Forms.Label();
			this.labelDaysCounted = new System.Windows.Forms.Label();
			this.labelDaysOld = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageDateToDate = new System.Windows.Forms.TabPage();
			this.tabPageDaySpan = new System.Windows.Forms.TabPage();
			this.labelDaysPlusMinus = new System.Windows.Forms.Label();
			this.tabPageDaysOfLife = new System.Windows.Forms.TabPage();
			this.tabPageAbout = new System.Windows.Forms.TabPage();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
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
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Show the statusbar with some information";
			this.statusStrip.AccessibleName = "Statusbar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(357, 22);
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
			this.labelInformation.Size = new System.Drawing.Size(70, 17);
			this.labelInformation.Text = "information";
			this.labelInformation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelInformation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			// buttonDateOfTheBirth
			// 
			this.buttonDateOfTheBirth.AccessibleDescription = "Switch the input method of the date of the birth";
			this.buttonDateOfTheBirth.AccessibleName = "Change the input method of the date of the birth";
			this.buttonDateOfTheBirth.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonDateOfTheBirth.Image = global::DaysCounter.Properties.Resources.switch_small;
			this.buttonDateOfTheBirth.Location = new System.Drawing.Point(306, 6);
			this.buttonDateOfTheBirth.Name = "buttonDateOfTheBirth";
			this.buttonDateOfTheBirth.Size = new System.Drawing.Size(20, 20);
			this.buttonDateOfTheBirth.TabIndex = 2;
			this.toolTip.SetToolTip(this.buttonDateOfTheBirth, "Change the input method of the date of the birth");
			this.buttonDateOfTheBirth.UseVisualStyleBackColor = true;
			this.buttonDateOfTheBirth.Click += new System.EventHandler(this.ButtonDateOfTheBirth_Click);
			this.buttonDateOfTheBirth.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDateOfTheBirth.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonDateOfTheBirth.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonDateOfTheBirth.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerDateOfTheBirth
			// 
			this.dateTimePickerDateOfTheBirth.AccessibleDescription = "Show the date of the birth";
			this.dateTimePickerDateOfTheBirth.AccessibleName = "Date of the birth";
			this.dateTimePickerDateOfTheBirth.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
			this.dateTimePickerDateOfTheBirth.Location = new System.Drawing.Point(100, 6);
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
			// labelDateOfTheBirth
			// 
			this.labelDateOfTheBirth.AccessibleDescription = "Show the description of the date of the birth";
			this.labelDateOfTheBirth.AccessibleName = "Description of the date of the birth";
			this.labelDateOfTheBirth.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDateOfTheBirth.AutoSize = true;
			this.labelDateOfTheBirth.Location = new System.Drawing.Point(8, 10);
			this.labelDateOfTheBirth.Name = "labelDateOfTheBirth";
			this.labelDateOfTheBirth.Size = new System.Drawing.Size(86, 13);
			this.labelDateOfTheBirth.TabIndex = 0;
			this.labelDateOfTheBirth.Text = "&Date of the birth:";
			this.toolTip.SetToolTip(this.labelDateOfTheBirth, "Description of the date of the birth");
			this.labelDateOfTheBirth.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateOfTheBirth.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateOfTheBirth.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateOfTheBirth.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			// dateTimePickerDateIn
			// 
			this.dateTimePickerDateIn.AccessibleDescription = "Show the beginning date";
			this.dateTimePickerDateIn.AccessibleName = "Beginning date";
			this.dateTimePickerDateIn.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
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
			this.numericUpDownDays.TabIndex = 4;
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
			this.dateTimePickerDateOut.TabIndex = 6;
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
			this.labelDateOut.TabIndex = 5;
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
			this.dateTimePickerEnd.Location = new System.Drawing.Point(49, 32);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerEnd.TabIndex = 4;
			this.toolTip.SetToolTip(this.dateTimePickerEnd, "Ending date");
			this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.DateTimePickerEnd_ValueChanged);
			this.dateTimePickerEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			// buttonSwitchDateEnd
			// 
			this.buttonSwitchDateEnd.AccessibleDescription = "Switch the input method of the ending date";
			this.buttonSwitchDateEnd.AccessibleName = "Change the input method of the ending date";
			this.buttonSwitchDateEnd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSwitchDateEnd.Image = global::DaysCounter.Properties.Resources.switch_small;
			this.buttonSwitchDateEnd.Location = new System.Drawing.Point(255, 32);
			this.buttonSwitchDateEnd.Name = "buttonSwitchDateEnd";
			this.buttonSwitchDateEnd.Size = new System.Drawing.Size(20, 20);
			this.buttonSwitchDateEnd.TabIndex = 5;
			this.toolTip.SetToolTip(this.buttonSwitchDateEnd, "Change the input method of the ending date");
			this.buttonSwitchDateEnd.UseVisualStyleBackColor = true;
			this.buttonSwitchDateEnd.Click += new System.EventHandler(this.ButtonSwitchDateEnd_Click);
			this.buttonSwitchDateEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSwitchDateEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerBegin
			// 
			this.dateTimePickerBegin.AccessibleDescription = "Show the beginning date";
			this.dateTimePickerBegin.AccessibleName = "Beginning date";
			this.dateTimePickerBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
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
			this.labelDateEnd.TabIndex = 3;
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
			this.labelDays.TabIndex = 6;
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
			this.labelDaysCounted.TabIndex = 7;
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
			this.labelDaysOld.Location = new System.Drawing.Point(97, 40);
			this.labelDaysOld.Name = "labelDaysOld";
			this.labelDaysOld.Size = new System.Drawing.Size(117, 13);
			this.labelDaysOld.TabIndex = 4;
			this.labelDaysOld.Text = "You are xxxxx days old.";
			this.toolTip.SetToolTip(this.labelDaysOld, "How old you are in days");
			this.labelDaysOld.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysOld.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDaysOld.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysOld.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// label1
			// 
			this.label1.AccessibleDescription = "Show the description of the counted days";
			this.label1.AccessibleName = "Description of the counted days";
			this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "&Days:";
			this.toolTip.SetToolTip(this.label1, "Description of the counted days");
			this.label1.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.label1.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.label1.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.label1.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
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
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.AutoScroll = true;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(357, 111);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(357, 133);
			this.toolStripContainer1.TabIndex = 6;
			this.toolStripContainer1.Text = "toolStripContainer1";
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
			this.tabControl.Size = new System.Drawing.Size(357, 111);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageDateToDate
			// 
			this.tabPageDateToDate.AccessibleDescription = "Show the tab \"From date to date\"";
			this.tabPageDateToDate.AccessibleName = "Tab \"From date to date\"";
			this.tabPageDateToDate.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
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
			this.tabPageDateToDate.Size = new System.Drawing.Size(349, 84);
			this.tabPageDateToDate.TabIndex = 0;
			this.tabPageDateToDate.Text = "From date to date";
			this.tabPageDateToDate.UseVisualStyleBackColor = true;
			// 
			// tabPageDaySpan
			// 
			this.tabPageDaySpan.AccessibleDescription = "Show the tab \"Days span\"";
			this.tabPageDaySpan.AccessibleName = "Tab \"Days span\"";
			this.tabPageDaySpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
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
			this.tabPageDaySpan.Size = new System.Drawing.Size(349, 59);
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
			this.labelDaysPlusMinus.Size = new System.Drawing.Size(54, 13);
			this.labelDaysPlusMinus.TabIndex = 3;
			this.labelDaysPlusMinus.Text = "Da&ys (-/+)";
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
			this.tabPageDaysOfLife.Controls.Add(this.label1);
			this.tabPageDaysOfLife.Controls.Add(this.labelDaysOld);
			this.tabPageDaysOfLife.Controls.Add(this.labelDateOfTheBirth);
			this.tabPageDaysOfLife.Controls.Add(this.dateTimePickerDateOfTheBirth);
			this.tabPageDaysOfLife.Controls.Add(this.buttonDateOfTheBirth);
			this.tabPageDaysOfLife.ImageKey = "calendar-select.png";
			this.tabPageDaysOfLife.Location = new System.Drawing.Point(4, 23);
			this.tabPageDaysOfLife.Name = "tabPageDaysOfLife";
			this.tabPageDaysOfLife.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDaysOfLife.Size = new System.Drawing.Size(349, 59);
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
			this.tabPageAbout.Size = new System.Drawing.Size(349, 59);
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
			this.AccessibleDescription = "This ist the main window of the application";
			this.AccessibleName = "Main window";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 133);
			this.Controls.Add(this.toolStripContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Days Counter";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
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
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
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
		private System.Windows.Forms.Button buttonDateOfTheBirth;
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
		private System.Windows.Forms.Label label1;
	}
}

