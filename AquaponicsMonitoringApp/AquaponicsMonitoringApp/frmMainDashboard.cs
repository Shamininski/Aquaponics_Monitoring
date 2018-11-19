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
    public partial class frmMainDashboard : Form
    {
        public frmMainDashboard()
        {
            InitializeComponent();

            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();
            SensorReading reading = new SensorReading();
            Dictionary<string, string> allData = reading.currentReadingPerSensor(allSensors);
            int counter = 0;

            foreach(KeyValuePair<string,string> kvp in allData)
            {
                string panelName = "pnlDashAction" + Convert.ToString(counter + 1);
                foreach (Control item in tableLayoutPanel1.Controls)
                {
                    if (item.Name == panelName)
                    {
                        item.Visible = true;

                        string headerName = "pnlDashAction" + Convert.ToString(counter + 1) + "Header";
                        foreach (Control panelItem in item.Controls)
                        {
                            if (panelItem.Name == headerName)
                            {
                                string lableName = "lblDashAction" + Convert.ToString(counter + 1);
                                foreach (Control lableItem in panelItem.Controls)
                                {
                                    if (lableItem.Name == lableName)
                                    {
                                        string tank = kvp.Key;
                                        lableItem.Text = tank;
                                    }
                                }
                            }

                            string tempLable = "lblTempA" + Convert.ToString(counter + 1);
                            string pHLable = "lblPhA" + Convert.ToString(counter + 1);
                            string tankReading = kvp.Value;
                            string[] field = tankReading.Split('#');

                            if (panelItem.Name == tempLable)
                            {
                                string tempReading = field[0] +"°C";
                                panelItem.Text = tempReading;
                            }
                            else if (panelItem.Name == pHLable)
                            {
                                string pHReading = field[1];
                                panelItem.Text = pHReading;
                            }
                        }
                    }
                }
            }

        }

        System.Threading.Thread t;
        private void frmMainDashboard_Load(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(58, 131, 79);

            FrequencySettings frequency = new FrequencySettings();
            nudTimeInterval.Value = frequency.getFrequency();
            btnSaveTimeInterval.Visible = false;

            t = new System.Threading.Thread(DoThisAllTheTime);
            t.Start();

            timer.Start();

        }


        private void pnlMainDashLayout_Paint(object sender, PaintEventArgs e)
        {
            pnlMainDashLayout.BackColor = Color.FromArgb(40, 91, 55);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            t.Abort();
            timer.Stop();
            Application.Exit();
        }

        private void pnlDashAction1_Paint(object sender, PaintEventArgs e)
        {
            pnlDashAction1.BackColor = Color.FromArgb(40, 91, 55);
            pnlDashAction1Header.BackColor = Color.FromArgb(0, 51, 40);
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

        private void btnMoreDashAction1_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();

        }

        private void btnMoreDashAction2_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction3_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction4_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction5_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction6_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction7_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction8_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction9_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction10_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction15_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction14_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction13_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction12_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction11_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction16_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction17_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction18_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction19_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction20_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction25_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction24_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction23_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction22_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnMoreDashAction21_Click(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();

            List<Sensor> allSensorsForTank = new List<Sensor>();

            foreach (Sensor item in allSensors)
            {
                if (item.Location.ToUpper() == lblDashAction1.Text)
                {
                    allSensorsForTank.Add(item);
                }
            }

            frmTankSensorTemplate tankSensor = new frmTankSensorTemplate(allSensorsForTank);
            tankSensor.Show();
            this.Hide();
        }

        private void btnLiveGraph_Click(object sender, EventArgs e)
        {
            frmLiveGraph LiveGraph = new frmLiveGraph();
            LiveGraph.Show();
            this.Hide();
        }

        private void nudTimeInterval_ValueChanged(object sender, EventArgs e)
        {
            btnSaveTimeInterval.Visible = true;
        }

        private void btnSaveTimeInterval_Click(object sender, EventArgs e)
        {
            int timeInterval = Convert.ToInt32(nudTimeInterval.Value);
            string message = "Are you sure you want to change the time interval to " + timeInterval + " minutes ?";
            if (MessageBox.Show(message, "Change Time Interval", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrequencySettings frequencySettings = new FrequencySettings(DateTime.Now,timeInterval);
                frequencySettings.newFrequency();

                string successMessage = "The time interval has been successfully changed. You will now receive new data for all sensors in " + timeInterval + " minute intervals.";
                MessageBox.Show(successMessage, "Successful Update of Time Interval", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        List<string> componentNames = new List<string>();
        public void DoThisAllTheTime()
        {
            int currentfrequency = 0;
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = sensor.getAllSensors();
            FrequencySettings frequencySettings = new FrequencySettings();
            currentfrequency = frequencySettings.getFrequency() * 60;

            while (true)
            {
                //you need to use Invoke because the new thread can't access the UI elements directly
                MethodInvoker mi = delegate () { this.Text = DateTime.Now.ToString(); };
                this.Invoke(mi);

                if (second%60 == 0) // write sensor readings in database from textfile each minute
                {
                    foreach (Sensor item in allSensors)
                    {
                        SensorReading reading = new SensorReading();
                        reading.newSensorReading(item);
                    }
                }

                if (second % currentfrequency == 0)
                {
                    foreach (Sensor item in allSensors)
                    {
                        List<SensorReading> allReadings = new List<SensorReading>(); // retrieve a list of sensor readings in 24 hour period

                        SensorReading reading = new SensorReading();
                        allReadings = reading.getDayReadings(item);

                        List<SensorReading> readingInTimeInterval = new List<SensorReading>();
                        Notifications notify = new Notifications();
                        decimal topValue = notify.getTopvalue(item.SensorID);
                        decimal bottomValue = notify.getBottomValue(item.SensorID);

                        foreach (SensorReading read in allReadings)
                        {
                            int time = read.Date.Minute;
                            if (time % (currentfrequency/60) == 0)
                            {
                                readingInTimeInterval.Add(read);
                            }
                        }

                        foreach (SensorReading readInInterval in readingInTimeInterval)
                        {
                            if (readInInterval.ReadingVal < bottomValue)
                            {
                                Contact contact = new Contact();
                                List<string> allEmails = contact.getEmailsToReceiveNotification(item.SensorID); // get list of emails for this sensor

                                foreach (string mail in allEmails) 
                                {
                                    notify.mailNotifcation(mail, item.Location,item.SensorName,"Bottom",(bottomValue - readInInterval.ReadingVal));
                                }
                            }

                            if (readInInterval.ReadingVal > topValue)
                            {
                                Contact contact = new Contact();
                                List<string> allEmails = contact.getEmailsToReceiveNotification(item.SensorID); // get list of emails for this sensor

                                foreach (string mail in allEmails)
                                {
                                    notify.mailNotifcation(mail, item.Location, item.SensorName, "Top", (readInInterval.ReadingVal - topValue));
                                }
                            }
                        }
                    }

                    
                }

            }
        }

        int second = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            second++;
        }
    }

}
