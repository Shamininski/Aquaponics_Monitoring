using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AquaponicsMonitoringApp.ApplicationLayer;
using Microsoft.VisualBasic;

namespace AquaponicsMonitoringApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            pnlLogin_Register.BackColor = Color.FromArgb(50, Color.White);
            btnLOGINform.FlatAppearance.BorderSize = 1;
            pnlLoginDetails.Visible = true;
           
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--) // Close all the current open forms
            {
                if (Application.OpenForms[i].Name == "frmFormSeparator")
                {
                    Application.OpenForms[i].Close();
                }
            }

            frmMainDashboard MainDash = new frmMainDashboard();
            MainDash.Show();
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usernameParam = txtUsernameLogin.Text;
            string passwordParam = txtPasswordLogin.Text;
            bool accessAllowed = false;

            User user = new User(usernameParam, passwordParam,0);
            accessAllowed = user.testLogin();

            if (accessAllowed == true)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--) // Close all current open forms
                {
                    if (Application.OpenForms[i].Name == "frmFormSeparator")
                    {
                        Application.OpenForms[i].Close();
                    }
                }

                user.saveLoggedUser();
                frmSettingsMainDash Settings = new frmSettingsMainDash();
                Settings.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Login Details! Please try again.", "Incorrect Login Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsernameLogin.Clear();
                txtPasswordLogin.Clear();
            }
        }

        private void cbxForgotPassword_CheckedChanged(object sender, EventArgs e)
        {
            string email = "";
            string securityAnswerInput = "";
            bool correctEmail = false;

            User user = new User();
            List<User> allUsers = new List<User>();
            allUsers = user.getAllRegisteredUsers();

            List<User> userRequest = new List<User>();
         
            email = Interaction.InputBox("Provide Email Address", "Password Recovery Process", "", -1, -1);

            foreach (User item in allUsers)
            {
                if (item.Email == email)
                {
                    userRequest.Add(item);
                    correctEmail = true;
                }
            }

            if (correctEmail ==  true)
            {
                securityAnswerInput = Interaction.InputBox(userRequest[0].SecurityQ, "Password Recovery Process", "", -1, -1);
                if (securityAnswerInput == userRequest[0].SecurityA)
                {
                    User resendPasswordUser = new User(userRequest[0].Username, userRequest[0].Password, userRequest[0].Email, userRequest[0].SecurityQ, userRequest[0].SecurityA, userRequest[0].UserID);
                    resendPasswordUser.mailPassword();
                    MessageBox.Show("Your password recovery email has been send! Please check your inbox.", "Password Recovery Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This answer is incorrect!", "Password Recovery Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The given email is not registered! Please try again.", "Incorrect Email Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cbxSeePassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswordLogin.PasswordChar = cbxSeePassword.Checked ? '\0' : '•';
        }

    }
}
