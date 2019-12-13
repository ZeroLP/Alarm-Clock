namespace Alarm_Clock
{
    partial class AlarmView
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
            this.HoursText = new System.Windows.Forms.Label();
            this.MinutesText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AMButton = new System.Windows.Forms.Button();
            this.PMButton = new System.Windows.Forms.Button();
            this.SetAlarmButton = new System.Windows.Forms.Button();
            this.AMPMText = new System.Windows.Forms.Label();
            this.HoursPlusButton = new System.Windows.Forms.Button();
            this.HoursMinusButton = new System.Windows.Forms.Button();
            this.MinutesPlusButton = new System.Windows.Forms.Button();
            this.MinutesMinusButton = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HoursText
            // 
            this.HoursText.AutoSize = true;
            this.HoursText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursText.Location = new System.Drawing.Point(79, 70);
            this.HoursText.Name = "HoursText";
            this.HoursText.Size = new System.Drawing.Size(55, 39);
            this.HoursText.TabIndex = 0;
            this.HoursText.Text = "00";
            // 
            // MinutesText
            // 
            this.MinutesText.AutoSize = true;
            this.MinutesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutesText.Location = new System.Drawing.Point(153, 70);
            this.MinutesText.Name = "MinutesText";
            this.MinutesText.Size = new System.Drawing.Size(55, 39);
            this.MinutesText.TabIndex = 1;
            this.MinutesText.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // AMButton
            // 
            this.AMButton.Location = new System.Drawing.Point(289, 53);
            this.AMButton.Name = "AMButton";
            this.AMButton.Size = new System.Drawing.Size(75, 33);
            this.AMButton.TabIndex = 3;
            this.AMButton.Text = "AM";
            this.AMButton.UseVisualStyleBackColor = true;
            this.AMButton.Click += new System.EventHandler(this.AMButton_Click);
            // 
            // PMButton
            // 
            this.PMButton.Location = new System.Drawing.Point(289, 92);
            this.PMButton.Name = "PMButton";
            this.PMButton.Size = new System.Drawing.Size(75, 32);
            this.PMButton.TabIndex = 4;
            this.PMButton.Text = "PM";
            this.PMButton.UseVisualStyleBackColor = true;
            this.PMButton.Click += new System.EventHandler(this.PMButton_Click);
            // 
            // SetAlarmButton
            // 
            this.SetAlarmButton.Location = new System.Drawing.Point(120, 167);
            this.SetAlarmButton.Name = "SetAlarmButton";
            this.SetAlarmButton.Size = new System.Drawing.Size(110, 38);
            this.SetAlarmButton.TabIndex = 5;
            this.SetAlarmButton.Text = "Set Alarm";
            this.SetAlarmButton.UseVisualStyleBackColor = true;
            this.SetAlarmButton.Click += new System.EventHandler(this.SetAlarmButton_Click);
            // 
            // AMPMText
            // 
            this.AMPMText.AutoSize = true;
            this.AMPMText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMPMText.Location = new System.Drawing.Point(211, 70);
            this.AMPMText.Name = "AMPMText";
            this.AMPMText.Size = new System.Drawing.Size(69, 39);
            this.AMPMText.TabIndex = 6;
            this.AMPMText.Text = "AM";
            // 
            // HoursPlusButton
            // 
            this.HoursPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursPlusButton.Location = new System.Drawing.Point(75, 25);
            this.HoursPlusButton.Name = "HoursPlusButton";
            this.HoursPlusButton.Size = new System.Drawing.Size(59, 42);
            this.HoursPlusButton.TabIndex = 7;
            this.HoursPlusButton.Text = "+";
            this.HoursPlusButton.UseVisualStyleBackColor = true;
            this.HoursPlusButton.Click += new System.EventHandler(this.HoursPlusButton_Click);
            // 
            // HoursMinusButton
            // 
            this.HoursMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursMinusButton.Location = new System.Drawing.Point(75, 113);
            this.HoursMinusButton.Name = "HoursMinusButton";
            this.HoursMinusButton.Size = new System.Drawing.Size(59, 42);
            this.HoursMinusButton.TabIndex = 8;
            this.HoursMinusButton.Text = "-";
            this.HoursMinusButton.UseVisualStyleBackColor = true;
            this.HoursMinusButton.Click += new System.EventHandler(this.HoursMinusButton_Click);
            // 
            // MinutesPlusButton
            // 
            this.MinutesPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutesPlusButton.Location = new System.Drawing.Point(149, 25);
            this.MinutesPlusButton.Name = "MinutesPlusButton";
            this.MinutesPlusButton.Size = new System.Drawing.Size(59, 42);
            this.MinutesPlusButton.TabIndex = 9;
            this.MinutesPlusButton.Text = "+";
            this.MinutesPlusButton.UseVisualStyleBackColor = true;
            this.MinutesPlusButton.Click += new System.EventHandler(this.MinutesPlusButton_Click);
            // 
            // MinutesMinusButton
            // 
            this.MinutesMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutesMinusButton.Location = new System.Drawing.Point(149, 113);
            this.MinutesMinusButton.Name = "MinutesMinusButton";
            this.MinutesMinusButton.Size = new System.Drawing.Size(59, 42);
            this.MinutesMinusButton.TabIndex = 10;
            this.MinutesMinusButton.Text = "-";
            this.MinutesMinusButton.UseVisualStyleBackColor = true;
            this.MinutesMinusButton.Click += new System.EventHandler(this.MinutesMinusButton_Click);
            // 
            // AlarmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 217);
            this.Controls.Add(this.MinutesMinusButton);
            this.Controls.Add(this.MinutesPlusButton);
            this.Controls.Add(this.HoursMinusButton);
            this.Controls.Add(this.HoursPlusButton);
            this.Controls.Add(this.AMPMText);
            this.Controls.Add(this.SetAlarmButton);
            this.Controls.Add(this.PMButton);
            this.Controls.Add(this.AMButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinutesText);
            this.Controls.Add(this.HoursText);
            this.Name = "AlarmView";
            this.Text = "Alarm Clock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlarmView_FormClosing);
            this.Load += new System.EventHandler(this.AlarmView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HoursText;
        private System.Windows.Forms.Label MinutesText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AMButton;
        private System.Windows.Forms.Button PMButton;
        private System.Windows.Forms.Button SetAlarmButton;
        private System.Windows.Forms.Label AMPMText;
        private System.Windows.Forms.Button HoursPlusButton;
        private System.Windows.Forms.Button HoursMinusButton;
        private System.Windows.Forms.Button MinutesPlusButton;
        private System.Windows.Forms.Button MinutesMinusButton;
        public System.Windows.Forms.Timer Timer1;
    }
}

