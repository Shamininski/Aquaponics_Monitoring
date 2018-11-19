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
    /// This form is used to update the critical ranges of each sensor or to delete an 
    /// existing sensor.
    /// </summary>
    public partial class frmEditSensor : Form
    {
        public frmEditSensor()
        {
            InitializeComponent();
            Sensor sensor = new Sensor();
            List<string> allTanks = sensor.getAllTanks();

            // Populate combobox
            cmbTanks.Items.Add("SELECT A TANK:");
            foreach (string tank in allTanks)
            {
                cmbTanks.Items.Add(tank);
            }

        }

        private void btnCloseEditSensor_Click(object sender, EventArgs e)
        {
            // This loop closes all open forms excluding the Main form.
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "frmFormSeparator")
                {
                    Application.OpenForms[i].Close();
                }
                if (Application.OpenForms[i].Name == "frmSettingsMainDash")
                {
                    Application.OpenForms[i].Close();
                }
            }

            frmSettingsMainDash Settings = new frmSettingsMainDash();
            Settings.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlDeleteSensor.Visible = false;
            pnlUpdateSensor.Visible = true;

            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.Enabled = false;

            btnDelete.FlatStyle = FlatStyle.Standard;
            btnDelete.BackColor = Color.DarkGreen;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlUpdateSensor.Visible = false;
            pnlDeleteSensor.Visible = true;

            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Enabled = false;

            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnUpdate.BackColor = Color.DarkGreen;
            btnUpdate.Enabled = true;

            cmbSensorsToDelete.Visible = true;
        }

        private void cmbTanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.DarkGreen;
            btnDelete.BackColor = Color.DarkGreen;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            Sensor sensor = new Sensor();
            List<Sensor> allSensors = new List<Sensor>();
            allSensors = sensor.getAllSensors();

            cmbSensorsToUpdate.Items.Clear();
            cmbSensorsToDelete.Items.Clear();
            cmbSensorsToUpdate.Items.Add("SELECT A SENSOR:");
            cmbSensorsToDelete.Items.Add("SELECT A SENSOR:");

            // Populate both combo boxes
            foreach (Sensor item in allSensors)
            {
                if (item.Location == cmbTanks.SelectedItem.ToString())
                {
                    cmbSensorsToUpdate.Items.Add(item.SensorName);
                    cmbSensorsToDelete.Items.Add(item.SensorName);
                }
            }

            cmbSensorsToUpdate.SelectedIndex = 0; // Set a default for combo boxes
            cmbSensorsToDelete.SelectedIndex = 0;
        }

        int sensorID = 0;
        decimal oldMaxValue = 0;
        decimal oldMinValue = 0;
        string sensorType = "";
        private void cmbSensorsToUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Notifications notify = new Notifications();
            List<Notifications> allCriticalRanges = new List<Notifications>();
            allCriticalRanges = notify.getAllCriticalRanges();

            Sensor sensor = new Sensor();
            List<Sensor> allSensors = new List<Sensor>();
            allSensors = sensor.getAllSensors();

            foreach (Sensor item in allSensors)
            {
                if ((item.SensorName == cmbSensorsToUpdate.SelectedItem.ToString())&&(item.Location == cmbTanks.SelectedItem.ToString()))
                {
                    sensorID = item.SensorID;
                    sensorType = item.Type;
                }
            }

            foreach (Notifications item in allCriticalRanges)
            {
                if (item.SensorID == sensorID)
                {
                    oldMaxValue = item.TopValue;
                    oldMinValue = item.BottomValue;
                }
            }

            // Display the current values as deafault values in numeric spinners
            nudMaxValue.Value = (decimal)oldMaxValue;
            nudMinValue.Value = (decimal)oldMinValue;
        }
        

        private void btnUpdateSensor_Click_1(object sender, EventArgs e)
        {
            decimal newMaxValue = nudMaxValue.Value;
            decimal newMinValue = nudMinValue.Value;
            string message = "";

            if (sensorType == "Temperature")
            {
                message = "The critical range for the Temperature Sensor is from " + newMinValue + "°C to " + newMaxValue + "°C. Is this range correct?";
            }
            if (sensorType == "pH")
            {
                message = "The critical range for the Temperature Sensor is from " + newMinValue + " to " + newMaxValue + ". Is this range correct?";
            }

            if (MessageBox.Show(message, "Confirm Critical Range", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Notifications notifications = new Notifications(sensorID, newMinValue, newMaxValue, 0);
                notifications.updateNotifications();

                MessageBox.Show("Critical Range has been updated successfullly", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMaxValue.ForeColor = Color.White;
                lblMinValue.ForeColor = Color.White;
                cmbSensorsToUpdate.SelectedIndex = 0;
                nudMinValue.Value = 0;
                nudMaxValue.Value = 0;
            }
            else
            {
                MessageBox.Show("Choose a new critical Range", "Change Critical Range", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nudMaxValue.Value = oldMaxValue;
                nudMinValue.Value = oldMinValue;
                lblMaxValue.ForeColor = Color.Red;
                lblMinValue.ForeColor = Color.Red;
            }

        }

        int sensorIDToDelete = 0;
        string sensorName = "";
        private void cmbSensorsToDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sensor sensor = new Sensor();
            List<Sensor> allSensors = new List<Sensor>();
            allSensors = sensor.getAllSensors();

            foreach (Sensor item in allSensors)
            {
                if ((item.SensorName == cmbSensorsToDelete.SelectedItem.ToString()) && (item.Location == cmbTanks.SelectedItem.ToString()))
                {
                    sensorIDToDelete = item.SensorID;
                    sensorName = item.SensorName;
                }
            }

            cmbSensorsToDelete.Visible = false;
            txtDeleteEmail.Text = sensorName;
        }

        private void btnDeleteSensor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this sensor?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sensor deleteSensor = new Sensor("", "", "", sensorIDToDelete);
                deleteSensor.deleteSensor();

                MessageBox.Show("Sensor Successfully Deleted!", "Successful Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbSensorsToDelete.SelectedIndex = 0;
                txtDeleteEmail.Clear();
            }
            else
            {
                cmbSensorsToDelete.SelectedIndex = 0;
                txtDeleteEmail.Clear();
            }
        }
    }
}
