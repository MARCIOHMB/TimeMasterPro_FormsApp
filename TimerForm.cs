using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock_StopWatch_FormsApp
{
    public partial class TimerForm : Form
    {
        private bool drag = false;
        private Point startpoint = new Point(0, 0);
       
        public TimerForm()
        {
            InitializeComponent();
        }

        private void TBackButton_Click(object sender, EventArgs e)
        {
            var home = new HomeForm();

            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                home.WindowState = FormWindowState.Maximized;
                ;
                home.Show();
                this.Hide();
            }
            else
            {
                home.WindowState = FormWindowState.Normal;
                home.StartPosition = FormStartPosition.CenterScreen;
                home.Show();
                this.Hide();
            }
        }

        private void TMinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TMaxButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void TExitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "TimeMaster Pro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void TimerForm_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void TimerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }

        private void TimerForm_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan newtimespan = timer - (DateTime.Now - start);
            THR_textBox.Text = newtimespan.Hours.ToString();
            TMin_textBox.Text = newtimespan.Minutes.ToString();
            TSec_textBox.Text = newtimespan.Seconds.ToString();
            if (newtimespan.Seconds <=0 && newtimespan.Minutes <=0 && newtimespan.Seconds <=0)
            {
                T_timer.Stop();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                MessageBox.Show("Timer Ended", "TimeMaster Pro");
            }
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            THR_textBox.Text = "0";
            TMin_textBox.Text = "0";
            TSec_textBox.Text = "0";
        }
        
        DateTime start;
        TimeSpan timer;  
        private void T_StartButton_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            int hours = Convert.ToInt32(THR_textBox.Text);
            int minutes = Convert.ToInt32(TMin_textBox.Text);
            int seconds = Convert.ToInt32(TSec_textBox.Text);
            int total = (hours * 60) + (minutes * 60) + seconds;
            timer = TimeSpan.FromSeconds(total);
            T_timer.Enabled = true;
        }
        private void SWResetButton_Click(object sender, EventArgs e)
        {
            THR_textBox.Text = "0";
            TMin_textBox.Text = "0";
            TSec_textBox.Text = "0";
        }

        private void SWStopButton_Click(object sender, EventArgs e)
        {
            T_timer.Stop();
        }
    }
}
