namespace DigitalClock_StopWatch_FormsApp
{
    partial class ClockDisplayForm
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
            this.CDBackButton = new System.Windows.Forms.Button();
            this.CDExitButton = new System.Windows.Forms.Button();
            this.Timelabel = new System.Windows.Forms.Label();
            this.Clock_timer = new System.Windows.Forms.Timer(this.components);
            this.Datelabel = new System.Windows.Forms.Label();
            this.CDMaxButton = new System.Windows.Forms.Button();
            this.CDMinButton = new System.Windows.Forms.Button();
            this.CDTitlelabel = new System.Windows.Forms.Label();
            this.Daylabel = new System.Windows.Forms.Label();
            this.Date2label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CDBackButton
            // 
            this.CDBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CDBackButton.FlatAppearance.BorderSize = 0;
            this.CDBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CDBackButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDBackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CDBackButton.Location = new System.Drawing.Point(2, 1);
            this.CDBackButton.Name = "CDBackButton";
            this.CDBackButton.Size = new System.Drawing.Size(66, 50);
            this.CDBackButton.TabIndex = 10;
            this.CDBackButton.Text = "<-";
            this.CDBackButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CDBackButton.UseVisualStyleBackColor = false;
            this.CDBackButton.Click += new System.EventHandler(this.CDBackButton_Click_1);
            // 
            // CDExitButton
            // 
            this.CDExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CDExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CDExitButton.FlatAppearance.BorderSize = 0;
            this.CDExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CDExitButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CDExitButton.Location = new System.Drawing.Point(851, 1);
            this.CDExitButton.Name = "CDExitButton";
            this.CDExitButton.Size = new System.Drawing.Size(55, 50);
            this.CDExitButton.TabIndex = 11;
            this.CDExitButton.Text = "X";
            this.CDExitButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CDExitButton.UseVisualStyleBackColor = false;
            this.CDExitButton.Click += new System.EventHandler(this.CDExitButton_Click);
            // 
            // Timelabel
            // 
            this.Timelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Timelabel.AutoSize = true;
            this.Timelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Timelabel.Font = new System.Drawing.Font("Maiandra GD", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Timelabel.Location = new System.Drawing.Point(168, 212);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(443, 112);
            this.Timelabel.TabIndex = 12;
            this.Timelabel.Text = "00:00:00";
            this.Timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clock_timer
            // 
            this.Clock_timer.Enabled = true;
            this.Clock_timer.Tick += new System.EventHandler(this.Clock_timer_Tick);
            // 
            // Datelabel
            // 
            this.Datelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Datelabel.AutoSize = true;
            this.Datelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Datelabel.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Datelabel.Location = new System.Drawing.Point(290, 359);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(313, 77);
            this.Datelabel.TabIndex = 13;
            this.Datelabel.Text = "1/31/2024";
            this.Datelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CDMaxButton
            // 
            this.CDMaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CDMaxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CDMaxButton.FlatAppearance.BorderSize = 0;
            this.CDMaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CDMaxButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDMaxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CDMaxButton.Location = new System.Drawing.Point(790, 1);
            this.CDMaxButton.Name = "CDMaxButton";
            this.CDMaxButton.Size = new System.Drawing.Size(55, 50);
            this.CDMaxButton.TabIndex = 14;
            this.CDMaxButton.Text = "□";
            this.CDMaxButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CDMaxButton.UseVisualStyleBackColor = false;
            this.CDMaxButton.Click += new System.EventHandler(this.CDMaxButton_Click);
            // 
            // CDMinButton
            // 
            this.CDMinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CDMinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CDMinButton.FlatAppearance.BorderSize = 0;
            this.CDMinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CDMinButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDMinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CDMinButton.Location = new System.Drawing.Point(729, 1);
            this.CDMinButton.Name = "CDMinButton";
            this.CDMinButton.Size = new System.Drawing.Size(55, 50);
            this.CDMinButton.TabIndex = 15;
            this.CDMinButton.Text = "─";
            this.CDMinButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CDMinButton.UseVisualStyleBackColor = false;
            this.CDMinButton.Click += new System.EventHandler(this.CDMinButton_Click);
            // 
            // CDTitlelabel
            // 
            this.CDTitlelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CDTitlelabel.AutoSize = true;
            this.CDTitlelabel.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDTitlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CDTitlelabel.Location = new System.Drawing.Point(239, 125);
            this.CDTitlelabel.Name = "CDTitlelabel";
            this.CDTitlelabel.Size = new System.Drawing.Size(508, 87);
            this.CDTitlelabel.TabIndex = 16;
            this.CDTitlelabel.Text = "TimeMaster Pro";
            // 
            // Daylabel
            // 
            this.Daylabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Daylabel.AutoSize = true;
            this.Daylabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Daylabel.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daylabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Daylabel.Location = new System.Drawing.Point(361, 324);
            this.Daylabel.Name = "Daylabel";
            this.Daylabel.Size = new System.Drawing.Size(65, 35);
            this.Daylabel.TabIndex = 17;
            this.Daylabel.Text = "Day";
            this.Daylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Date2label
            // 
            this.Date2label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Date2label.AutoSize = true;
            this.Date2label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Date2label.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date2label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Date2label.Location = new System.Drawing.Point(244, 436);
            this.Date2label.Name = "Date2label";
            this.Date2label.Size = new System.Drawing.Size(359, 57);
            this.Date2label.TabIndex = 18;
            this.Date2label.Text = "month day year";
            this.Date2label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClockDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(906, 640);
            this.Controls.Add(this.Date2label);
            this.Controls.Add(this.Daylabel);
            this.Controls.Add(this.CDTitlelabel);
            this.Controls.Add(this.CDMinButton);
            this.Controls.Add(this.CDMaxButton);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.CDExitButton);
            this.Controls.Add(this.CDBackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClockDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ClockDisplayForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClockDisplayForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClockDisplayForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClockDisplayForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CDBackButton;
        private System.Windows.Forms.Button CDExitButton;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Timer Clock_timer;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Button CDMaxButton;
        private System.Windows.Forms.Button CDMinButton;
        private System.Windows.Forms.Label CDTitlelabel;
        private System.Windows.Forms.Label Daylabel;
        private System.Windows.Forms.Label Date2label;
    }
}