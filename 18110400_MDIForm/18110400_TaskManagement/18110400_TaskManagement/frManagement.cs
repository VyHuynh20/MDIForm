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

        public frTaskManagement()
        {
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
                //tao container add vao listview
                ListViewItem ev = new ListViewItem(this.ID.ToString());
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, this.txtTitle.Text));
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, this.datetimeStart.Value.ToString()));
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, this.datetimeEnd.Value.ToString()));
                ev.SubItems.Add(new ListViewItem.ListViewSubItem(ev, this.rtxtDescription.Text));

                bitmapNote.Save(String.Format("{0}.jpg", this.ID));
                bitmapNote.Dispose();

                this.listEvent.Items.Add(ev);

                bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height, this.picNote.CreateGraphics());
                this.picNote.CreateGraphics().Clear(Color.White);

                //reset
                this.errorAdd.Clear();
                this.txtTitle.Clear();
                this.datetimeStart.ResetText();
                this.datetimeEnd.ResetText();
                this.rtxtDescription.Clear();

                this.ID++;
            }
        }

        private void createNewEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
                this.listEvent.SelectedItems[0].SubItems[1].Text = this.txtTitle.Text;
                this.listEvent.SelectedItems[0].SubItems[2].Text = this.datetimeStart.Value.ToString();
                this.listEvent.SelectedItems[0].SubItems[3].Text = this.datetimeEnd.Value.ToString();
                this.listEvent.SelectedItems[0].SubItems[4].Text = this.rtxtDescription.Text;

                File.Delete(String.Format("{0}.jpg", this.listEvent.SelectedItems[0].SubItems[0].Text));
                bitmapNote.Save(String.Format("{0}.jpg", this.listEvent.SelectedItems[0].SubItems[0].Text.Trim()));

                this.picNote.CreateGraphics().Clear(Color.White);

                bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height);

                this.picNote.DrawToBitmap(bitmapNote, this.picNote.ClientRectangle);

                //reset
                this.txtTitle.Clear();
                this.datetimeStart.ResetText();
                this.datetimeEnd.ResetText();
                this.rtxtDescription.Clear();
                this.errorAdd.Clear();
            }
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            this.picNote.CreateGraphics().Clear(Color.White);

            bitmapNote = new Bitmap(this.picNote.ClientSize.Width, this.picNote.ClientSize.Height, this.picNote.CreateGraphics());
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                    File.Delete(String.Format("delete.jpg"));
                    this.ID--;
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

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frUser formUser = new frUser();
            formUser.Show();
            
            //this.Visible = false;
        }
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

            this.txtTitle.Text = this.listEvent.SelectedItems[0].SubItems[1].Text.Trim();       //trim de bo phan tu du thua
            this.datetimeStart.Value = DateTime.Parse(this.listEvent.SelectedItems[0].SubItems[2].Text.Trim());
            this.datetimeEnd.Value = DateTime.Parse(this.listEvent.SelectedItems[0].SubItems[3].Text.Trim());
            this.rtxtDescription.Text = this.listEvent.SelectedItems[0].SubItems[4].Text.Trim();

            using (FileStream stream = new FileStream(String.Format("{0}.jpg",
               this.listEvent.SelectedItems[0].SubItems[0].Text.Trim()), FileMode.Open, FileAccess.ReadWrite))
            {
                picNote.Image = Image.FromStream(stream);
                bitmapNote = new Bitmap(Image.FromStream(stream));
            }
        }

        private void frTaskManagement_Load(object sender, EventArgs e)
        {
            ID = 1;
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
