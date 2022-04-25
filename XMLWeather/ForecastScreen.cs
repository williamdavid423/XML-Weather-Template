using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            monLabel.Text = Form1.days[0].date;
            monMin.Text = Form1.days[0].tempLow;
            monMax.Text = Form1.days[0].tempHigh;

            tuesLabel.Text = Form1.days[1].date;
            tuesMin.Text = Form1.days[1].tempLow;
            tuesMax.Text = Form1.days[1].tempHigh;

            wedDate.Text = Form1.days[2].date;
            WedMin.Text = Form1.days[2].tempLow;
            WedMax.Text = Form1.days[2].tempHigh;

            thurDate.Text = Form1.days[3].date;
            thurMin.Text = Form1.days[3].tempLow;
            thurMax.Text = Form1.days[3].tempHigh;

            friDate.Text = Form1.days[4].date;
            friMin.Text = Form1.days[4].tempLow;
            friMax.Text = Form1.days[4].tempHigh;

            satDate.Text = Form1.days[5].date;
            satMin.Text = Form1.days[5].tempLow;
            satMax.Text = Form1.days[5].tempHigh;

            sunDate.Text = Form1.days[6].date;
            sunMin.Text = Form1.days[6].tempLow;
            sunMax.Text = Form1.days[6].tempHigh;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
