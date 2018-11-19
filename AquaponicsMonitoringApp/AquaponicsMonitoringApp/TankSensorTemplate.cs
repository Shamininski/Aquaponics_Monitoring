using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AquaponicsMonitoringApp.ApplicationLayer;

namespace AquaponicsMonitoringApp
{
    public partial class frmTankSensorTemplate : Form
    {
        public frmTankSensorTemplate(List<Sensor> sensors)
        {
            InitializeComponent();

            foreach (Sensor item in sensors)
            {
                lblTankName.Text = item.Location.ToUpper() + " - Live Graphs";
                if (item.Type == "Temperature")
                {
                    
                    chartTemperature.Series.Add(item.Location.ToUpper());
                    chartTemperature.Series[item.Location.ToUpper()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    chartTemperature.Series[item.Location.ToUpper()].Color = Color.Red;


                    List<SensorReading> allReadings = new List<SensorReading>();
                    SensorReading reading = new SensorReading();
                    allReadings = reading.getDayReadings(item);

                    int currentfrequency = 0;

                    FrequencySettings frequencySettings = new FrequencySettings();
                    currentfrequency = frequencySettings.getFrequency() * 60;

                    List<SensorReading> readingInTimeInterval = new List<SensorReading>();

                    foreach (SensorReading read in allReadings)
                    {
                        int time = read.Date.Minute;
                        if (time % (currentfrequency / 60) == 0)
                        {
                            readingInTimeInterval.Add(read);
                        }
                    }

                    foreach (SensorReading readInterval in readingInTimeInterval)
                    {
                        chartTemperature.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(readInterval.ReadingVal);
                        chartTemperature.Series[item.Location.ToUpper()].Points.AddY(Convert.ToDouble(readInterval.ReadingVal));
                    }

                }

                if (item.Type == "pH")
                {
                    chartPH.Series.Add(item.Location.ToUpper());
                    chartPH.Series[item.Location.ToUpper()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    chartPH.Series[item.Location.ToUpper()].Color = Color.DarkBlue;

                    List<SensorReading> allReadings = new List<SensorReading>();
                    SensorReading reading = new SensorReading();
                    allReadings = reading.getDayReadings(item);

                    int currentfrequency = 0;

                    FrequencySettings frequencySettings = new FrequencySettings();
                    currentfrequency = frequencySettings.getFrequency() * 60;

                    List<SensorReading> readingInTimeInterval = new List<SensorReading>();

                    foreach (SensorReading read in allReadings)
                    {
                        int time = read.Date.Minute;
                        if (time % (currentfrequency / 60) == 0)
                        {
                            readingInTimeInterval.Add(read);
                        }
                    }

                    foreach (SensorReading readInterval in readingInTimeInterval)
                    {
                        chartPH.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(readInterval.ReadingVal);
                        chartPH.Series[item.Location.ToUpper()].Points.AddY(Convert.ToDouble(readInterval.ReadingVal));
                    }
                }
            }
            

        }

        private void btnDownloadTempSensorSheet_MouseHover(object sender, EventArgs e)
        {
            btnDownloadTempSensorSheet.ForeColor = Color.GreenYellow;
        }

        private void btnDownloadTempSensorSheet_MouseLeave(object sender, EventArgs e)
        {
            btnDownloadTempSensorSheet.ForeColor = Color.DarkSlateGray;
        }

        private void btnDownloadpHSensorSheet_MouseHover(object sender, EventArgs e)
        {
            btnDownloadpHSensorSheet.ForeColor = Color.GreenYellow;
        }

        private void btnDownloadpHSensorSheet_MouseLeave(object sender, EventArgs e)
        {
            btnDownloadpHSensorSheet.ForeColor = Color.DarkSlateGray;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmMainDashboard MainDash = new frmMainDashboard();
            MainDash.Show();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmFormSeparator Separator = new frmFormSeparator();
            Separator.Show();
            frmLogin Login = new frmLogin();
            Login.Show();
            btnDashboard.BackColor = Color.Transparent;
            btnSettings.BackColor = Color.FromArgb(58, 131, 79);
        }

        private void frmTankSensorTemplate_Load(object sender, EventArgs e)
        {
        }
    }
}
