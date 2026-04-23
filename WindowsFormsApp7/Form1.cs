using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;

			CalculateTimeDifference();
		}

        private void Timer1_Tick(object sender, EventArgs e)
        {
			CalculateTimeDifference();
			

		}

		private void CalculateTimeDifference()
		{
			DateTime selected = dateTimePicker1.Value.Date + dateTimePicker2.Value.TimeOfDay;

			TimeSpan diff = DateTime.Now - selected;



			if (diff.TotalSeconds < 0) {
				label1.Text = (-1 * diff.Seconds).ToString();
				label7.Text = (-1 * diff.Minutes).ToString();
				label6.Text = (-1 * diff.Hours).ToString();
				label5.Text = (-1 * diff.Days).ToString();

			}
			else {
				label1.Text = diff.Seconds.ToString();
				label7.Text = diff.Minutes.ToString();
				label6.Text = diff.Hours.ToString();
				label5.Text = diff.Days.ToString();
			}

		}
	}
}
