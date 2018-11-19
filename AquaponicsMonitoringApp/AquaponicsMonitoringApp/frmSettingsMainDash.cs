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
    /// <summary>
    /// Form Creator: Eldané
    /// </summary>
    public partial class frmSettingsMainDash : Form
    {
        public frmSettingsMainDash()
        {
            InitializeComponent();
            pnlMainDashLayout.BackColor = Color.FromArgb(40, 91, 55);
            btnAddSensor.BackColor = Color.FromArgb(58, 131, 79);
            cmbSensorType.SelectedIndex = 0;

            Sensor sensor = new Sensor();
            List<string> allLocations = sensor.getAllTanks();
            cmbExistingTanks.Items.Add("SELECT A TANK:"); // Populate cmbExistingTanks with all registered Tanks
            foreach (string tank in allLocations)
            {
                cmbExistingTanks.Items.Add(tank);
            }

            User user = new User();
            string loggedUser = user.getCurrentLoggedUser();
            string[] fields = loggedUser.Split(';');
            string username = fields[0];

            btnLogout.Text = "   Log Out: " + username;
            
        }

        private void cbxExistingTank_CheckedChanged(object sender, EventArgs e)
        {
            pnlExistingTank.Visible = true;
            cmbExistingTanks.SelectedIndex = 0;
            cbxExistingTank.Checked = false;
        }

        private void cbxChooseNewTank_CheckedChanged(object sender, EventArgs e)
        {
            pnlExistingTank.Visible = false;
            txtTankName.Clear();
            cbxChooseNewTank.Checked = false;
        }

        private void cmbSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSensorType.SelectedItem.ToString() == "Temperature")
            {
                pnlPhCriticalRange.Visible = false;
                pnlMessage.Visible = false;
            }
            if (cmbSensorType.SelectedItem.ToString() == "pH")
            {
                pnlPhCriticalRange.Visible = true;
                pnlMessage.Visible = false;
            }
        }

        private void btnAddSensor_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSensor_Click(object sender, EventArgs e)
        {
            frmFormSeparator Seperator = new frmFormSeparator();
            Seperator.Show();
            frmEditSensor EditSensor = new frmEditSensor();
            EditSensor.Show();
            btnAddSensor.BackColor = Color.Transparent;
            btnEditSensor.BackColor = Color.FromArgb(58, 131, 79);
        }

        private void btnNotificationSettings_Click(object sender, EventArgs e)
        {
            frmNotificationSettings NotificationSettings = new frmNotificationSettings();
            NotificationSettings.Show();
            this.Close();
        }

        private void btnAddSensorInfo_Click(object sender, EventArgs e)
        {
            string sensorName = txtSensorName.Text;
            string sensorType = "";
            string sensorLocation = ""; // Tank name
            decimal maxTempValue = nudMaxTemp.Value;
            decimal minTempValue = nudMinTemp.Value;
            decimal maxpHValue = nudMaxPH.Value;
            decimal minpHValue = nudMinPH.Value;
            bool sensorLocationChecked = false;
            bool sensorTypeChecked = false;
            bool criticalValuesChecked = false;


            if (cmbSensorType.SelectedIndex != 0)
            {
                sensorType = cmbSensorType.SelectedItem.ToString();
                sensorTypeChecked = true;
            }
            else
            {
                MessageBox.Show("No Sensor Type was chosen", "Incorrect Sensor Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblChooseSensorType.ForeColor = Color.Red;
            }

            if (pnlExistingTank.Visible == false)
            {
                if ((txtTankName.Text != "") && (txtTankName.Text.Length <= 14))
                {
                    sensorLocation = txtTankName.Text;
                    sensorLocationChecked = true;
                }
                else
                {
                    MessageBox.Show("The Sensor Location (Tank Name) is limited to 14 characters! Please provide a name that is less than 14 characters", "Tank Name is too long", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblTankName.ForeColor = Color.Red;
                }
            }

            if (pnlExistingTank.Visible == true)
            {
                if ((cmbExistingTanks.SelectedIndex != 0))
                {
                    sensorLocation = cmbExistingTanks.SelectedItem.ToString();
                    sensorLocationChecked = true;
                }
                else
                {
                    MessageBox.Show("The Sensor Location (Tank Name) has not been selected", "Incorrect Tank Name Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblChooseExistingTank.ForeColor = Color.Red;
                }
            }
            
            if (sensorType == "Temperature")
            {
                string message = "The critical range for the Temperature Sensor is from " + minTempValue + "°C to " + maxTempValue + "°C. Is this range correct?";
                if (MessageBox.Show(message, "Confirm Critical Range", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    criticalValuesChecked = true;
                }
                else
                {
                    MessageBox.Show("Choose a new critical Range", "Change Critical Range", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nudMaxTemp.Value = 40;
                    nudMinTemp.Value = 10;
                    gbxCriticalRange.ForeColor = Color.Red;
                }
            }

            if (sensorType == "pH")
            {
                string message = "The critical range for the pH Sensor is from " + minpHValue + " to " + maxpHValue + ". Is this range correct?";
                if (MessageBox.Show(message, "Confirm Critical Range", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    criticalValuesChecked = true;
                }
                else
                {
                    MessageBox.Show("Choose a new critical Range", "Change Critical Range", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nudMaxPH.Value = 14;
                    nudMinPH.Value = 0;
                    gbxCriticalRange.ForeColor = Color.Red;
                }
            }

            if ((sensorTypeChecked == true)&&(sensorLocationChecked == true)&&(criticalValuesChecked == true))
            {
                int sensorID;
                decimal bottomValue = 0;
                decimal topValue = 0;
                Sensor sensor = new Sensor(sensorName,sensorLocation,sensorType,0);
                sensor.newSensor();

                List<Sensor> allSensors = new List<Sensor>();
                allSensors = sensor.getAllSensors();

                sensorID = allSensors[allSensors.Count-1].SensorID;

                if (sensorType == "Temperature")
                {
                    bottomValue =  minTempValue;
                    topValue = maxTempValue;
                }

                if (sensorType == "pH")
                {
                    bottomValue = minpHValue;
                    topValue = maxpHValue;
                }

                Notifications notify = new Notifications(sensorID, bottomValue, topValue);
                notify.insertNotification();

                MessageBox.Show("The Sensor was successfully registered!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmSettingsMainDash addSensor = new frmSettingsMainDash();
                addSensor.Show();
                this.Close();

                lblChooseSensorType.ForeColor = Color.Red;
                gbxSensorLocation.ForeColor = Color.White;
                gbxCriticalRange.ForeColor = Color.White;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit Settings?","Log Out",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            frmFormSeparator Seperator = new frmFormSeparator();
            Seperator.Show();
            frmEditUser EditUser = new frmEditUser();
            EditUser.Show();
            btnAddSensor.BackColor = Color.Transparent;
            btnUserSettings.BackColor = Color.FromArgb(58, 131, 79);
        }
    }
}
