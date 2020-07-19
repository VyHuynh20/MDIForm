namespace _18110400_TaskManagement
{
    partial class frTaskManagement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTaskManagement));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newListEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tlstrNext = new System.Windows.Forms.ToolStripLabel();
            this.lbEventName = new System.Windows.Forms.ToolStripLabel();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.tlstrcbShow = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.datetimeEnd = new System.Windows.Forms.DateTimePicker();
            this.datetimeStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listEvent = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTimeFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTimeTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.picNote = new System.Windows.Forms.PictureBox();
            this.btnNewNote = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCreateEvent = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorAdd = new System.Windows.Forms.ErrorProvider(this.components);
            this.help = new System.Windows.Forms.HelpProvider();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNote)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewEventToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewEventToolStripMenuItem
            // 
            this.createNewEventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEventToolStripMenuItem,
            this.newListEventToolStripMenuItem});
            this.createNewEventToolStripMenuItem.Name = "createNewEventToolStripMenuItem";
            this.createNewEventToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createNewEventToolStripMenuItem.Text = "Create";
            this.createNewEventToolStripMenuItem.Click += new System.EventHandler(this.createNewEventToolStripMenuItem_Click);
            // 
            // newEventToolStripMenuItem
            // 
            this.newEventToolStripMenuItem.Name = "newEventToolStripMenuItem";
            this.newEventToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newEventToolStripMenuItem.Text = "New Event";
            this.newEventToolStripMenuItem.Click += new System.EventHandler(this.newEventToolStripMenuItem_Click);
            // 
            // newListEventToolStripMenuItem
            // 
            this.newListEventToolStripMenuItem.Name = "newListEventToolStripMenuItem";
            this.newListEventToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newListEventToolStripMenuItem.Text = "New List Event";
            this.newListEventToolStripMenuItem.Click += new System.EventHandler(this.newListEventToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 376);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 426);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrNext,
            this.lbEventName,
            this.progressbar,
            this.tlstrcbShow});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(414, 25);
            this.toolStrip2.TabIndex = 0;
            // 
            // tlstrNext
            // 
            this.tlstrNext.Name = "tlstrNext";
            this.tlstrNext.Size = new System.Drawing.Size(64, 22);
            this.tlstrNext.Text = "Next Event";
            // 
            // lbEventName
            // 
            this.lbEventName.Name = "lbEventName";
            this.lbEventName.Size = new System.Drawing.Size(113, 22);
            this.lbEventName.Text = "[Name of the event]";
            // 
            // progressbar
            // 
            this.progressbar.MarqueeAnimationSpeed = 50;
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(100, 22);
            // 
            // tlstrcbShow
            // 
            this.tlstrcbShow.AutoCompleteCustomSource.AddRange(new string[] {
            "Day",
            "Hour",
            "Minute"});
            this.tlstrcbShow.AutoToolTip = true;
            this.tlstrcbShow.Items.AddRange(new object[] {
            "Day",
            "Hour",
            "Minute"});
            this.tlstrcbShow.Name = "tlstrcbShow";
            this.tlstrcbShow.Size = new System.Drawing.Size(121, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.datetimeEnd);
            this.splitContainer1.Panel1.Controls.Add(this.datetimeStart);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.rtxtDescription);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtTitle);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 376);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(689, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 26);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(581, 96);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 26);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(469, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Event";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // datetimeEnd
            // 
            this.datetimeEnd.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeEnd.CustomFormat = "dd/MM/yyyy  hh:mm:ss tt";
            this.datetimeEnd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeEnd.Location = new System.Drawing.Point(515, 58);
            this.datetimeEnd.Name = "datetimeEnd";
            this.datetimeEnd.Size = new System.Drawing.Size(249, 22);
            this.datetimeEnd.TabIndex = 15;
            // 
            // datetimeStart
            // 
            this.datetimeStart.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeStart.CustomFormat = "dd/MM/yyyy  hh:mm:ss tt";
            this.datetimeStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeStart.Location = new System.Drawing.Point(515, 26);
            this.datetimeStart.Name = "datetimeStart";
            this.datetimeStart.Size = new System.Drawing.Size(249, 22);
            this.datetimeStart.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Start ";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(119, 59);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(282, 63);
            this.rtxtDescription.TabIndex = 11;
            this.rtxtDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description*";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(119, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(282, 25);
            this.txtTitle.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Title*";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listEvent);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(800, 244);
            this.splitContainer2.SplitterDistance = 543;
            this.splitContainer2.TabIndex = 0;
            // 
            // listEvent
            // 
            this.listEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cTitle,
            this.cTimeFrom,
            this.cTimeTo,
            this.cDescription});
            this.listEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEvent.GridLines = true;
            this.listEvent.HideSelection = false;
            this.listEvent.Location = new System.Drawing.Point(0, 0);
            this.listEvent.Name = "listEvent";
            this.listEvent.Size = new System.Drawing.Size(543, 244);
            this.listEvent.TabIndex = 0;
            this.listEvent.UseCompatibleStateImageBehavior = false;
            this.listEvent.View = System.Windows.Forms.View.Details;
            this.listEvent.Click += new System.EventHandler(this.listEvent_Click);
            // 
            // cID
            // 
            this.cID.Text = "ID";
            this.cID.Width = 40;
            // 
            // cTitle
            // 
            this.cTitle.Text = "Title";
            this.cTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cTitle.Width = 102;
            // 
            // cTimeFrom
            // 
            this.cTimeFrom.Text = "Time Start";
            this.cTimeFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cTimeFrom.Width = 125;
            // 
            // cTimeTo
            // 
            this.cTimeTo.Text = "Time End";
            this.cTimeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cTimeTo.Width = 132;
            // 
            // cDescription
            // 
            this.cDescription.Text = "Description";
            this.cDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cDescription.Width = 137;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.picNote);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnNewNote);
            this.splitContainer3.Size = new System.Drawing.Size(253, 244);
            this.splitContainer3.SplitterDistance = 201;
            this.splitContainer3.TabIndex = 0;
            // 
            // picNote
            // 
            this.picNote.BackColor = System.Drawing.Color.White;
            this.picNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNote.Location = new System.Drawing.Point(0, 0);
            this.picNote.Name = "picNote";
            this.picNote.Size = new System.Drawing.Size(253, 201);
            this.picNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picNote.TabIndex = 0;
            this.picNote.TabStop = false;
            this.picNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNote_MouseDown);
            this.picNote.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picNote_MouseMove);
            this.picNote.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNote_MouseUp);
            this.picNote.Resize += new System.EventHandler(this.picNote_Resize);
            // 
            // btnNewNote
            // 
            this.btnNewNote.BackColor = System.Drawing.SystemColors.Info;
            this.btnNewNote.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNote.Location = new System.Drawing.Point(99, 6);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(105, 32);
            this.btnNewNote.TabIndex = 0;
            this.btnNewNote.Text = "New Note";
            this.btnNewNote.UseVisualStyleBackColor = false;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCreateEvent});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButtonCreateEvent
            // 
            this.toolStripButtonCreateEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCreateEvent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreateEvent.Image")));
            this.toolStripButtonCreateEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreateEvent.Name = "toolStripButtonCreateEvent";
            this.toolStripButtonCreateEvent.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCreateEvent.Text = "Create Event";
            this.toolStripButtonCreateEvent.Click += new System.EventHandler(this.toolStripButtonCreateEvent_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorAdd
            // 
            this.errorAdd.BlinkRate = 200;
            this.errorAdd.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorAdd.ContainerControl = this;
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // frTaskManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frTaskManagement";
            this.Text = "Event Management";
            this.Load += new System.EventHandler(this.frTaskManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNote)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreateEvent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker datetimeEnd;
        private System.Windows.Forms.DateTimePicker datetimeStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView listEvent;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.ColumnHeader cTitle;
        private System.Windows.Forms.ColumnHeader cTimeFrom;
        private System.Windows.Forms.ColumnHeader cTimeTo;
        private System.Windows.Forms.ColumnHeader cDescription;
        private System.Windows.Forms.PictureBox picNote;
        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tlstrNext;
        private System.Windows.Forms.ToolStripLabel lbEventName;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.ToolStripComboBox tlstrcbShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorAdd;
        private System.Windows.Forms.HelpProvider help;
        private System.Windows.Forms.ToolStripMenuItem newEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newListEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
    }
}

