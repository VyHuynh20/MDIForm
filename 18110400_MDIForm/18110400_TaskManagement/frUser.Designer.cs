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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.cDepartment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.help = new System.Windows.Forms.HelpProvider();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Khaki;
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtPhone);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
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
            this.splitContainer1.Size = new System.Drawing.Size(1011, 483);
            this.splitContainer1.SplitterDistance = 174;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(650, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 25);
            this.txtEmail.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(650, 53);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(187, 25);
            this.txtPhone.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(537, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Ivory;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(540, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 33);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Ivory;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(220, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add New User";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateBirth
            // 
            this.dateBirth.CustomFormat = "dd/MM/yyyy";
            this.dateBirth.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirth.Location = new System.Drawing.Point(650, 22);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(127, 25);
            this.dateBirth.TabIndex = 7;
            this.dateBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Day of Birth";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Items.AddRange(new object[] {
            "Software Engineering",
            "Information System",
            "Networking",
            "Informatics Fundamentals"});
            this.cbxDepartment.Location = new System.Drawing.Point(172, 85);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(187, 24);
            this.cbxDepartment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(172, 54);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(187, 25);
            this.txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(172, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(187, 25);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // dataUsers
            // 
            this.dataUsers.BackgroundColor = System.Drawing.Color.Beige;
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUserName,
            this.cFullName,
            this.cBirthday,
            this.cDepartment,
            this.cPhone,
            this.cEmail});
            this.dataUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataUsers.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataUsers.Location = new System.Drawing.Point(0, 0);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.Size = new System.Drawing.Size(1011, 305);
            this.dataUsers.TabIndex = 0;
            this.dataUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUsers_CellClick);
            this.dataUsers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUsers_CellEndEdit);
            this.dataUsers.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataUsers_DataError);
            this.dataUsers.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataUsers_RowsRemoved);
            // 
            // cUserName
            // 
            this.cUserName.HeaderText = "User Name";
            this.cUserName.MinimumWidth = 10;
            this.cUserName.Name = "cUserName";
            this.cUserName.Width = 150;
            // 
            // cFullName
            // 
            this.cFullName.HeaderText = "Full Name";
            this.cFullName.MinimumWidth = 10;
            this.cFullName.Name = "cFullName";
            this.cFullName.Width = 200;
            // 
            // cBirthday
            // 
            this.cBirthday.HeaderText = "Day of Birth";
            this.cBirthday.MinimumWidth = 10;
            this.cBirthday.Name = "cBirthday";
            this.cBirthday.Width = 150;
            // 
            // cDepartment
            // 
            this.cDepartment.HeaderText = "Department";
            this.cDepartment.Items.AddRange(new object[] {
            "Software Engineering",
            "Information System",
            "Networking",
            "Informatics Fundamentals"});
            this.cDepartment.MinimumWidth = 10;
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cDepartment.Width = 150;
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "Phone";
            this.cPhone.MinimumWidth = 10;
            this.cPhone.Name = "cPhone";
            this.cPhone.Width = 150;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.MinimumWidth = 10;
            this.cEmail.Name = "cEmail";
            this.cEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cEmail.Width = 150;
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
            this.ClientSize = new System.Drawing.Size(1011, 483);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frUser";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.frUser_Load);
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
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.HelpProvider help;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBirthday;
        private System.Windows.Forms.DataGridViewComboBoxColumn cDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
    }
}