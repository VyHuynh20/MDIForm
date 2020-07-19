namespace _18110400_TaskManagement
{
    partial class frMainGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTask = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFunction});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFunction
            // 
            this.menuFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTask,
            this.menuUser});
            this.menuFunction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFunction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuFunction.Name = "menuFunction";
            this.menuFunction.Size = new System.Drawing.Size(66, 20);
            this.menuFunction.Text = "&Function";
            // 
            // menuTask
            // 
            this.menuTask.Name = "menuTask";
            this.menuTask.Size = new System.Drawing.Size(180, 22);
            this.menuTask.Text = "&Task Management";
            this.menuTask.Click += new System.EventHandler(this.menuTask_Click);
            // 
            // menuUser
            // 
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(180, 22);
            this.menuUser.Text = "&User Management";
            this.menuUser.Click += new System.EventHandler(this.menuUser_Click);
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(889, 38);
            this.tabMain.TabIndex = 5;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // frMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(889, 558);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frMainGUI";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainGUI_FormClosing);
            this.MdiChildActivate += new System.EventHandler(this.frMainGUI_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFunction;
        private System.Windows.Forms.ToolStripMenuItem menuTask;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.TabControl tabMain;
    }
}



