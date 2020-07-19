using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18110400_TaskManagement
{
    public partial class frMainGUI : Form
    {
        frTaskManagement formTask;
        frUser formUser;

        List<User> listUsers;
        List<Task> listTasks;
        public frMainGUI()
        {
            InitializeComponent();
            listUsers = new List<User>();
            listTasks = new List<Task>();
        }

        private void frmMainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void menuTask_Click(object sender, EventArgs e)
        {
            if (this.formTask is null || this.formTask.IsDisposed)
            {
                this.formTask = new frTaskManagement(ref listTasks, listUsers);

                this.formTask.MdiParent = this;
                this.formTask.Show();
            }
            else
            {
                this.formTask.Select();
            }
        }

        private void menuUser_Click(object sender, EventArgs e)
        {
            if(this.formUser is null || this.formUser.IsDisposed)
            {
                this.formUser = new frUser(ref listUsers);
                this.formUser.MdiParent = this;
                this.formUser.Show();
            }
            else
            {
                this.formUser.Select();
            }
        }

        private void frMainGUI_MdiChildActivate(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild == null)
            {
                return;
            }

            //display full screen
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;

            //display on tab
            if(this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMain;       //tab to contain name
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabMain.SelectedTab != null && this.tabMain.SelectedTab.Tag != null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }
    }
}
