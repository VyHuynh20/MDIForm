namespace _18110400_TaskManagement
{
    partial class frUser
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataUsers = new System.Windows.Forms.DataGridView();
            this.cUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.dateBirth);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.cbxDepartment);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtFullName);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtUserName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataUsers);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add New User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateBirth
            // 
            this.dateBirth.CustomFormat = "dd/MM/yyyy";
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirth.Location = new System.Drawing.Point(463, 34);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(127, 20);
            this.dateBirth.TabIndex = 7;
            this.dateBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Day of Birth";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Items.AddRange(new object[] {
            "Software Engineering",
            "Information System",
            "Networking",
            "Informatics Fundamentals"});
            this.cbxDepartment.Location = new System.Drawing.Point(463, 63);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(161, 22);
            this.cbxDepartment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(112, 62);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(161, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(112, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(161, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // dataUsers
            // 
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUserName,
            this.cFullName,
            this.cBirthday,
            this.cDepartment});
            this.dataUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataUsers.Location = new System.Drawing.Point(0, 0);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.Size = new System.Drawing.Size(800, 283);
            this.dataUsers.TabIndex = 0;
            // 
            // cUserName
            // 
            this.cUserName.HeaderText = "User Name";
            this.cUserName.Name = "cUserName";
            this.cUserName.Width = 150;
            // 
            // cFullName
            // 
            this.cFullName.HeaderText = "Full Name";
            this.cFullName.Name = "cFullName";
            this.cFullName.Width = 200;
            // 
            // cBirthday
            // 
            this.cBirthday.HeaderText = "Day of Birth";
            this.cBirthday.Name = "cBirthday";
            this.cBirthday.Width = 150;
            // 
            // cDepartment
            // 
            this.cDepartment.HeaderText = "Department";
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cDepartment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cDepartment.Width = 150;
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // frUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frUser";
            this.Text = "User Management";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDepartment;
        private System.Windows.Forms.ErrorProvider error;
    }
}