using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DigitalClock_StopWatch_FormsApp
{
    public partial class StopwatchForm : Form
    {
        private bool drag = false;
        private Point startpoint = new Point(0, 0);
        private Stopwatch stopwatch;
        String recordInfo = "{0,-10}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}";
        public StopwatchForm()
        {
            InitializeComponent();
        }

        private void SWBackButton_Click(object sender, EventArgs e)
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

        private void StopwatchForm_Load(object sender, EventArgs e)
        {
          SWLaplistBox.Items.Add(string.Format(recordInfo, "Record#", " ", " ", " ", " ", " ", "Time"));
          stopwatch = new Stopwatch();
        }

        private void SWMinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SWMaxButton_Click(object sender, EventArgs e)
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

        private void SWExitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "TimeMaster Pro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void SWStartButton_Click(object sender, EventArgs e)
        { 
           stopwatch.Start();
        }

        private void SWStopButton_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }
        private void Clearbutton_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            SWLaplistBox.Items.Clear();
            SWLaplistBox.Items.Add(string.Format(recordInfo, "Record#", " ", " ", " ", " ", " ", " Time"));
        }

        private void SWResetButton_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();

            /*DialogResult iReset;
            iReset = MessageBox.Show("Would you like to Reset just the stopwatch or also the Record List\n\n 'Yes' for just the stopwatch\n 'No' for everthing", "TimeMaster Pro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iReset == DialogResult.Yes)
            {
                stopwatch.Reset();
            }
            else
            {
                stopwatch.Reset();
                SWLaplistBox.Items.Clear();
            }*/


        }
       
        private void SWSaveTimebutton_Click(object sender, EventArgs e)
        {
            SWLaplistBox.Items.Add(string.Format(recordInfo, SWLaplistBox.Items.Count  , "  ", "  ", "  ", "  ", "  ",  Timelabel.Text));
            /*SWLaplistBox.Items.Add($"Record {SWLaplistBox.Items.Count +1}    Time:({Timelabel.Text})");*/
        }
        private void SWtimer_Tick(object sender, EventArgs e)
        {
            
            this.Timelabel.Text = stopwatch.Elapsed.ToString("mm\\:ss\\.ff");
        }
       
        private void StopwatchForm_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void StopwatchForm_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void StopwatchForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }

      
    }
}
