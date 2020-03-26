using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0326
{
    public partial class Form1 : Form
    {
        int hours = 0, minutes = 0, seconds = 0, numCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStopwatchStart.Text == "Start")
            {
                timer1.Enabled = true;
                buttonStopwatchStart.Text = "Pause";
                //buttonClear.Location = buttonStart.Location;
                //buttonStart.Location = pointStart;
                buttonStopwatchClear.Visible = true;
                buttonStopwatchStart.Visible = false;
            }
            else if (buttonStopwatchStart.Text == "Pause")
            {
                timer1.Enabled = false;
                buttonStopwatchStart.Text = "Continue";
                buttonStopwatchStart.BackColor = Color.Blue;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            hours = minutes = seconds = 0;
            buttonDisplay.Text = "00:00:00";
            numCount = 0;
        }

        private void buttonStopwatch_Click(object sender, EventArgs e)
        {


        }

        private void buttonCountdown_Click(object sender, EventArgs e)
        {
            button0.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            buttonDisplay.Visible = true;
            buttonSet.Visible = true;
            buttonClear2.Visible = true;
        }

        private void buttonCountdownStart_Click(object sender, EventArgs e)
        {
            int h = hours, m = minutes, s = seconds;

            if (--seconds < 0)
            {
                seconds = 0;
                if (++minutes >= 60)
                {
                    minutes = 0;
                    ++hours;
                }
            }

            String secondStr = (seconds).ToString(),
                minuteStr = (minutes).ToString(),
                hourStr = (hours).ToString();

            if (secondStr.Length == 1)
                secondStr = "0" + secondStr;
            if (minuteStr.Length == 1)
                minuteStr = "0" + minuteStr;
            if (hourStr.Length == 1)
                hourStr = "0" + hourStr;

            buttonDisplay.Text = hourStr + ":" + minuteStr + ":" + secondStr;
        }

        private void buttonCountdownClear_Click(object sender, EventArgs e)
        {
            int h = hours, m = minutes, s = seconds;

            String secondStr = (seconds).ToString(),
                minuteStr = (minutes).ToString(),
                hourStr = (hours).ToString();

            if (secondStr.Length == 1)
                secondStr = "0" + secondStr;
            if (minuteStr.Length == 1)
                minuteStr = "0" + minuteStr;
            if (hourStr.Length == 1)
                hourStr = "0" + hourStr;

            buttonDisplay.Text = hourStr + ":" + minuteStr + ":" + secondStr;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (++seconds >= 60)
            {
                seconds = 0;
                if (++minutes >= 60)
                {
                    minutes = 0;
                    ++hours;
                }
            }

            String secondStr = (seconds).ToString(),
                minuteStr = (minutes).ToString(),
                hourStr = (hours).ToString();

            if (secondStr.Length == 1)
                secondStr = "0" + secondStr;
            if (minuteStr.Length == 1)
                minuteStr = "0" + minuteStr;
            if (hourStr.Length == 1)
                hourStr = "0" + hourStr;

            buttonDisplay.Text = hourStr + ":" + minuteStr + ":" + secondStr;
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (++numCount <= 6)
            {
                string[] expression = buttonDisplay.Text.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string str = "";
                foreach (string s in expression)
                {
                    str += s;
                }
                str = str.Substring(1, 5) + button.Text;

                buttonDisplay.Text = "";
                for (int i = 0; i < str.Length; i++)
                {
                    buttonDisplay.Text += str[i];
                    if (i == 1) buttonDisplay.Text += ":";
                    if (i == 3) buttonDisplay.Text += ":";
                }
            }
        }
        private void buttonSet_Click(object sender, EventArgs e)
        {
            string[] expression = buttonDisplay.Text.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

            hours = Convert.ToInt32(expression[0]);
            minutes = Convert.ToInt32(expression[1]);
            seconds = Convert.ToInt32(expression[2]);

            if (seconds >= 60)
            {
                seconds %= 60;
                if (++minutes >= 60)
                {
                    minutes %= 60;
                    ++hours;
                }
            }

            String secondStr = (seconds).ToString(),
                minuteStr = (minutes).ToString(),
                hourStr = (hours).ToString();

            if (secondStr.Length == 1)
                secondStr = "0" + secondStr;
            if (minuteStr.Length == 1)
                minuteStr = "0" + minuteStr;
            if (hourStr.Length == 1)
                hourStr = "0" + hourStr;

            buttonDisplay.Text = hourStr + ":" + minuteStr + ":" + secondStr;

            button0.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            buttonSet.Visible = false;
            buttonClear2.Visible = false;
            buttonCountdownStart.Visible = true;
            buttonCountdownClear.Visible = true;
        }
    }
}
