using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Blocker
{
    public partial class FRM_main : Form
    {
        private int timeElapsed;
        private bool working;
        public FRM_main()
        {
            InitializeComponent();
        }

        private void BUT_startstop_Click(object sender, EventArgs e)
        {
            TIM_timer.Enabled = !TIM_timer.Enabled;     
            if (TIM_timer.Enabled) { BUT_startstop.Text = "STOP"; }
            else { BUT_startstop.Text = "START"; }
        }

        private void FRM_main_Load(object sender, EventArgs e)
        {
            working = true;
            timeElapsed = 0;
        }

        private void TIM_timer_Tick(object sender, EventArgs e)
        {
            timeElapsed += 1;
            if (working && timeElapsed >= NUD_workTime.Value)
            {
                working = false;
                timeElapsed = 0;
                LBL_elapsed.BackColor = Color.Red;
                System.Media.SystemSounds.Exclamation.Play();
            }
            else if (!working && timeElapsed >= NUD_restTime.Value)
            {
                working = true;
                timeElapsed = 0;
                LBL_elapsed.BackColor = Color.Green;
                System.Media.SystemSounds.Exclamation.Play();
            }
            UpdateClock();
        }

        private void UpdateClock()
        {
            int minutes, seconds;
            minutes = Convert.ToInt32(Math.Floor(timeElapsed / 60.0));
            seconds = timeElapsed - minutes * 60;
            LBL_elapsed.Text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
        }

        private void NUD_workTime_ValueChanged(object sender, EventArgs e)
        {
            NUD_restTime.Value = 60 - NUD_workTime.Value;
        }

        private void NUD_restTime_ValueChanged(object sender, EventArgs e)
        {
            NUD_workTime.Value = 60 - NUD_restTime.Value;
        }
    }
}
