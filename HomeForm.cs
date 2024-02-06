using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock_StopWatch_FormsApp
{
    public partial class HomeForm : Form
    {
        private bool drag = false;
        private Point startpoint = new Point(0,0);

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;    
            startpoint = new Point(e.X, e.Y);
        }

        private void HomeForm_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void HomeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag) 
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }

        private void HClockDisplayButton_Click(object sender, EventArgs e)
        {
            var home = new ClockDisplayForm();
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                home.WindowState = FormWindowState.Maximized;
                home.Show();
                this.Hide();
            }
            else
            {
                home.WindowState = FormWindowState.Normal;
                home.Show();
                this.Hide();
            }

        }
  
        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void HMinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void HMaxButton_Click(object sender, EventArgs e)
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

        private void HExiteButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HStopwatchButton_Click(object sender, EventArgs e)
        {
            var home = new StopwatchForm();
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                home.WindowState = FormWindowState.Maximized;
                home.Show();
                this.Hide();
            }
            else
            {
                home.WindowState = FormWindowState.Normal;
                home.Show();
                this.Hide();
            }
        }

        private void HTimerButton_Click(object sender, EventArgs e)
        {
            var home = new TimerForm();
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                home.WindowState = FormWindowState.Maximized;
                home.Show();
                this.Hide();
            }
            else
            {
                home.WindowState = FormWindowState.Normal;
                home.Show();
                this.Hide();
            }
        }
    }
}
