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
    public partial class CurrentScreen : UserControl
    {
        int weatherIcon = Convert.ToInt32(Form1.days[0].icon);
        

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp;
            minMaxFeelLabel.Text = $"{Form1.days[0].tempLow}/{Form1.days[0].tempHigh} feels like {Form1.days[0].feels}";
            dateLabel.Text = Form1.days[0].date;
            if (weatherIcon > 300 && weatherIcon < 321)
            {
                conditionImageBox.Image = Properties.Resources.wpjs;
            }
            if (weatherIcon > 232 && weatherIcon < 200)
            {
                conditionImageBox.Image = Properties.Resources.cringe;
            }
            if (weatherIcon > 500 && weatherIcon < 521)
            {
                conditionImageBox.Image = Properties.Resources.rain;
            }
            if (weatherIcon > 600 && weatherIcon < 622)
            {
                conditionImageBox.Image = Properties.Resources.snow;
            }
            if (weatherIcon > 701 && weatherIcon < 781)
            {
                conditionImageBox.Image = Properties.Resources.bad;
            }
            if(weatherIcon == 800)
            {
                conditionImageBox.Image = Properties.Resources.clear;
            }
            if (weatherIcon > 801 && weatherIcon < 804)
            {
                conditionImageBox.Image = Properties.Resources.cloudy;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }

        private void tempLabel_Click(object sender, EventArgs e)
        {

        }

        private void cityOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
