namespace DigitalClock_StopWatch_FormsApp
{
    partial class StopwatchForm
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
            this.components = new System.ComponentModel.Container();
            this.SWMinButton = new System.Windows.Forms.Button();
            this.SWMaxButton = new System.Windows.Forms.Button();
            this.SWExitButton = new System.Windows.Forms.Button();
            this.SWBackButton = new System.Windows.Forms.Button();
            this.SWTitlelabel = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.SWtimer = new System.Windows.Forms.Timer(this.components);
            this.SWLaplistBox = new System.Windows.Forms.ListBox();
            this.Clearbutton = new ePOSOne.btnProduct.Button_WOC();
            this.SWSaveTimebutton = new ePOSOne.btnProduct.Button_WOC();
            this.SWStopButton = new ePOSOne.btnProduct.Button_WOC();
            this.SWResetButton = new ePOSOne.btnProduct.Button_WOC();
            this.SWStartButton = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // SWMinButton
            // 
            this.SWMinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SWMinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SWMinButton.FlatAppearance.BorderSize = 0;
            this.SWMinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SWMinButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWMinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SWMinButton.Location = new System.Drawing.Point(726, 0);
            this.SWMinButton.Name = "SWMinButton";
            this.SWMinButton.Size = new System.Drawing.Size(55, 50);
            this.SWMinButton.TabIndex = 19;
            this.SWMinButton.Text = "─";
            this.SWMinButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SWMinButton.UseVisualStyleBackColor = false;
            this.SWMinButton.Click += new System.EventHandler(this.SWMinButton_Click);
            // 
            // SWMaxButton
            // 
            this.SWMaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SWMaxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SWMaxButton.FlatAppearance.BorderSize = 0;
            this.SWMaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SWMaxButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWMaxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SWMaxButton.Location = new System.Drawing.Point(787, 0);
            this.SWMaxButton.Name = "SWMaxButton";
            this.SWMaxButton.Size = new System.Drawing.Size(55, 50);
            this.SWMaxButton.TabIndex = 18;
            this.SWMaxButton.Text = "□";
            this.SWMaxButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SWMaxButton.UseVisualStyleBackColor = false;
            this.SWMaxButton.Click += new System.EventHandler(this.SWMaxButton_Click);
            // 
            // SWExitButton
            // 
            this.SWExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SWExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SWExitButton.FlatAppearance.BorderSize = 0;
            this.SWExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SWExitButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SWExitButton.Location = new System.Drawing.Point(848, 0);
            this.SWExitButton.Name = "SWExitButton";
            this.SWExitButton.Size = new System.Drawing.Size(55, 50);
            this.SWExitButton.TabIndex = 17;
            this.SWExitButton.Text = "X";
            this.SWExitButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.SWExitButton.UseVisualStyleBackColor = false;
            this.SWExitButton.Click += new System.EventHandler(this.SWExitButton_Click);
            // 
            // SWBackButton
            // 
            this.SWBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SWBackButton.FlatAppearance.BorderSize = 0;
            this.SWBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SWBackButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWBackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SWBackButton.Location = new System.Drawing.Point(1, 0);
            this.SWBackButton.Name = "SWBackButton";
            this.SWBackButton.Size = new System.Drawing.Size(66, 50);
            this.SWBackButton.TabIndex = 16;
            this.SWBackButton.Text = "<-";
            this.SWBackButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SWBackButton.UseVisualStyleBackColor = false;
            this.SWBackButton.Click += new System.EventHandler(this.SWBackButton_Click);
            // 
            // SWTitlelabel
            // 
            this.SWTitlelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SWTitlelabel.AutoSize = true;
            this.SWTitlelabel.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWTitlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SWTitlelabel.Location = new System.Drawing.Point(212, 38);
            this.SWTitlelabel.Name = "SWTitlelabel";
            this.SWTitlelabel.Size = new System.Drawing.Size(508, 87);
            this.SWTitlelabel.TabIndex = 20;
            this.SWTitlelabel.Text = "TimeMaster Pro";
            this.SWTitlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timelabel
            // 
            this.Timelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Timelabel.AutoSize = true;
            this.Timelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Timelabel.Font = new System.Drawing.Font("Maiandra GD", 75.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Timelabel.Location = new System.Drawing.Point(219, 111);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(476, 121);
            this.Timelabel.TabIndex = 21;
            this.Timelabel.Text = "00:00:00";
            this.Timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SWtimer
            // 
            this.SWtimer.Enabled = true;
            this.SWtimer.Tick += new System.EventHandler(this.SWtimer_Tick);
            // 
            // SWLaplistBox
            // 
            this.SWLaplistBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SWLaplistBox.BackColor = System.Drawing.Color.Silver;
            this.SWLaplistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SWLaplistBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWLaplistBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SWLaplistBox.FormattingEnabled = true;
            this.SWLaplistBox.ItemHeight = 26;
            this.SWLaplistBox.Location = new System.Drawing.Point(85, 459);
            this.SWLaplistBox.Name = "SWLaplistBox";
            this.SWLaplistBox.Size = new System.Drawing.Size(680, 156);
            this.SWLaplistBox.TabIndex = 25;
            // 
            // Clearbutton
            // 
            this.Clearbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Clearbutton.BorderColor = System.Drawing.Color.Orange;
            this.Clearbutton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Clearbutton.FlatAppearance.BorderSize = 0;
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.Location = new System.Drawing.Point(448, 357);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.Clearbutton.OnHoverButtonColor = System.Drawing.Color.Green;
            this.Clearbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.Clearbutton.Size = new System.Drawing.Size(212, 87);
            this.Clearbutton.TabIndex = 27;
            this.Clearbutton.Text = "Clear All";
            this.Clearbutton.TextColor = System.Drawing.Color.White;
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // SWSaveTimebutton
            // 
            this.SWSaveTimebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SWSaveTimebutton.BorderColor = System.Drawing.Color.Orange;
            this.SWSaveTimebutton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SWSaveTimebutton.FlatAppearance.BorderSize = 0;
            this.SWSaveTimebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SWSaveTimebutton.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWSaveTimebutton.Location = new System.Drawing.Point(217, 357);
            this.SWSaveTimebutton.Name = "SWSaveTimebutton";
            this.SWSaveTimebutton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.SWSaveTimebutton.OnHoverButtonColor = System.Drawing.Color.Green;
            this.SWSaveTimebutton.OnHoverTextColor = System.Drawing.Color.White;
            this.SWSaveTimebutton.Size = new System.Drawing.Size(212, 87);
            this.SWSaveTimebutton.TabIndex = 26;
            this.SWSaveTimebutton.Text = "Save Time";
            this.SWSaveTimebutton.TextColor = System.Drawing.Color.White;
            this.SWSaveTimebutton.UseVisualStyleBackColor = true;
            this.SWSaveTimebutton.Click += new System.EventHandler(this.SWSaveTimebutton_Click);
            // 
            // SWStopButton
            // 
            this.SWStopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SWStopButton.BorderColor = System.Drawing.Color.Orange;
            this.SWStopButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SWStopButton.FlatAppearance.BorderSize = 0;
            this.SWStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SWStopButton.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWStopButton.Location = new System.Drawing.Point(318, 252);
            this.SWStopButton.Name = "SWStopButton";
            this.SWStopButton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.SWStopButton.OnHoverButtonColor = System.Drawing.Color.Green;
            this.SWStopButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SWStopButton.Size = new System.Drawing.Size(212, 87);
            this.SWStopButton.TabIndex = 24;
            this.SWStopButton.Text = "Stop";
            this.SWStopButton.TextColor = System.Drawing.Color.White;
            this.SWStopButton.UseVisualStyleBackColor = true;
            this.SWStopButton.Click += new System.EventHandler(this.SWStopButton_Click);
            // 
            // SWResetButton
            // 
            this.SWResetButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SWResetButton.BorderColor = System.Drawing.Color.Orange;
            this.SWResetButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SWResetButton.FlatAppearance.BorderSize = 0;
            this.SWResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SWResetButton.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWResetButton.Location = new System.Drawing.Point(553, 252);
            this.SWResetButton.Name = "SWResetButton";
            this.SWResetButton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.SWResetButton.OnHoverButtonColor = System.Drawing.Color.Green;
            this.SWResetButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SWResetButton.Size = new System.Drawing.Size(212, 87);
            this.SWResetButton.TabIndex = 23;
            this.SWResetButton.Text = "Reset Watch";
            this.SWResetButton.TextColor = System.Drawing.Color.White;
            this.SWResetButton.UseVisualStyleBackColor = true;
            this.SWResetButton.Click += new System.EventHandler(this.SWResetButton_Click);
            // 
            // SWStartButton
            // 
            this.SWStartButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SWStartButton.BorderColor = System.Drawing.Color.Orange;
            this.SWStartButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SWStartButton.FlatAppearance.BorderSize = 0;
            this.SWStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SWStartButton.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWStartButton.Location = new System.Drawing.Point(85, 252);
            this.SWStartButton.Name = "SWStartButton";
            this.SWStartButton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.SWStartButton.OnHoverButtonColor = System.Drawing.Color.Green;
            this.SWStartButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SWStartButton.Size = new System.Drawing.Size(212, 87);
            this.SWStartButton.TabIndex = 22;
            this.SWStartButton.Text = "Start";
            this.SWStartButton.TextColor = System.Drawing.Color.White;
            this.SWStartButton.UseVisualStyleBackColor = false;
            this.SWStartButton.Click += new System.EventHandler(this.SWStartButton_Click);
            // 
            // StopwatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(906, 640);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.SWSaveTimebutton);
            this.Controls.Add(this.SWLaplistBox);
            this.Controls.Add(this.SWStopButton);
            this.Controls.Add(this.SWResetButton);
            this.Controls.Add(this.SWStartButton);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.SWTitlelabel);
            this.Controls.Add(this.SWMinButton);
            this.Controls.Add(this.SWMaxButton);
            this.Controls.Add(this.SWExitButton);
            this.Controls.Add(this.SWBackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StopwatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StopwatchForm";
            this.Load += new System.EventHandler(this.StopwatchForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StopwatchForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StopwatchForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopwatchForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SWMinButton;
        private System.Windows.Forms.Button SWMaxButton;
        private System.Windows.Forms.Button SWExitButton;
        private System.Windows.Forms.Button SWBackButton;
        private System.Windows.Forms.Label SWTitlelabel;
        private System.Windows.Forms.Label Timelabel;
        private ePOSOne.btnProduct.Button_WOC SWStopButton;
        private ePOSOne.btnProduct.Button_WOC SWResetButton;
        private ePOSOne.btnProduct.Button_WOC SWStartButton;
        private System.Windows.Forms.Timer SWtimer;
        private System.Windows.Forms.ListBox SWLaplistBox;
        private ePOSOne.btnProduct.Button_WOC SWSaveTimebutton;
        private ePOSOne.btnProduct.Button_WOC Clearbutton;
    }
}