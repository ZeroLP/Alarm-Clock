using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock
{
    public partial class AlarmView : Form
    {
        public AlarmView()
        {
            InitializeComponent();
        }

        public static Timer GlobalTimer;
        public static bool IsAlarmSet = false;
        public static string AlarmTime = "00:00 AM";

        private void AlarmView_Load(object sender, EventArgs e)
        {
            GlobalTimer = Timer1;
            Modules.Tick.InitialiseTick();
        }

        private void AlarmView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modules.Tick.TerminateTick();
        }

        private void HoursPlusButton_Click(object sender, EventArgs e)
        {
            if(HoursText.Text != "12")
            {
                int IncreasedHours = int.Parse(HoursText.Text) + 1;
                HoursText.Text = $"{IncreasedHours}";
            }
        }

        private void HoursMinusButton_Click(object sender, EventArgs e)
        {
            if(HoursText.Text == "1" || HoursText.Text == "00")
            {
                HoursText.Text = "00";
            }
            else
            {
                int DecreasedHours = int.Parse(HoursText.Text) - 1;
                HoursText.Text = $"{DecreasedHours}";
            }
        }

        private void MinutesPlusButton_Click(object sender, EventArgs e)
        {
            if (MinutesText.Text != "59")
            {
                int IncreasedMinutes = int.Parse(MinutesText.Text) + 1;
                MinutesText.Text = $"{IncreasedMinutes}";
            }
        }

        private void MinutesMinusButton_Click(object sender, EventArgs e)
        {
            if (MinutesText.Text == "1" || MinutesText.Text == "00")
            {
                MinutesText.Text = "00";
            }
            else
            {
                int DecreasedMinutes = int.Parse(MinutesText.Text) - 1;
                MinutesText.Text = $"{DecreasedMinutes}";
            }
        }

        private void PMButton_Click(object sender, EventArgs e)
        {
            AMPMText.Text = "PM";
        }

        private void AMButton_Click(object sender, EventArgs e)
        {
            AMPMText.Text = "AM";
        }

        private void SetAlarmButton_Click(object sender, EventArgs e)
        {
            if(HoursText.Text == "00" && MinutesText.Text == "00" || IsAlarmSet == true)
            {
                if (HoursText.Text == "00" && MinutesText.Text == "00") MessageBox.Show("Please set a time for the alarm.");
                MessageBox.Show("Alarm is already Set");
            }
            else
            {
                AlarmTime = $"{HoursText.Text}:{MinutesText.Text} {AMPMText.Text}";

                MessageBox.Show($"Alarm set for {AlarmTime}");
                IsAlarmSet = true;
            }
        }
    }
}
