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
    public partial class ClockDisplayForm : Form
    {
        private bool drag = false;
        private Point startpoint = new Point(0, 0);

        public ClockDisplayForm()
        {
            InitializeComponent();
        }

        

        private void ClockDisplayForm_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void ClockDisplayForm_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void ClockDisplayForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }
        private void CDBackButton_Click_1(object sender, EventArgs e)
        {
            var home = new HomeForm();

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
                home.StartPosition = FormStartPosition.CenterScreen;
                home.Show();
                this.Hide();
            }
        }

        private void CDExitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "TimeMaster Pro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
        private void ClockDisplayForm_Load(object sender, EventArgs e)
        {
            Clock_timer.Start();
            Datelabel.Text = DateTime.Now.ToString("M/d/yyyy");
            Daylabel.Text = DateTime.Now.ToString("dddd");
            Date2label.Text = DateTime.Now.ToString("MMMM dd yyyy");

        }
        
        private void Clock_timer_Tick(object sender, EventArgs e)
        {
            Timelabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            
        }

        private void CDMaxButton_Click(object sender, EventArgs e)
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

        private void CDMinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
    }
}
