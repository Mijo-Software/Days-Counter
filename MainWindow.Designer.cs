namespace Days_Counter
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
			this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageDateToDate = new System.Windows.Forms.TabPage();
			this.labelDaysCounted = new System.Windows.Forms.Label();
			this.labelDays = new System.Windows.Forms.Label();
			this.labelDateEnd = new System.Windows.Forms.Label();
			this.labelDateBegin = new System.Windows.Forms.Label();
			this.tabPageDaySpan = new System.Windows.Forms.TabPage();
			this.labelDateOut = new System.Windows.Forms.Label();
			this.labelDateIn = new System.Windows.Forms.Label();
			this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
			this.labelDaysPlusMinus = new System.Windows.Forms.Label();
			this.numericUpDownDays = new System.Windows.Forms.NumericUpDown();
			this.dateTimePickerDateIn = new System.Windows.Forms.DateTimePicker();
			this.tabPageAbout = new System.Windows.Forms.TabPage();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.labelInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.buttonSwitchDateEnd = new System.Windows.Forms.Button();
			this.buttonSwitchDateBegin = new System.Windows.Forms.Button();
			this.buttonSwitchDateIn = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.tabControl.SuspendLayout();
			this.tabPageDateToDate.SuspendLayout();
			this.tabPageDaySpan.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
			this.tabPageAbout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePickerBegin
			// 
			this.dateTimePickerBegin.Location = new System.Drawing.Point(49, 6);
			this.dateTimePickerBegin.Name = "dateTimePickerBegin";
			this.dateTimePickerBegin.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerBegin.TabIndex = 1;
			this.dateTimePickerBegin.ValueChanged += new System.EventHandler(this.DateTimePickerBegin_ValueChanged);
			this.dateTimePickerBegin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerBegin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerBegin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerBegin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.Location = new System.Drawing.Point(49, 32);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerEnd.TabIndex = 4;
			this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.DateTimePickerEnd_ValueChanged);
			this.dateTimePickerEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageDateToDate);
			this.tabControl.Controls.Add(this.tabPageDaySpan);
			this.tabControl.Controls.Add(this.tabPageAbout);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.ImageList = this.imageList;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(291, 111);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageDateToDate
			// 
			this.tabPageDateToDate.Controls.Add(this.labelDaysCounted);
			this.tabPageDateToDate.Controls.Add(this.labelDays);
			this.tabPageDateToDate.Controls.Add(this.labelDateEnd);
			this.tabPageDateToDate.Controls.Add(this.labelDateBegin);
			this.tabPageDateToDate.Controls.Add(this.dateTimePickerBegin);
			this.tabPageDateToDate.Controls.Add(this.buttonSwitchDateEnd);
			this.tabPageDateToDate.Controls.Add(this.buttonSwitchDateBegin);
			this.tabPageDateToDate.Controls.Add(this.dateTimePickerEnd);
			this.tabPageDateToDate.ImageIndex = 0;
			this.tabPageDateToDate.Location = new System.Drawing.Point(4, 23);
			this.tabPageDateToDate.Name = "tabPageDateToDate";
			this.tabPageDateToDate.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDateToDate.Size = new System.Drawing.Size(283, 84);
			this.tabPageDateToDate.TabIndex = 0;
			this.tabPageDateToDate.Text = "From date to date";
			this.tabPageDateToDate.UseVisualStyleBackColor = true;
			// 
			// labelDaysCounted
			// 
			this.labelDaysCounted.AutoSize = true;
			this.labelDaysCounted.Location = new System.Drawing.Point(51, 59);
			this.labelDaysCounted.Name = "labelDaysCounted";
			this.labelDaysCounted.Size = new System.Drawing.Size(22, 13);
			this.labelDaysCounted.TabIndex = 7;
			this.labelDaysCounted.Text = "xxx";
			this.labelDaysCounted.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysCounted.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDaysCounted.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDaysCounted.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDays
			// 
			this.labelDays.AutoSize = true;
			this.labelDays.Location = new System.Drawing.Point(8, 59);
			this.labelDays.Name = "labelDays";
			this.labelDays.Size = new System.Drawing.Size(34, 13);
			this.labelDays.TabIndex = 6;
			this.labelDays.Text = "&Days:";
			this.labelDays.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDays.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDays.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDays.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateEnd
			// 
			this.labelDateEnd.AutoSize = true;
			this.labelDateEnd.Location = new System.Drawing.Point(8, 36);
			this.labelDateEnd.Name = "labelDateEnd";
			this.labelDateEnd.Size = new System.Drawing.Size(23, 13);
			this.labelDateEnd.TabIndex = 3;
			this.labelDateEnd.Text = "&To:";
			this.labelDateEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateBegin
			// 
			this.labelDateBegin.AutoSize = true;
			this.labelDateBegin.Location = new System.Drawing.Point(8, 10);
			this.labelDateBegin.Name = "labelDateBegin";
			this.labelDateBegin.Size = new System.Drawing.Size(33, 13);
			this.labelDateBegin.TabIndex = 0;
			this.labelDateBegin.Text = "&From:";
			this.labelDateBegin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateBegin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateBegin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateBegin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tabPageDaySpan
			// 
			this.tabPageDaySpan.Controls.Add(this.labelDateOut);
			this.tabPageDaySpan.Controls.Add(this.labelDateIn);
			this.tabPageDaySpan.Controls.Add(this.dateTimePickerDateOut);
			this.tabPageDaySpan.Controls.Add(this.labelDaysPlusMinus);
			this.tabPageDaySpan.Controls.Add(this.numericUpDownDays);
			this.tabPageDaySpan.Controls.Add(this.dateTimePickerDateIn);
			this.tabPageDaySpan.Controls.Add(this.buttonSwitchDateIn);
			this.tabPageDaySpan.ImageIndex = 1;
			this.tabPageDaySpan.Location = new System.Drawing.Point(4, 23);
			this.tabPageDaySpan.Name = "tabPageDaySpan";
			this.tabPageDaySpan.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDaySpan.Size = new System.Drawing.Size(283, 84);
			this.tabPageDaySpan.TabIndex = 1;
			this.tabPageDaySpan.Text = "Days more/less";
			this.tabPageDaySpan.UseVisualStyleBackColor = true;
			// 
			// labelDateOut
			// 
			this.labelDateOut.AutoSize = true;
			this.labelDateOut.Location = new System.Drawing.Point(8, 62);
			this.labelDateOut.Name = "labelDateOut";
			this.labelDateOut.Size = new System.Drawing.Size(51, 13);
			this.labelDateOut.TabIndex = 5;
			this.labelDateOut.Text = "Date &out:";
			this.labelDateOut.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateOut.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateOut.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateOut.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDateIn
			// 
			this.labelDateIn.AutoSize = true;
			this.labelDateIn.Location = new System.Drawing.Point(8, 10);
			this.labelDateIn.Name = "labelDateIn";
			this.labelDateIn.Size = new System.Drawing.Size(44, 13);
			this.labelDateIn.TabIndex = 0;
			this.labelDateIn.Text = "Date &in:";
			this.labelDateIn.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateIn.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDateIn.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDateIn.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerDateOut
			// 
			this.dateTimePickerDateOut.Enabled = false;
			this.dateTimePickerDateOut.Location = new System.Drawing.Point(66, 58);
			this.dateTimePickerDateOut.Name = "dateTimePickerDateOut";
			this.dateTimePickerDateOut.Size = new System.Drawing.Size(183, 20);
			this.dateTimePickerDateOut.TabIndex = 6;
			this.dateTimePickerDateOut.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerDateOut.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerDateOut.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerDateOut.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDaysPlusMinus
			// 
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
			// numericUpDownDays
			// 
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
			this.numericUpDownDays.ValueChanged += new System.EventHandler(this.NumericUpDownDays_ValueChanged);
			this.numericUpDownDays.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.numericUpDownDays.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// dateTimePickerDateIn
			// 
			this.dateTimePickerDateIn.Location = new System.Drawing.Point(66, 6);
			this.dateTimePickerDateIn.Name = "dateTimePickerDateIn";
			this.dateTimePickerDateIn.Size = new System.Drawing.Size(183, 20);
			this.dateTimePickerDateIn.TabIndex = 1;
			this.dateTimePickerDateIn.ValueChanged += new System.EventHandler(this.DateTimePickerDateIn_ValueChanged);
			this.dateTimePickerDateIn.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerDateIn.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.dateTimePickerDateIn.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.dateTimePickerDateIn.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// tabPageAbout
			// 
			this.tabPageAbout.Controls.Add(this.labelCopyright);
			this.tabPageAbout.Controls.Add(this.labelDescription);
			this.tabPageAbout.Controls.Add(this.labelTitle);
			this.tabPageAbout.Controls.Add(this.pictureBox);
			this.tabPageAbout.ImageIndex = 2;
			this.tabPageAbout.Location = new System.Drawing.Point(4, 23);
			this.tabPageAbout.Name = "tabPageAbout";
			this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAbout.Size = new System.Drawing.Size(283, 84);
			this.tabPageAbout.TabIndex = 2;
			this.tabPageAbout.Text = "About";
			this.tabPageAbout.UseVisualStyleBackColor = true;
			// 
			// labelCopyright
			// 
			this.labelCopyright.AutoSize = true;
			this.labelCopyright.Location = new System.Drawing.Point(9, 63);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(120, 17);
			this.labelCopyright.TabIndex = 2;
			this.labelCopyright.Text = "[Copyright + Company]";
			this.labelCopyright.UseCompatibleTextRendering = true;
			this.labelCopyright.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCopyright.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelCopyright.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelCopyright.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(9, 46);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(67, 17);
			this.labelDescription.TabIndex = 1;
			this.labelDescription.Text = "[Description]";
			this.labelDescription.UseCompatibleTextRendering = true;
			this.labelDescription.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDescription.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelDescription.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelDescription.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(47, 9);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(165, 30);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "[Title + Version]";
			this.labelTitle.UseCompatibleTextRendering = true;
			this.labelTitle.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTitle.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.labelTitle.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.labelTitle.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(291, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip";
			// 
			// labelInformation
			// 
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(70, 17);
			this.labelInformation.Text = "information";
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
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(291, 111);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(291, 133);
			this.toolStripContainer1.TabIndex = 6;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// buttonSwitchDateEnd
			// 
			this.buttonSwitchDateEnd.Image = global::Days_Counter.Properties.Resources.switch_small;
			this.buttonSwitchDateEnd.Location = new System.Drawing.Point(255, 32);
			this.buttonSwitchDateEnd.Name = "buttonSwitchDateEnd";
			this.buttonSwitchDateEnd.Size = new System.Drawing.Size(20, 20);
			this.buttonSwitchDateEnd.TabIndex = 5;
			this.buttonSwitchDateEnd.UseVisualStyleBackColor = true;
			this.buttonSwitchDateEnd.Click += new System.EventHandler(this.ButtonSwitchDateEnd_Click);
			this.buttonSwitchDateEnd.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateEnd.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSwitchDateEnd.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateEnd.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSwitchDateBegin
			// 
			this.buttonSwitchDateBegin.Image = global::Days_Counter.Properties.Resources.switch_small;
			this.buttonSwitchDateBegin.Location = new System.Drawing.Point(255, 6);
			this.buttonSwitchDateBegin.Name = "buttonSwitchDateBegin";
			this.buttonSwitchDateBegin.Size = new System.Drawing.Size(20, 20);
			this.buttonSwitchDateBegin.TabIndex = 2;
			this.buttonSwitchDateBegin.UseVisualStyleBackColor = true;
			this.buttonSwitchDateBegin.Click += new System.EventHandler(this.ButtonSwitchDateBegin_Click);
			this.buttonSwitchDateBegin.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateBegin.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSwitchDateBegin.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateBegin.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// buttonSwitchDateIn
			// 
			this.buttonSwitchDateIn.Image = global::Days_Counter.Properties.Resources.switch_small;
			this.buttonSwitchDateIn.Location = new System.Drawing.Point(255, 6);
			this.buttonSwitchDateIn.Name = "buttonSwitchDateIn";
			this.buttonSwitchDateIn.Size = new System.Drawing.Size(20, 20);
			this.buttonSwitchDateIn.TabIndex = 2;
			this.buttonSwitchDateIn.UseVisualStyleBackColor = true;
			this.buttonSwitchDateIn.Click += new System.EventHandler(this.ButtonSwitchDateDays_Click);
			this.buttonSwitchDateIn.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateIn.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.buttonSwitchDateIn.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.buttonSwitchDateIn.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// pictureBox
			// 
			this.pictureBox.Image = global::Days_Counter.Properties.Resources.calendar_day;
			this.pictureBox.Location = new System.Drawing.Point(9, 7);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(32, 32);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.pictureBox.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "calendar-select-days.png");
			this.imageList.Images.SetKeyName(1, "calendar-select-days-span.png");
			this.imageList.Images.SetKeyName(2, "information-button.png");
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 133);
			this.Controls.Add(this.toolStripContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Days Counter";
			this.tabControl.ResumeLayout(false);
			this.tabPageDateToDate.ResumeLayout(false);
			this.tabPageDateToDate.PerformLayout();
			this.tabPageDaySpan.ResumeLayout(false);
			this.tabPageDaySpan.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
			this.tabPageAbout.ResumeLayout(false);
			this.tabPageAbout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
		private System.Windows.Forms.Button buttonSwitchDateBegin;
		private System.Windows.Forms.Button buttonSwitchDateEnd;
		private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageDateToDate;
		private System.Windows.Forms.TabPage tabPageDaySpan;
		private System.Windows.Forms.NumericUpDown numericUpDownDays;
		private System.Windows.Forms.DateTimePicker dateTimePickerDateIn;
		private System.Windows.Forms.Button buttonSwitchDateIn;
		private System.Windows.Forms.TabPage tabPageAbout;
		private System.Windows.Forms.Label labelDaysPlusMinus;
		private System.Windows.Forms.DateTimePicker dateTimePickerDateOut;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label labelDaysCounted;
		private System.Windows.Forms.Label labelDays;
		private System.Windows.Forms.Label labelDateEnd;
		private System.Windows.Forms.Label labelDateBegin;
		private System.Windows.Forms.Label labelDateIn;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Label labelDateOut;
		private System.Windows.Forms.ImageList imageList;
	}
}

