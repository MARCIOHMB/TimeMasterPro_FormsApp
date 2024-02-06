namespace DigitalClock_StopWatch_FormsApp
{
    partial class TimerForm
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
            this.TMinButton = new System.Windows.Forms.Button();
            this.TMaxButton = new System.Windows.Forms.Button();
            this.TExitButton = new System.Windows.Forms.Button();
            this.TBackButton = new System.Windows.Forms.Button();
            this.T_Titlelabel = new System.Windows.Forms.Label();
            this.T_timer = new System.Windows.Forms.Timer(this.components);
            this.TSec_textBox = new System.Windows.Forms.TextBox();
            this.TMin_textBox = new System.Windows.Forms.TextBox();
            this.THR_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SWStopButton = new ePOSOne.btnProduct.Button_WOC();
            this.T_StartButton = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // TMinButton
            // 
            this.TMinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TMinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TMinButton.FlatAppearance.BorderSize = 0;
            this.TMinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMinButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TMinButton.Location = new System.Drawing.Point(727, 1);
            this.TMinButton.Name = "TMinButton";
            this.TMinButton.Size = new System.Drawing.Size(55, 50);
            this.TMinButton.TabIndex = 23;
            this.TMinButton.Text = "─";
            this.TMinButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TMinButton.UseVisualStyleBackColor = false;
            this.TMinButton.Click += new System.EventHandler(this.TMinButton_Click);
            // 
            // TMaxButton
            // 
            this.TMaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TMaxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TMaxButton.FlatAppearance.BorderSize = 0;
            this.TMaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TMaxButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMaxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TMaxButton.Location = new System.Drawing.Point(788, 1);
            this.TMaxButton.Name = "TMaxButton";
            this.TMaxButton.Size = new System.Drawing.Size(55, 50);
            this.TMaxButton.TabIndex = 22;
            this.TMaxButton.Text = "□";
            this.TMaxButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TMaxButton.UseVisualStyleBackColor = false;
            this.TMaxButton.Click += new System.EventHandler(this.TMaxButton_Click);
            // 
            // TExitButton
            // 
            this.TExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TExitButton.FlatAppearance.BorderSize = 0;
            this.TExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TExitButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TExitButton.Location = new System.Drawing.Point(849, 1);
            this.TExitButton.Name = "TExitButton";
            this.TExitButton.Size = new System.Drawing.Size(55, 50);
            this.TExitButton.TabIndex = 21;
            this.TExitButton.Text = "X";
            this.TExitButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.TExitButton.UseVisualStyleBackColor = false;
            this.TExitButton.Click += new System.EventHandler(this.TExitButton_Click);
            // 
            // TBackButton
            // 
            this.TBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TBackButton.FlatAppearance.BorderSize = 0;
            this.TBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TBackButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TBackButton.Location = new System.Drawing.Point(2, 1);
            this.TBackButton.Name = "TBackButton";
            this.TBackButton.Size = new System.Drawing.Size(66, 50);
            this.TBackButton.TabIndex = 20;
            this.TBackButton.Text = "<-";
            this.TBackButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TBackButton.UseVisualStyleBackColor = false;
            this.TBackButton.Click += new System.EventHandler(this.TBackButton_Click);
            // 
            // T_Titlelabel
            // 
            this.T_Titlelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.T_Titlelabel.AutoSize = true;
            this.T_Titlelabel.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Titlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.T_Titlelabel.Location = new System.Drawing.Point(197, 92);
            this.T_Titlelabel.Name = "T_Titlelabel";
            this.T_Titlelabel.Size = new System.Drawing.Size(508, 87);
            this.T_Titlelabel.TabIndex = 25;
            this.T_Titlelabel.Text = "TimeMaster Pro";
            this.T_Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_timer
            // 
            this.T_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TSec_textBox
            // 
            this.TSec_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TSec_textBox.AutoCompleteCustomSource.AddRange(new string[] {
            "00:00:00"});
            this.TSec_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TSec_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TSec_textBox.Font = new System.Drawing.Font("Maiandra GD", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSec_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TSec_textBox.Location = new System.Drawing.Point(561, 221);
            this.TSec_textBox.Name = "TSec_textBox";
            this.TSec_textBox.Size = new System.Drawing.Size(164, 160);
            this.TSec_textBox.TabIndex = 30;
            this.TSec_textBox.Text = "00";
            this.TSec_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TMin_textBox
            // 
            this.TMin_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TMin_textBox.AutoCompleteCustomSource.AddRange(new string[] {
            "00:00:00"});
            this.TMin_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TMin_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TMin_textBox.Font = new System.Drawing.Font("Maiandra GD", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMin_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TMin_textBox.Location = new System.Drawing.Point(344, 221);
            this.TMin_textBox.Name = "TMin_textBox";
            this.TMin_textBox.Size = new System.Drawing.Size(164, 160);
            this.TMin_textBox.TabIndex = 31;
            this.TMin_textBox.Text = "00";
            this.TMin_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // THR_textBox
            // 
            this.THR_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.THR_textBox.AutoCompleteCustomSource.AddRange(new string[] {
            "00:00:00"});
            this.THR_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.THR_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.THR_textBox.Font = new System.Drawing.Font("Maiandra GD", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THR_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.THR_textBox.Location = new System.Drawing.Point(157, 221);
            this.THR_textBox.Name = "THR_textBox";
            this.THR_textBox.Size = new System.Drawing.Size(164, 160);
            this.THR_textBox.TabIndex = 32;
            this.THR_textBox.Text = "00";
            this.THR_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(193, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hours";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(375, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 39);
            this.label2.TabIndex = 34;
            this.label2.Text = "Minutes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(577, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 39);
            this.label3.TabIndex = 35;
            this.label3.Text = "Seconds";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SWStopButton
            // 
            this.SWStopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SWStopButton.BorderColor = System.Drawing.Color.Orange;
            this.SWStopButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SWStopButton.FlatAppearance.BorderSize = 0;
            this.SWStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SWStopButton.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWStopButton.Location = new System.Drawing.Point(466, 398);
            this.SWStopButton.Name = "SWStopButton";
            this.SWStopButton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.SWStopButton.OnHoverButtonColor = System.Drawing.Color.Green;
            this.SWStopButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SWStopButton.Size = new System.Drawing.Size(212, 87);
            this.SWStopButton.TabIndex = 29;
            this.SWStopButton.Text = "Stop";
            this.SWStopButton.TextColor = System.Drawing.Color.White;
            this.SWStopButton.UseVisualStyleBackColor = true;
            this.SWStopButton.Click += new System.EventHandler(this.SWStopButton_Click);
            // 
            // T_StartButton
            // 
            this.T_StartButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.T_StartButton.BorderColor = System.Drawing.Color.Orange;
            this.T_StartButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.T_StartButton.FlatAppearance.BorderSize = 0;
            this.T_StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.T_StartButton.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_StartButton.Location = new System.Drawing.Point(200, 398);
            this.T_StartButton.Name = "T_StartButton";
            this.T_StartButton.OnHoverBorderColor = System.Drawing.Color.Green;
            this.T_StartButton.OnHoverButtonColor = System.Drawing.Color.Green;
            this.T_StartButton.OnHoverTextColor = System.Drawing.Color.White;
            this.T_StartButton.Size = new System.Drawing.Size(212, 87);
            this.T_StartButton.TabIndex = 27;
            this.T_StartButton.Text = "Start";
            this.T_StartButton.TextColor = System.Drawing.Color.White;
            this.T_StartButton.UseVisualStyleBackColor = false;
            this.T_StartButton.Click += new System.EventHandler(this.T_StartButton_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(906, 640);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.THR_textBox);
            this.Controls.Add(this.TMin_textBox);
            this.Controls.Add(this.TSec_textBox);
            this.Controls.Add(this.SWStopButton);
            this.Controls.Add(this.T_StartButton);
            this.Controls.Add(this.T_Titlelabel);
            this.Controls.Add(this.TMinButton);
            this.Controls.Add(this.TMaxButton);
            this.Controls.Add(this.TExitButton);
            this.Controls.Add(this.TBackButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimerForm";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimerForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimerForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TimerForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TMinButton;
        private System.Windows.Forms.Button TMaxButton;
        private System.Windows.Forms.Button TExitButton;
        private System.Windows.Forms.Button TBackButton;
        private ePOSOne.btnProduct.Button_WOC SWStopButton;
        private ePOSOne.btnProduct.Button_WOC T_StartButton;
        private System.Windows.Forms.Label T_Titlelabel;
        private System.Windows.Forms.Timer T_timer;
        private System.Windows.Forms.TextBox TSec_textBox;
        private System.Windows.Forms.TextBox TMin_textBox;
        private System.Windows.Forms.TextBox THR_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}