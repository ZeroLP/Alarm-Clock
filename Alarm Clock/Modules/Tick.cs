using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock.Modules
{
    class Tick
    {
        private static System.Media.SoundPlayer Player = new System.Media.SoundPlayer();

        /// <summary>
        /// Initialises the Tick/Timer
        /// </summary>
        public static void InitialiseTick()
        {
            AlarmView.GlobalTimer = new Timer();
            AlarmView.GlobalTimer.Enabled = true;
            AlarmView.GlobalTimer.Tick += new EventHandler(Timer1_Tick);
            AlarmView.GlobalTimer.Interval = 1000; //1 Second
            AlarmView.GlobalTimer.Start();
        }

        /// <summary>
        /// Terminates the Tick/Timer
        /// </summary>
        public static void TerminateTick()
        {
            AlarmView.GlobalTimer.Stop();
            AlarmView.GlobalTimer.Dispose();
        }

        /// <summary>
        /// Timer tick Event/Callback
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Timer1_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now.ToString("h:mm tt") == AlarmView.AlarmTime && AlarmView.IsAlarmSet == true) || (DateTime.Now.ToString("h:m tt") == AlarmView.AlarmTime && AlarmView.IsAlarmSet == true))
            {
                PlayScream();
                //AlarmView.IsAlarmSet = false; //For single scream play
            }
        }

        /// <summary>
        /// Plays the scream
        /// </summary>
        private static void PlayScream()
        {
            Player.SoundLocation = Environment.CurrentDirectory + @"\Scream.wav";
            Player.Load();
            Player.PlaySync();
        }
    }
}
