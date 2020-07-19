using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18110400_TaskManagement
{
    public partial class frUser : Form
    {
        List<User> _listUser;
        DateTimePicker dtp;
        BindingSource source;
        string temp;
        int choose;
        public frUser(ref List<User> listUsers)
        {
            InitializeComponent();
            _listUser = new List<User>();
            this._listUser = listUsers;

            this.cUserName.DataPropertyName = nameof(User.userName);
            this.cFullName.DataPropertyName = nameof(User.fullName);
            this.cBirthday.DataPropertyName = nameof(User.dateBirth);
            this.cDepartment.DataPropertyName = nameof(User.department);
            this.cPhone.DataPropertyName = nameof(User.phone);
            this.cEmail.DataPropertyName = nameof(User.email);

            //show on datagridview
            source = new BindingSource();
            source.DataSource = _listUser;
            this.dataUsers.DataSource = source;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            error.Clear();

            //test input data
            if (this.txtUserName.Text == "")
            {
                error.SetError(this.txtUserName, "Please enter User Name");
                if (this.txtFullName.Text == "")
                {
                    error.SetError(this.txtFullName, "Please enter Full Name");
                    if (this.cbxDepartment.Text == "")
                    {
                        error.SetError(this.cbxDepartment, "Please choose Department");
                    }
                }
                if (this.cbxDepartment.Text == "")
                {
                    error.SetError(this.cbxDepartment, "Please choose Department");
                }
                return;
            }
            if (this.txtFullName.Text == "")
            {
                error.SetError(this.txtFullName, "Please enter Full Name");
                if (this.cbxDepartment.Text == "")
                {
                    error.SetError(this.cbxDepartment, "Please choose Department");
                }
                return;
            }
            if (this.cbxDepartment.Text == "")
            {
                error.SetError(this.cbxDepartment, "Please choose Department");
                return;
            }

            else
            {
                User user = new User();
                user.userName = this.txtUserName.Text.Trim();
                user.fullName = this.txtFullName.Text.Trim();
                user.dateBirth = this.dateBirth.Value;
                user.department = this.cbxDepartment.SelectedItem.ToString();
                user.phone = this.txtPhone.Text.Trim();
                user.email = this.txtEmail.Text.Trim();

                //test user name
                if (this._listUser.Where(x => x.userName == user.userName).Count() > 0)
                {
                    MessageBox.Show("User name is already existed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtUserName.ResetText();
                    this.txtUserName.Focus();
                    return;
                }

                _listUser.Add(user);

                source = new BindingSource();
                source.DataSource = _listUser;
                this.dataUsers.DataSource = source;

                //clear
                this.txtUserName.ResetText();
                this.txtFullName.ResetText();
                this.cbxDepartment.ResetText();
                this.dateBirth.ResetText();
                this.txtPhone.ResetText();
                this.txtEmail.ResetText();
            }
        }
        private void dataUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                return;
            }

            if (this.dataUsers.Columns[e.ColumnIndex].DataPropertyName == nameof(User.dateBirth))
            {
                dtp = new DateTimePicker();
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Visible = true;
                Rectangle rec = this.dataUsers.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Location = new Point(rec.X, rec.Y);
                dtp.Size = new Size(rec.Width, rec.Height);

                //test empty cell
                try
                {
                    dtp.Value = DateTime.Parse(this.dataUsers.CurrentCell.Value.ToString());
                }
                catch
                {
                    dtp.Value = DateTime.Now;
                }
                //dispose control
                dtp.CloseUp += Dtp_CloseUp;
                dtp.TextChanged += Dtp_TextChanged;

                this.dataUsers.Controls.Add(dtp);
            }

            if (e.ColumnIndex == 0)
            {
                if (temp != null)
                {
                    temp = this.dataUsers.CurrentRow.Cells[0].Value.ToString();
                }
                else temp = null;
                /*
                try
                {
                    temp = this.dataUsers.CurrentRow.Cells[0].Value.ToString();
                }
                catch
                {
                    temp = null;
                }
                */
            }
            //else
            //{
            //    try
            //    {
            //        temp = this.dataUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //    }
            //    catch
            //    {
            //        temp = null;
            //    }
            //}
            choose = e.RowIndex;
            
        }

        private void Dtp_TextChanged(object sender, EventArgs e)
        {
            this.dataUsers.CurrentCell.Value = this.dtp.Value.ToString();
        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
            dtp.Dispose();
        }

        private void dataUsers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            User user = new User();
                user.userName = this.dataUsers.CurrentRow.Cells[0].Value.ToString();

            if (user.userName.Length == 0)
            {
                return;
            }

            //if else instead of try catch
            if (this.dataUsers.CurrentRow.Cells[1].Value is null)
            {
                user.fullName = "-Full Name-";
            }
            else user.fullName = this.dataUsers.CurrentRow.Cells[1].Value.ToString();
            if (this.dataUsers.CurrentRow.Cells[3].Value is null)
            {
                user.department = "-Choose Department";
            }
            else user.department = this.dataUsers.CurrentRow.Cells[3].Value.ToString();
            if (this.dataUsers.CurrentRow.Cells[2].Value is null)
            {
                user.dateBirth = new DateTime(01 / 01 / 2000);
            }
            else user.dateBirth = DateTime.Parse(this.dataUsers.CurrentRow.Cells[2].Value.ToString());
            if (this.dataUsers.CurrentRow.Cells[4].Value is null)
            {
                user.phone = "-Phone-";
            }
            else user.phone = this.dataUsers.CurrentRow.Cells[4].Value.ToString();
            if (this.dataUsers.CurrentRow.Cells[5].Value is null)
            {
                user.email = "-Email-";
            }
            else user.email = this.dataUsers.CurrentRow.Cells[5].Value.ToString();

                /*
                try
                {
                    user.fullName = this.dataUsers.CurrentRow.Cells[1].Value.ToString();
                    user.department = this.dataUsers.CurrentRow.Cells[3].Value.ToString();
                    user.dateBirth = DateTime.Parse(this.dataUsers.CurrentRow.Cells[2].Value.ToString());
                    user.phone = this.dataUsers.CurrentRow.Cells[4].Value.ToString();
                    user.email = this.dataUsers.CurrentRow.Cells[5].Value.ToString();

                }
                catch
                {
                    user.fullName = "-Full Name-";
                    user.department = "";
                    user.dateBirth = new DateTime(01/01/2000);
                    user.phone = "-Phone-";
                    user.email = "-Email-";
                }
                */
                int count = _listUser.Where(x => x.userName == user.userName).Count();

            if (count == 0)
            {
                _listUser.Add(user);
            }

            if (count == 2)
            {
                if (temp != null)
                {
                    if (this.dataUsers.CurrentRow.Cells[0].Value.ToString() == temp)
                    {
                        this._listUser[e.RowIndex] = user;
                        this.dataUsers.Update();
                        return;
                    }

                    else
                    {
                        MessageBox.Show("User name is already existed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.dataUsers.CurrentRow.Cells[0].Value = temp;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("User name is already existed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.dataUsers.Rows.RemoveAt(e.RowIndex);
                    this.dataUsers.CurrentCell = this.dataUsers.Rows[choose].Cells[0];
                }
            }
            else if (count > 2)
            {
                //MessageBox.Show("User name is already existed!!\nPlease choose another different name","",
                //MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //this.dataUsers.CurrentRow.Cells[0].Value = "";
                ////this.dataUsers.Rows.RemoveAt(e.RowIndex);
                //this.dataUsers.Update();
                //return;

                if (temp != null)
                {
                    if (this.dataUsers.CurrentRow.Cells[0].Value.ToString() == temp)
                    {
                        return;
                    }

                    else
                    {
                        MessageBox.Show("User name is already existed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.dataUsers.CurrentRow.Cells[0].Value = temp;
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("User name is already existed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.dataUsers.Rows.RemoveAt(e.RowIndex);
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dataUsers.Rows.RemoveAt(dataUsers.CurrentRow.Index);
                dataUsers.Update();
                MessageBox.Show("Delete user successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnAdd.Focus();
            }
            catch
            {
                MessageBox.Show("You have not choose the item yet");
            }
        }

        private void frUser_Load(object sender, EventArgs e)
        {
            this.help.SetShowHelp(this.txtUserName, true);
            this.help.SetHelpString(this.txtUserName, "Enter your User Name to use");

            this.help.SetShowHelp(this.txtFullName,true);
            this.help.SetHelpString(this.txtFullName, "Enter your Full Name to use");

            this.help.SetShowHelp(this.dateBirth, true);
            this.help.SetHelpString(this.dateBirth, "Choose your Date of Birth");

            this.help.SetShowHelp(this.cbxDepartment, true);
            this.help.SetHelpString(this.cbxDepartment, "Choose your suitable Department");

            this.help.SetShowHelp(this.dataUsers, true);
            this.help.SetHelpString(this.dataUsers, "This is list of Users\nYou can directly apply this list");
        }

        private void dataUsers_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void dataUsers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
