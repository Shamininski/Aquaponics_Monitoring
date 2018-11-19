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
    public partial class frmNotificationSettings : Form
    {
        public frmNotificationSettings()
        {
            InitializeComponent();
            pnlMainDashLayout.BackColor = Color.FromArgb(40, 91, 55);
            btnNotificationSettings.BackColor = Color.FromArgb(58, 131, 79);

            Sensor sensor = new Sensor();
            List<string> allTanks = sensor.getAllTanks();

            cmbTanks.Items.Add("SELECT A TANK:");
            foreach (string tank in allTanks)
            {
                cmbTanks.Items.Add(tank);
            }

            cmbTanks.SelectedIndex = 0;
            cmbSensors.Visible = false;
            cmbTanks.Enabled = true;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            frmSettingsMainDash MainSettings = new frmSettingsMainDash();
            MainSettings.Show();
            this.Close();
        }

        private void btnNotificationSettings_Click(object sender, EventArgs e)
        {
            frmNotificationSettings NotificationSettings = new frmNotificationSettings();
            NotificationSettings.Show();
            this.Close();
        }

        private void cbxEnterNewEmail_CheckedChanged(object sender, EventArgs e)
        {
            pnlAddNewEmail.Visible = true;
            pnlAddExistingEmail.Visible = false;
            cbxEnterNewEmail.Checked = false;
            lblChooseEmail.ForeColor = Color.White;
            cmbExistingEmails.SelectedIndex = 0;
        }

        private void cbxChooseExistingEmail_CheckedChanged(object sender, EventArgs e)
        {
            pnlAddNewEmail.Visible = false;
            pnlAddExistingEmail.Visible = true;
            cbxChooseExistingEmail.Checked = false;
            lblEnterEmail.ForeColor = Color.White;
            lblReEnterEmail.ForeColor = Color.White;
            txtEmail.Clear();
            txtReEmail.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbExistingEmails.Items.Clear();

            pnlDeleteEmail.Visible = false;
            pnlUpdateEmail.Visible = false;
            pnlAddNewEmail.Visible = true;
            btnAddEmail.Visible = true;

            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Enabled = false;

            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnUpdate.BackColor = Color.DarkGreen;
            btnUpdate.Enabled = true;

            btnDelete.FlatStyle = FlatStyle.Standard;
            btnDelete.BackColor = Color.DarkGreen;
            btnDelete.Enabled = true;

            Contact contact = new Contact();
            List<Contact> allContacts = contact.getAllContacts();

            User user = new User();
            List<User> allUsers = user.getAllRegisteredUsers();

            cmbExistingEmails.Items.Add("SELECT A EMAIL:");
            foreach (Contact item in allContacts)
            {
                if (item.SensorID != sensorID)
                {
                    cmbExistingEmails.Items.Add(item.Email);
                }
            }

            List<string> allRegisteredEmails = user.getAllRegisteredEmails(); // all the emails that are currently registered
            List<string> allContactEmailsForSensor = new List<string>();

            foreach (Contact item in allContacts)
            {
                if (item.SensorID != sensorID)
                {
                    allContactEmailsForSensor.Add(item.Email);
                }
            }

            for (int i = 0; i < allRegisteredEmails.Count-1; i++)
            {
                  if (!allContactEmailsForSensor.Contains(allRegisteredEmails[i]))
                  {
                        cmbExistingEmails.Items.Add(allRegisteredEmails[i]);
                  }
            }
            cmbExistingEmails.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmbAllEmailsforSensor.Items.Clear();

            pnlDeleteEmail.Visible = false;
            pnlAddNewEmail.Visible = false;
            btnAddEmail.Visible = false;
            pnlUpdateEmail.Visible = true;

            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.Enabled = false;

            btnAdd.FlatStyle = FlatStyle.Standard;
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.Enabled = true;

            btnDelete.FlatStyle = FlatStyle.Standard;
            btnDelete.BackColor = Color.DarkGreen;
            btnDelete.Enabled = true;

            Contact contact = new Contact();
            List<Contact> allContactsForSensor = contact.getAllContacts();

            User user = new User();
            List<User> allUsers = user.getAllRegisteredUsers();

            cmbAllEmailsforSensor.Items.Add("SELECT A EMAIL:");
            foreach (Contact item in allContactsForSensor)
            {
                if (item.SensorID == sensorID)
                {
                    cmbAllEmailsforSensor.Items.Add(item.Email);
                }
            }

            cmbAllEmailsforSensor.SelectedIndex = 0; // Set default selection
            cmbAllEmailsforSensor.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmbEmailsToDelete.Items.Clear();
            
            pnlAddNewEmail.Visible = false;
            btnAddEmail.Visible = false;
            pnlUpdateEmail.Visible = false;
            pnlDeleteEmail.Visible = true;

            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Enabled = false;

            btnAdd.FlatStyle = FlatStyle.Standard;
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.Enabled = true;

            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnUpdate.BackColor = Color.DarkGreen;
            btnUpdate.Enabled = true;

            Contact contact = new Contact();
            List<Contact> allContactsForSensor = contact.getAllContacts();

            User user = new User();
            List<User> allUsers = user.getAllRegisteredUsers();

            cmbEmailsToDelete.Items.Add("SELECT A EMAIL:");
            foreach (Contact item in allContactsForSensor)
            {
                if (item.SensorID == sensorID)
                {
                    cmbEmailsToDelete.Items.Add(item.Email);
                }
            }

            cmbEmailsToDelete.SelectedIndex = 0; // Set default selection
            cmbEmailsToDelete.Enabled = true;
        }

        private void cmbTanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTanks.SelectedIndex != 0)
            {
                Sensor sensor = new Sensor();
                List<Sensor> allSensors = new List<Sensor>();
                allSensors = sensor.getAllSensors();
                cmbSensors.Items.Add("SELECT A SENSOR:");

            foreach (Sensor item in allSensors)
            {
                if (item.Location == cmbTanks.SelectedItem.ToString())
                {
                    cmbSensors.Items.Add(item.SensorName);
                }
            }
                cmbSensors.SelectedIndex = 0; // Set a default for combo boxes
                cmbTanks.Enabled = false;
                cmbSensors.Visible = true;
            }
            
        }

        int sensorID = 0;
        private void cmbSensors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSensors.SelectedIndex != 0)
            {
                int count = 1;
                Sensor sensor = new Sensor();
                List<Sensor> allSensors = new List<Sensor>();
                allSensors = sensor.getAllSensors();

                foreach (Sensor item in allSensors)
                {
                    if ((item.SensorName == cmbSensors.SelectedItem.ToString()) && (item.Location == cmbTanks.SelectedItem.ToString()))
                    {
                        sensorID = item.SensorID;
                    }
                }

                Contact contact = new Contact();
                List<Contact> allContacts = new List<Contact>();
                allContacts = contact.getAllContacts();

                foreach (Contact item in allContacts)
                {
                    if (item.SensorID == sensorID)
                    {
                        lbxAvailableEmails.Items.Add(count.ToString() + ". " + item.Email);
                        count++;
                    }
                }

                if (count == 1)
                {
                    lbxAvailableEmails.Items.Add("No Emails Listed");
                }
                cmbSensors.Enabled = false;
                pnlNotificationEmails.Visible = true;
            }
            
        }

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            string email = "";
            string confirmEmail = "";

            if (pnlAddExistingEmail.Visible == false)
            {
                if (txtEmail.Text.Contains('@'))
                {
                    email = txtEmail.Text;
                    confirmEmail = txtReEmail.Text;

                    if (email == confirmEmail)
                    {
                        Contact contact = new Contact(sensorID, email, 0);
                        contact.insertContact();

                        MessageBox.Show("Email was successfully registered!", "Successful Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblEnterEmail.ForeColor = Color.White;
                        lblReEnterEmail.ForeColor = Color.White;
                        txtEmail.Clear();
                        txtReEmail.Clear();

                        lbxAvailableEmails.Items.Clear();
                        int count = 1;
                        List<Contact> allContacts = new List<Contact>();
                        allContacts = contact.getAllContacts();

                        foreach (Contact item in allContacts)
                        {
                            if (item.SensorID == sensorID)
                            {
                                lbxAvailableEmails.Items.Add(count.ToString() + ". " + item.Email);
                                count++;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Emails doesn't match! Please try again", "Email Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblEnterEmail.ForeColor = Color.Red;
                        lblReEnterEmail.ForeColor = Color.Red;
                        txtEmail.Clear();
                        txtReEmail.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Email is invalid!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblEnterEmail.ForeColor = Color.Red;
                    lblReEnterEmail.ForeColor = Color.Red;
                    txtEmail.Clear();
                    txtReEmail.Clear();
                }
            }

            if (pnlAddExistingEmail.Visible == true)
            {
                if (cmbExistingEmails.SelectedIndex != 0)
                {
                    email = cmbExistingEmails.SelectedItem.ToString();
                    Contact contact = new Contact(sensorID, email, 0);
                    contact.insertContact();

                    MessageBox.Show("Email was successfully registered!", "Successful Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblChooseEmail.ForeColor = Color.White;
                    cmbExistingEmails.SelectedIndex = 0;

                    lbxAvailableEmails.Items.Clear();
                    int count = 1;
                    List<Contact> allContacts = new List<Contact>();
                    allContacts = contact.getAllContacts();

                    foreach (Contact item in allContacts)
                    {
                        if (item.SensorID == sensorID)
                        {
                            lbxAvailableEmails.Items.Add(count.ToString() + ". " + item.Email);
                            count++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Email was Selected!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblChooseEmail.ForeColor = Color.Red;
                }
            }
        }

        private void cmbAllEmailsforSensor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAllEmailsforSensor.SelectedIndex != 0)
            {
                User user = new User();
                List<string> allRegisteredEmails = user.getAllRegisteredEmails(); // all the emails that are currently registered

                if (allRegisteredEmails.Contains(cmbAllEmailsforSensor.SelectedItem.ToString()))
                {
                    MessageBox.Show("This email is registered to a user with previllages and therefore cannot be altered", "Not Permitted to Update Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbAllEmailsforSensor.SelectedIndex = 0;
                }
                else
                {
                    cmbAllEmailsforSensor.Enabled = false;
                }
            }
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            string priorEmail = cmbAllEmailsforSensor.SelectedItem.ToString();
            string newEmail = "";
            string message = "";

            if (txtUpdatedEmail.Text.Contains("@"))
            {
                newEmail = txtUpdatedEmail.Text;

                message = "You are about to replace " + priorEmail + " with " + newEmail + ". Is this correct?";
                if (MessageBox.Show(message, "Confirm Email Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contact contact = new Contact(sensorID, newEmail, 0);
                    contact.updateContact(priorEmail);

                    MessageBox.Show("Email was successfully updated!", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lbxAvailableEmails.Items.Clear();
                    int count = 1;
                    List<Contact> allContacts = new List<Contact>();
                    allContacts = contact.getAllContacts();

                    foreach (Contact item in allContacts)
                    {
                        if (item.SensorID == sensorID)
                        {
                            lbxAvailableEmails.Items.Add(count.ToString() + ". " + item.Email);
                            count++;
                        }
                    }

                    txtUpdatedEmail.Clear();
                    cmbAllEmailsforSensor.SelectedIndex = 0;
                    cmbAllEmailsforSensor.Enabled = true;
                }
                else
                {
                    lblEnterUpdatedEmail.ForeColor = Color.Red;
                    txtUpdatedEmail.Clear();
                }

            }
            else
            {
                MessageBox.Show("Updated email is invalid! Please try again","Invalid Email",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                lblEnterUpdatedEmail.ForeColor = Color.Red;
                txtUpdatedEmail.Clear();
            }
        }

        private void cmbEmailsToDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmailsToDelete.SelectedIndex != 0)
            {
                cmbEmailsToDelete.Visible = false;
                txtDeleteEmail.Text = cmbEmailsToDelete.SelectedItem.ToString();
            }
        }

        private void btnDeleteEmail_Click(object sender, EventArgs e)
        {
            string emailToDelete = txtDeleteEmail.Text;
            string message = "";

            message = "Are you sure you want to delete " + emailToDelete + "?";
            if (MessageBox.Show(message, "Confirm Email Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Contact contact = new Contact(sensorID, emailToDelete, 0);
                contact.deleteContact();

                MessageBox.Show("Email was successfully deleted!", "Successful Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lbxAvailableEmails.Items.Clear();
                int count = 1;
                List<Contact> allContacts = new List<Contact>();
                allContacts = contact.getAllContacts();

                foreach (Contact item in allContacts)
                {
                    if (item.SensorID == sensorID)
                    {
                        lbxAvailableEmails.Items.Add(count.ToString() + ". " + item.Email);
                        count++;
                    }
                }

                cmbEmailsToDelete.SelectedIndex = 0;
                cmbEmailsToDelete.Visible = true;
                txtDeleteEmail.Clear();
            }
            else
            {
                txtDeleteEmail.Clear();
                cmbEmailsToDelete.SelectedIndex = 0;
                cmbEmailsToDelete.Visible = true;
            }
        }
    }
}
