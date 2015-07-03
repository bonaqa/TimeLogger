using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tlogger5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            this.Activate();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        int currRow = 0;
        private void cmdStart_Click(object sender, EventArgs e)
        {
            

        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info; //Shows the info icon so the user doesn't thing there is an error.
            this.notifyIcon1.BalloonTipText = "logging in the background";
            this.notifyIcon1.BalloonTipTitle = "";
            this.notifyIcon1.Text = "Time Logger";
        }

        private void tmrDispUpdate_Tick(object sender, EventArgs e)
        {
            DateTime strt = (DateTime)dataGridView1.Rows[0].Cells[0].Value;
            TimeSpan elap = DateTime.Now - strt;
            txtValeotime.Text = elap.ToString(@"hh\:mm");

            TimeSpan sum = new TimeSpan(0);
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (null != dataGridView1.Rows[i].Cells[1].Value){
                    sum = sum.Add((DateTime)dataGridView1.Rows[i].Cells[1].Value -
                        (DateTime)dataGridView1.Rows[i].Cells[0].Value);
                }else{
                    sum =sum.Add(DateTime.Now - (DateTime)dataGridView1.Rows[i].Cells[0].Value);
                }
            }

   
            txtWorktime.Text = sum.ToString(@"hh\:mm");

        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //notifyIcon1.Visible = true;
                //notifyIcon1.ShowBalloonTip(3000);
                //this.Hide();
                //this.ShowInTaskbar = false;
            }
            else
            {
                //this.ShowInTaskbar = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool firsttime = true;
        private void cmdStart_Click_1(object sender, EventArgs e)
        {
            DateTime currt = DateTime.Now;
            currRow = dataGridView1.Rows.Add();
            dataGridView1.Rows[currRow].Cells[0].ValueType = typeof(DateTime);
            dataGridView1.Rows[currRow].Cells[0].Value = currt;
            cmdStart.Enabled = false;
            cmdStop.Enabled = true;
            
            
            if (firsttime){
                firsttime = false;
                txtValeotime.Text = "00:00";
                txtWorktime.Text = "00:00";
                tmrDispUpdate.Enabled = true;

                DateTime breakfast = DateTime.Parse("09:00:00.000");
                DateTime lunch = DateTime.Parse("12:00:00.000");
                TimeSpan end = new TimeSpan(0, 7, 0, 0, 0);

                if (currt.TimeOfDay <= lunch.TimeOfDay)
                {
                    TimeSpan span = new TimeSpan(0, 0, 30, 0, 0);
                    end = end + span;
                }
                if (currt.TimeOfDay <= breakfast.TimeOfDay)
                {
                    TimeSpan span = new TimeSpan(0, 0, 15, 0, 0);
                    end = end + span;
                }
                DateTime end2 = currt + end;
                txtExpectend.Text = end2.ToString(@"hh\:mm");
            }
        }

        private void cmdStop_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows[currRow].Cells[1].ValueType = typeof(DateTime);
            dataGridView1.Rows[currRow].Cells[1].Value = DateTime.Now;

            cmdStart.Enabled = true;
            cmdStop.Enabled = false;
            DateTime strt = (DateTime)dataGridView1.Rows[currRow].Cells[0].Value;
            DateTime stp = (DateTime)dataGridView1.Rows[currRow].Cells[1].Value;
            TimeSpan diff = stp - strt;
            dataGridView1.Rows[currRow].Cells[2].Value = diff.ToString(@"hh\:mm\:ss");

            TimeSpan sum = new TimeSpan(0);
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum = sum.Add((DateTime)dataGridView1.Rows[i].Cells[1].Value -
                    (DateTime)dataGridView1.Rows[i].Cells[0].Value);
            }

            txtWorktime.Text = sum.ToString(@"hh\:mm");
        }


    }
}
