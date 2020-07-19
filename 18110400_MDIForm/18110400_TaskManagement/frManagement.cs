using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _18110400_TaskManagement
{
    public partial class frTaskManagement : Form
    {
        private int ID;
        private int i;
        private DrawNote drawNote;
        private Bitmap bitmapNote;

        private List<Task> _listTasks;
        private List<User> _listUsers;
        public frTaskManagement(ref List<Task> listTasks, List<User> listUsers)
        {
            this._listTasks = listTasks;
            this._listUsers = listUsers;

            InitializeComponent();
            
            bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height, this.picNote.CreateGraphics());
        }

        #region button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.errorAdd.Clear();

            DateTime now = DateTime.Now;

            //Kiem tra du lieu nhap vao
            if (this.txtTitle.Text == "")
            {
                errorAdd.SetError(this.txtTitle, "Please enter the title");
                this.txtTitle.Focus();
            }
            if (this.rtxtDescription.Text == "")
            {
                errorAdd.SetError(this.rtxtDescription, "Please enter the description");
            }
            if (this.datetimeStart.Value <= now)
            {
                this.errorAdd.SetError(this.datetimeStart, "Date Time unavailable"); 

                if (this.datetimeEnd.Value <= datetimeStart.Value || this.datetimeEnd.Value <= now)
                {
                    this.errorAdd.SetError(this.datetimeEnd, "Date Time unavailable");
                    return;
                }
                return;
            }
            if (this.datetimeEnd.Value <= datetimeStart.Value || this.datetimeEnd.Value <= now)
            {
                this.errorAdd.SetError(this.datetimeEnd, "Date Time unavailable");
                return;
            }

            else
            {
                //Add item vao listTasks
                Task task = new Task();
                task.ID = this.ID;
                task.title = this.txtTitle.Text;
                task.timeStart = this.datetimeStart.Value;
                task.timeEnd = this.datetimeEnd.Value;
                task.description = this.rtxtDescription.Text;

                this._listTasks.Add(task);

                //users
                task.listUsers = new List<User>();
                string displayUser = "";
                for (int i = 0; i < this.listName.Items.Count; i++)
                {
                    displayUser = displayUser + this.listName.Items[i] + " ";
                    task.listUsers.Add(this.listName.Items[i] as User);
                }

                //tao container add vao listview
                ListViewItem ev = new ListViewItem(task.ID.ToString());
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, task.title));
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, task.timeStart.ToString()));
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, task.timeEnd.ToString()));
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, task.description));
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, displayUser));

                bitmapNote.Save(String.Format("{0}.jpg", this.ID));
                bitmapNote.Dispose();

                this.listEvent.Items.Add(ev);

                bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height, this.picNote.CreateGraphics());
                this.picNote.CreateGraphics().Clear(Color.White);

                //reset
                this.errorAdd.Clear();
                this.txtTitle.ResetText();
                this.datetimeStart.ResetText();
                this.datetimeEnd.ResetText();
                this.rtxtDescription.ResetText();
                this.listName.Items.Clear();
                this.txtSearchUser.ResetText();

                this.ID++;
            }
        }


        private void toolStripButtonCreateEvent_Click(object sender, EventArgs e)
        {
            this.txtTitle.Clear();
            this.datetimeStart.ResetText();
            this.datetimeEnd.ResetText();
            this.rtxtDescription.Clear();
            this.picNote.CreateGraphics().Clear(Color.White);
            bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height, this.picNote.CreateGraphics());

            this.txtTitle.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.errorAdd.Clear();
            if (this.txtTitle.Text == "")
            {
                this.errorAdd.SetError(this.txtTitle, "Please enter the title");
                return;
            }
            if (this.rtxtDescription.Text == "")
            {
                errorAdd.SetError(this.rtxtDescription, "Please enter the description");
                return;
            }
            if (this.datetimeStart.Value <= DateTime.Now)
            {
                this.errorAdd.SetError(this.datetimeStart, "Date Time unavailable");
                return;
            }
            if (this.datetimeEnd.Value <= datetimeStart.Value)
            {
                this.errorAdd.SetError(this.datetimeEnd, "Date Time unavailable");
                return;
            }

            else
            {
                //update edit in listview and listtask
                this.listEvent.SelectedItems[0].SubItems[1].Text = this.txtTitle.Text;
                this.listEvent.SelectedItems[0].SubItems[2].Text = this.datetimeStart.Value.ToString();
                this.listEvent.SelectedItems[0].SubItems[3].Text = this.datetimeEnd.Value.ToString();
                this.listEvent.SelectedItems[0].SubItems[4].Text = this.rtxtDescription.Text;

                int index = this.listEvent.SelectedItems[0].Index;
                this._listTasks[index].title = this.txtTitle.Text;
                this._listTasks[index].timeStart = this.datetimeStart.Value;
                this._listTasks[index].timeEnd = this.datetimeEnd.Value;
                this._listTasks[index].description = this.rtxtDescription.Text;

                this._listTasks[index].listUsers = new List<User>();
                string username = "";
                for (int i = 0; i < this.listName.Items.Count; i++)
                {
                    username = username + this.listName.Items[i] + " ";
                    this._listTasks[index].listUsers.Add(this.listName.Items[i] as User);
                }
                this.listEvent.SelectedItems[0].SubItems[5].Text = username;

                File.Delete(String.Format("{0}.jpg", this.listEvent.SelectedItems[0].SubItems[0].Text));
                bitmapNote.Save(String.Format("{0}.jpg", this.listEvent.SelectedItems[0].SubItems[0].Text.Trim()));

                this.picNote.CreateGraphics().Clear(Color.White);

                bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height);

                this.picNote.DrawToBitmap(bitmapNote, this.picNote.ClientRectangle);

                //reset
                this.txtTitle.ResetText();
                this.datetimeStart.ResetText();
                this.datetimeEnd.ResetText();
                this.rtxtDescription.ResetText();
                this.errorAdd.Clear(); 
                this.txtSearchUser.ResetText();
                this.listName.Items.Clear();
            }
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            this.picNote.CreateGraphics().Clear(Color.White);

            bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height, this.picNote.CreateGraphics());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                for (i = 0; i < this.listEvent.Items.Count; i++)
                {
                    if (this.listEvent.Items[i].Selected == true)
                    {
                        File.Move(String.Format("{0}.jpg", this.listEvent.SelectedItems[0].SubItems[0].Text),
                                String.Format("delete.jpg"));
                        int select = i;
                        for (int j = select + 1; j < this.listEvent.Items.Count; j++)
                        {
                            File.Move(String.Format("{0}.jpg", this.listEvent.Items[j].SubItems[0].Text),
                                String.Format("{0}.jpg", (select + 1)));

                            this.listEvent.Items[j].SubItems[0].Text = (select + 1).ToString();

                            select++;
                        }

                        this.listEvent.Items[i].Remove();
                        this._listTasks.RemoveAt(i);

                        File.Delete(String.Format("delete.jpg"));
                        this.ID--;
                        this._listTasks[i].ID--;
                    }
                }
                this.bitmapNote.Dispose();
                bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height, this.picNote.CreateGraphics());
                this.picNote.CreateGraphics().Clear(Color.White);

                //reset
                this.txtTitle.Clear();
                this.datetimeStart.ResetText();
                this.datetimeEnd.ResetText();
                this.rtxtDescription.Clear();
            }
            catch
            {
                return;
            }
        }

        private void newListEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listEvent.Items.Clear();
            this.picNote.CreateGraphics().Clear(Color.White);
            bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height, this.picNote.CreateGraphics());
        }

        private void newEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtTitle.Clear();
            this.datetimeStart.ResetText();
            this.datetimeEnd.ResetText();
            this.rtxtDescription.Clear();
            this.picNote.CreateGraphics().Clear(Color.White);
            bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height, this.picNote.CreateGraphics());

            this.txtTitle.Focus();
        }

        //private void userToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frUser formUser = new frUser();
        //    this.Visible = false;
        //    formUser.Show();
        //}
        #endregion

        private void picNote_Resize(object sender, EventArgs e)
        {
            if (bitmapNote is null) return;
            bitmapNote.Dispose();
            this.picNote.CreateGraphics().Clear(Color.White);
            bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height, this.picNote.CreateGraphics());
        }

        private void listEvent_Click(object sender, EventArgs e)
        {
            this.errorAdd.Clear();
            this.listName.Items.Clear();

            this.txtTitle.Text = this.listEvent.SelectedItems[0].SubItems[1].Text.Trim();       //trim de bo phan tu du thua
            this.datetimeStart.Value = DateTime.Parse(this.listEvent.SelectedItems[0].SubItems[2].Text.Trim());
            this.datetimeEnd.Value = DateTime.Parse(this.listEvent.SelectedItems[0].SubItems[3].Text.Trim());
            this.rtxtDescription.Text = this.listEvent.SelectedItems[0].SubItems[4].Text.Trim();

            ////sub string to load name user
            //string temp = "";
            //for(int i = 0; i < this.listEvent.SelectedItems[0].SubItems[5].Text.Length; i++)
            //{
            //    if(this.listEvent.SelectedItems[0].SubItems[5].Text[i] != ' ')
            //    {
            //        temp = temp + this.listEvent.SelectedItems[0].SubItems[5].Text[i];
            //    }
            //    else
            //    {
            //        try
            //        {
            //            this.listName.Items.Add(_listUsers.Where(x => x.userName == temp).ToList()[0]);
            //            temp = "";
            //        }
            //        catch
            //        {
            //            MessageBox.Show("User "+ temp +" is already deleted\nPlease edit again!");
            //            temp = "";
            //        }
            //    }
            //}
            
            for(int i = 0; i < _listTasks[this.listEvent.SelectedItems[0].Index].listUsers.Count; i++)
            {
                List<User> search = this._listUsers.Where(x => x.userName.Contains(_listTasks[this.listEvent.SelectedItems[0].Index].listUsers[i].userName)).ToList();
                if (search.Count == 0)
                {
                    MessageBox.Show("User -"+ _listTasks[this.listEvent.SelectedItems[0].Index].listUsers[i].userName + "- is already deleted\nPlease Edit again",
                        "",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _listTasks[this.listEvent.SelectedItems[0].Index].listUsers.RemoveAt(i);
                }

                else
                {
                    this.listName.Items.Add(_listTasks[this.listEvent.SelectedItems[0].Index].listUsers[i]);
                }
            }

            using (FileStream stream = new FileStream(String.Format("{0}.jpg",
               this.listEvent.SelectedItems[0].SubItems[0].Text.Trim()), FileMode.Open, FileAccess.ReadWrite))
            {
                picNote.Image = Image.FromStream(stream);
                bitmapNote = new Bitmap(Image.FromStream(stream));
            }
        }

        private void frTaskManagement_Load(object sender, EventArgs e)
        {
            //load ListTask
            for (int i = 0; i < _listTasks.Count; i++)
            {
                string username = "";
                for (int j = 0; j < _listTasks[i].listUsers.Count; j++)
                {
                    username = username + _listTasks[i].listUsers[j].ToString() + " ";
                }

                ListViewItem ev = new ListViewItem(_listTasks[i].ID.ToString());
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, _listTasks[i].title));
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, _listTasks[i].timeStart.ToString()));
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, _listTasks[i].timeEnd.ToString()));
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, _listTasks[i].description));
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, username));

                this.listEvent.Items.Add(ev);
            }
            this.ID = this._listTasks.Count + 1;

            drawNote = new DrawNote();
            timer1.Start();

            this.help.SetShowHelp(this.txtTitle, true);
            this.help.SetHelpString(this.txtTitle, "Enter the name of the incoming event");

            this.help.SetShowHelp(this.rtxtDescription, true);
            this.help.SetHelpString(this.rtxtDescription, "Enter all necessary informations of the incoming event");

            this.help.SetShowHelp(this.datetimeStart, true);
            this.help.SetHelpString(this.datetimeStart, "Enter Date and Time that the incoming event will begin");

            this.help.SetShowHelp(this.datetimeEnd, true);
            this.help.SetHelpString(this.datetimeEnd, "Enter Date and Time that the incoming event will end");

            this.help.SetShowHelp(this.btnNewNote, true);
            this.help.SetHelpString(this.btnNewNote, "Draw necessary Note");

            this.help.SetShowHelp(this.splitContainer2, true);
            this.help.SetHelpString(this.splitContainer2, "Draw necessary Note");
        }

        private void picNote_MouseUp(object sender, MouseEventArgs e)
        {
            drawNote.isDraw = false;
        }

        private void picNote_MouseDown(object sender, MouseEventArgs e)
        {
            drawNote.isDraw = true;
            drawNote.X = e.X;
            drawNote.Y = e.Y;
        }

        private void picNote_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawNote.isDraw)
            {
                Graphics G = this.picNote.CreateGraphics();
                G.DrawLine(drawNote.pen, drawNote.X, drawNote.Y, e.X, e.Y);
                using(Graphics g = Graphics.FromImage(bitmapNote))
                {
                    g.DrawLine(drawNote.pen, drawNote.X, drawNote.Y, e.X, e.Y);
                }

                drawNote.X = e.X;
                drawNote.Y = e.Y;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool flat = true;
            int min = 0;
            DateTime now = DateTime.Now;

            for(int i = 0; i < this.listEvent.Items.Count; i++)
            {
                while(DateTime.Parse(this.listEvent.Items[min].SubItems[2].Text.Trim())<now&& min+1 < listEvent.Items.Count)
                {
                    min++;
                }

                if (min >= listEvent.Items.Count)
                {
                    flat = true;
                    break;
                }

                int j = min; 
                for (i = j; i < this.listEvent.Items.Count; i++)
                {
                    DateTime time = DateTime.Parse(this.listEvent.Items[i].SubItems[2].Text.Trim());
                    if (time >= now && DateTime.Parse(this.listEvent.Items[min].SubItems[2].Text.Trim()) >= time)
                    {
                        min = i;
                        flat = false;
                    }
                }
            }
            if (this.listEvent.Items.Count == 0)
            {
                this.lbEventName.Text = "No coming event";
                this.progressbar.Value = 0;
                return;
            }
            if (flat)
            {
                this.lbEventName.Text = "No coming event";
                this.progressbar.Value = 0;
                return;
            }

            this.lbEventName.Text = this.listEvent.Items[min].SubItems[1].Text.Trim();

            int x = 0;

            DateTime timeMin = DateTime.Parse(listEvent.Items[min].SubItems[2].Text.Trim());

            TimeSpan near = timeMin - now;

            //box rỗng thì chạy tự động
            if (tlstrcbShow.SelectedText == "")
            {
                if ((near.Minutes + near.Hours * 24 + near.Days * 24 * 60) <= 100)
                {
                    tlstrcbShow.SelectedItem = "Minute";
                }
                else if ((near.Hours + near.Days * 24) <= 100)
                {
                    tlstrcbShow.Text = "Hour";
                }
                else
                {
                    tlstrcbShow.Text = "Day";
                }
            }

            //chọn option khác
            switch (tlstrcbShow.Text)
            {
                case "Day":
                    x = near.Days;
                    break;
                case "Hour":
                    x = near.Hours + near.Days * 24;
                    break;
                case "Minute":
                    x = near.Minutes + near.Hours * 24 + near.Days * 24 * 60;
                    break;
            }

            if (x <= 100)
            {
                this.progressbar.Value = x;
            }
            else this.progressbar.Value = 100;
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            this.listSearch.Items.Clear();
            //Find username in listUsers
            List<User> search = this._listUsers.Where(x => x.userName.Contains(this.txtSearchUser.Text)).ToList();
            if (search.Count > 0)
            {
                this.listSearch.Visible = true;
            }
            else
            {
                this.listSearch.Visible = false;
            }

            for(int i = 0; i < search.Count; i++)
            {
                this.listSearch.Items.Add(search[i]);
            }

            if(this.txtSearchUser.Text.Length == 0)
            {
                this.listSearch.Visible = false;
                return;
            }
        }

        private void listSearch_DoubleClick(object sender, EventArgs e)
        {
            if (this.listSearch.SelectedIndex >= 0)
            {
                for(int i = 0; i < this.listName.Items.Count; i++)
                {
                    if(this.listSearch.SelectedItem == this.listName.Items[i])
                    {
                        return;
                    }
                }
                this.listName.Items.Add(this.listSearch.SelectedItem);
            }
        }

        private void listName_DoubleClick(object sender, EventArgs e)
        {
            if (this.listName.SelectedIndex >= 0)
            {
                this.listName.Items.RemoveAt(this.listName.SelectedIndex);
            }
        }
    }

    public class DrawNote
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color color { get; set; }
        public Pen pen { get; set; }
        public bool isDraw { get; set; }

        public DrawNote()
        {
            isDraw = false;
            color = Color.Black;
            pen = new Pen(color, 3);
        }
    }
}
