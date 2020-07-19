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
    public partial class frUser : Form
    {
        List<User> listUser;
        public frUser()
        {
            InitializeComponent();
            listUser = new List<User>();

            this.cUserName.DataPropertyName = nameof(User.userName);
            this.cFullName.DataPropertyName = nameof(User.fullName);
            this.cBirthday.DataPropertyName = nameof(User.dateBirth);
            this.cDepartment.DataPropertyName = nameof(User.department);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //test input data
            if (this.txtUserName.Text == "")
            {
                error.SetError(this.txtUserName, "Please enter User Name");
            }
            if(this.txtFullName.Text == "")
            {
                error.SetError(this.txtFullName, "Please enter Full Name");
            }
            if (this.cbxDepartment.SelectedItem == null) 
            {
                error.SetError(this.cbxDepartment, "Please choose Department");
            }
            else
            {
                User user = new User();
                user.userName = this.txtUserName.Text.Trim();
                user.fullName = this.txtFullName.Text.Trim();
                user.dateBirth = this.dateBirth.Value;
                user.department = this.cbxDepartment.SelectedItem.ToString();

                //test user name
                if (this.listUser.Where(x => x.userName == user.userName).Count() > 0)
                {
                    MessageBox.Show("User name is already existed!");
                    return;
                }
                
                listUser.Add(user);

                BindingSource source = new BindingSource();
                source.DataSource = listUser;
                this.dataUsers.DataSource = source;

                //clear
                this.txtUserName.ResetText();
                this.txtFullName.ResetText();
                this.cbxDepartment.ResetText();
                this.dateBirth.ResetText();
            }
            error.Clear();
        }
    }
}
