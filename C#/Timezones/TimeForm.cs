using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timezones
{
    public partial class TimeForm : Form
    {
        private Timer timer;
        private int seconds;
        private int minutes;
        private int hours;
        private string ampm;
        private DateTime dateTime;
        private string zeroSec;
        private string zeroMin;
        private string zeroHours;
        private TimeZoneInfo timeZone;
        public TimeForm(string regionName, string username)
        {
            InitializeComponent();
            GetTime(regionName);
            lblUsername.Text = $"{username}'s time information";
            SetTimeTextLabel();
            InitializeTimer();
        }

        private void GetTime(string regionName)
        {
            try
            {
                timeZone = TimeZoneInfo.FindSystemTimeZoneById($"{regionName}");
                dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZone);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetTimeTextLabel()
        {
            seconds = dateTime.Second;
            minutes = dateTime.Minute;
            hours = dateTime.Hour;

            lblTime.Location = new Point(pbClock.Left + pbClock.Width / 2, pbClock.Top + pbClock.Height / 2);

            SetZeroSecMin();
            ampm = dateTime.ToString("tt");
            lblTime.Text = $"{zeroHours}{hours}:{zeroMin}{minutes}:{zeroSec}{seconds} {ampm}";
            lblDate.Text = dateTime.Date.ToString("d");
            lblDay.Text = dateTime.DayOfWeek.ToString();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) =>
            {
                SetZeroSecMin();

                if (seconds == 60)
                {
                    ++minutes;
                    zeroSec = "0";
                    seconds = 0;
                }

                if (minutes == 60)
                {
                    minutes = 0;
                    zeroMin = "0";
                    if (ampm == "PM" && hours + 1 == 24)
                    {
                        hours = 0;
                        ampm = "AM";
                    }

                    else if (ampm == "AM" && hours + 1 == 13)
                    {
                        hours = 13;
                        ampm = "PM";
                    }

                    else
                        ++hours;
                }

                lblTime.Text = $"{zeroHours}{hours}:{zeroMin}{minutes}:{zeroSec}{seconds++} {ampm}";
            };

            timer.Start();
        }

        private void SetZeroSecMin()
        {
            if (seconds < 10) zeroSec = "0";
            else zeroSec = string.Empty;

            if (minutes < 10) zeroMin = "0";
            else zeroMin = string.Empty;

            if (hours == 0)
            {
                zeroHours = "0";
                ampm = "AM";
            }

            else zeroHours = string.Empty;
        }

        private void icobtnLeave_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
