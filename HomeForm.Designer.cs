namespace DigitalClock_StopWatch_FormsApp
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HomeTitlelabel = new System.Windows.Forms.Label();
            this.HClockDisplayButton = new ePOSOne.btnProduct.Button_WOC();
            this.HStopwatchButton = new ePOSOne.btnProduct.Button_WOC();
            this.HTimerButton = new ePOSOne.btnProduct.Button_WOC();
            this.HExiteButton = new System.Windows.Forms.Button();
            this.HMaxButton = new System.Windows.Forms.Button();
            this.HMinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeTitlelabel
            // 
            this.HomeTitlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HomeTitlelabel.AutoSize = true;
            this.HomeTitlelabel.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitlelabel.Location = new System.Drawing.Point(232, 86);
            this.HomeTitlelabel.Name = "HomeTitlelabel";
            this.HomeTitlelabel.Size = new System.Drawing.Size(508, 87);
            this.HomeTitlelabel.TabIndex = 0;
            this.HomeTitlelabel.Text = "TimeMaster Pro";
            // 
            // HClockDisplayButton
            // 
            this.HClockDisplayButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HClockDisplayButton.BorderColor = System.Drawing.Color.Orange;
            this.HClockDisplayButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HClockDisplayButton.FlatAppearance.BorderSize = 0;
            this.HClockDisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HClockDisplayButton.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HClockDisplayButton.Location = new System.Drawing.Point(329, 190);
            this.HClockDisplayButton.Name = "HClockDisplayButton";
            this.HClockDisplayButton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.HClockDisplayButton.OnHoverButtonColor = System.Drawing.Color.Green;
            this.HClockDisplayButton.OnHoverTextColor = System.Drawing.Color.White;
            this.HClockDisplayButton.Size = new System.Drawing.Size(212, 87);
            this.HClockDisplayButton.TabIndex = 4;
            this.HClockDisplayButton.Text = "Clock Display";
            this.HClockDisplayButton.TextColor = System.Drawing.Color.White;
            this.HClockDisplayButton.UseVisualStyleBackColor = false;
            this.HClockDisplayButton.Click += new System.EventHandler(this.HClockDisplayButton_Click);
            // 
            // HStopwatchButton
            // 
            this.HStopwatchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HStopwatchButton.BorderColor = System.Drawing.Color.Orange;
            this.HStopwatchButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HStopwatchButton.FlatAppearance.BorderSize = 0;
            this.HStopwatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HStopwatchButton.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HStopwatchButton.Location = new System.Drawing.Point(329, 414);
            this.HStopwatchButton.Name = "HStopwatchButton";
            this.HStopwatchButton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.HStopwatchButton.OnHoverButtonColor = System.Drawing.Color.Green;
            this.HStopwatchButton.OnHoverTextColor = System.Drawing.Color.White;
            this.HStopwatchButton.Size = new System.Drawing.Size(212, 87);
            this.HStopwatchButton.TabIndex = 7;
            this.HStopwatchButton.Text = "Stopwatch";
            this.HStopwatchButton.TextColor = System.Drawing.Color.White;
            this.HStopwatchButton.UseVisualStyleBackColor = true;
            this.HStopwatchButton.Click += new System.EventHandler(this.HStopwatchButton_Click);
            // 
            // HTimerButton
            // 
            this.HTimerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HTimerButton.BorderColor = System.Drawing.Color.Orange;
            this.HTimerButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HTimerButton.FlatAppearance.BorderSize = 0;
            this.HTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HTimerButton.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTimerButton.Location = new System.Drawing.Point(329, 303);
            this.HTimerButton.Name = "HTimerButton";
            this.HTimerButton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.HTimerButton.OnHoverButtonColor = System.Drawing.Color.Green;
            this.HTimerButton.OnHoverTextColor = System.Drawing.Color.White;
            this.HTimerButton.Size = new System.Drawing.Size(212, 87);
            this.HTimerButton.TabIndex = 8;
            this.HTimerButton.Text = "Timer";
            this.HTimerButton.TextColor = System.Drawing.Color.White;
            this.HTimerButton.UseVisualStyleBackColor = true;
            this.HTimerButton.Click += new System.EventHandler(this.HTimerButton_Click);
            // 
            // HExiteButton
            // 
            this.HExiteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HExiteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HExiteButton.FlatAppearance.BorderSize = 0;
            this.HExiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HExiteButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HExiteButton.Location = new System.Drawing.Point(850, 1);
            this.HExiteButton.Name = "HExiteButton";
            this.HExiteButton.Size = new System.Drawing.Size(55, 50);
            this.HExiteButton.TabIndex = 9;
            this.HExiteButton.Text = "X";
            this.HExiteButton.UseVisualStyleBackColor = false;
            this.HExiteButton.Click += new System.EventHandler(this.HExiteButton_Click);
            // 
            // HMaxButton
            // 
            this.HMaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HMaxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HMaxButton.FlatAppearance.BorderSize = 0;
            this.HMaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HMaxButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HMaxButton.Location = new System.Drawing.Point(789, 1);
            this.HMaxButton.Name = "HMaxButton";
            this.HMaxButton.Size = new System.Drawing.Size(55, 50);
            this.HMaxButton.TabIndex = 10;
            this.HMaxButton.Text = "□";
            this.HMaxButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HMaxButton.UseVisualStyleBackColor = false;
            this.HMaxButton.Click += new System.EventHandler(this.HMaxButton_Click);
            // 
            // HMinButton
            // 
            this.HMinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HMinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HMinButton.FlatAppearance.BorderSize = 0;
            this.HMinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HMinButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HMinButton.Location = new System.Drawing.Point(728, 1);
            this.HMinButton.Name = "HMinButton";
            this.HMinButton.Size = new System.Drawing.Size(55, 50);
            this.HMinButton.TabIndex = 11;
            this.HMinButton.Text = "─";
            this.HMinButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HMinButton.UseVisualStyleBackColor = false;
            this.HMinButton.Click += new System.EventHandler(this.HMinButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(906, 640);
            this.Controls.Add(this.HMinButton);
            this.Controls.Add(this.HMaxButton);
            this.Controls.Add(this.HExiteButton);
            this.Controls.Add(this.HTimerButton);
            this.Controls.Add(this.HStopwatchButton);
            this.Controls.Add(this.HClockDisplayButton);
            this.Controls.Add(this.HomeTitlelabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomeForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeTitlelabel;
        private ePOSOne.btnProduct.Button_WOC HClockDisplayButton;
        private ePOSOne.btnProduct.Button_WOC HStopwatchButton;
        private ePOSOne.btnProduct.Button_WOC HTimerButton;
        private System.Windows.Forms.Button HExiteButton;
        private System.Windows.Forms.Button HMaxButton;
        private System.Windows.Forms.Button HMinButton;
    }
}

