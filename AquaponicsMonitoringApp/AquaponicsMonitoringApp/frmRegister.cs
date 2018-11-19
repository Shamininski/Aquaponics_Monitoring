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
    public partial class frmRegister : Form
    {
        /// <summary>
        /// Form Creator: Eldané
        /// </summary>
        public frmRegister()
        {
            InitializeComponent();
            pnlLogin_Register.BackColor = Color.FromArgb(50, Color.White);

            User user = new User();
            List<string> allSecurityQuestions = new List<string>(); // get all the security questions from a textfile
            allSecurityQuestions = user.getSecurityQuestions();

            foreach (string question in allSecurityQuestions) // populate the combo box with security questions
            {
                cmbSecurityQuestion.Items.Add(question);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsernameRegister.Text;
            string password = "";
            string confirmPassword = "";
            string email = "";
            string confirmEmail = "";
            string securityQuestion = "";
            string securityQuestionAnswer = "";

            bool passwordValid = false;
            bool emailValid = false;
            bool securityQAValid = false;
            bool uniqueUser = false;

            if (txtPasswordRegister.Text.Length >= 9) // password must be 9 or more characters long
            {
                password = txtPasswordRegister.Text;
                confirmPassword = txtRePasswordRegister.Text;
                passwordValid = true;
            }
            else
            {
                MessageBox.Show("Password must be at least 9 characters long", "Invalid Password Length", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblEnterPassword.ForeColor = Color.Red;
                txtPasswordRegister.Clear();
                txtRePasswordRegister.Clear();
            }

            if (txtEmail.Text.Contains("@"))
            {
                email = txtEmail.Text;
                confirmEmail = txtConfirmEmail.Text;
                emailValid = true;
            }
            else
            {
                MessageBox.Show("Email is invalid!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblEnterEmail.ForeColor = Color.Red;
                txtEmail.Clear();
                txtConfirmEmail.Clear();
            }

            if ((cmbSecurityQuestion.SelectedIndex != 0) && (txtSecurityAnswer.Text != ""))
            {
                securityQuestion = cmbSecurityQuestion.SelectedItem.ToString();
                securityQuestionAnswer = txtSecurityAnswer.Text;
                securityQAValid = true;
            }
            else
            {
                MessageBox.Show("Please choose a security question and give an appropriate answer", "Invalid Security Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblSecurityQuestion.ForeColor = Color.Red;
                txtSecurityAnswer.Clear();
                cmbSecurityQuestion.SelectedIndex = 0;
            }

            if (password == confirmPassword)
            {
                if (email == confirmEmail)
                {
                    if ((passwordValid == true) && (emailValid == true) && (securityQAValid == true))
                    {
                        User registeredUser = new User();
                        List<User> registeredUsers = new List<User>();
                        registeredUsers = registeredUser.getAllRegisteredUsers();
                        foreach (User item in registeredUsers)
                        {
                            if ((item.Username != username) && (item.Password != password) && (item.Email != email)) // check if username and password isn't already registered
                            {
                                uniqueUser = true;
                            }
                            else if (item.Username == username)
                            {
                                MessageBox.Show("This username already exists! Please choose another username", "Existing Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                lblEnterUsername.ForeColor = Color.Red;
                                txtUsernameRegister.Clear();
                            }
                            else if (item.Password == password)
                            {
                                MessageBox.Show("This password already exists! Please provide another password", "Existing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                lblEnterPassword.ForeColor = Color.Red;
                                txtPasswordRegister.Clear();
                                txtRePasswordRegister.Clear();
                            }
                            else if (item.Email == email)
                            {
                                MessageBox.Show("This email already exists! Please provide another email address", "Existing Email Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                lblEnterEmail.ForeColor = Color.Red;
                                txtEmail.Clear();
                                txtConfirmEmail.Clear();
                            }
                        }

                        if (uniqueUser == true)
                        {
                            User user = new User(username, password, email, securityQuestion, securityQuestionAnswer, 0);
                            user.newUser();

                            MessageBox.Show("User was successfully registered!", "Successful Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtUsernameRegister.Clear();
                            txtPasswordRegister.Clear();
                            txtRePasswordRegister.Clear();
                            txtEmail.Clear();
                            txtConfirmEmail.Clear();
                            cmbSecurityQuestion.SelectedIndex = 0;
                            txtSecurityAnswer.Clear();
                            lblEnterPassword.ForeColor = Color.White;
                            lblReEnterPassword.ForeColor = Color.White;
                            lblEnterEmail.ForeColor = Color.White;
                            lblConfirmEmail.ForeColor = Color.White;
                            lblSecurityQuestion.ForeColor = Color.White;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Retry email entries", "Email Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblEnterEmail.ForeColor = Color.Red;
                    lblConfirmEmail.ForeColor = Color.Red;
                    txtEmail.Clear();
                    txtConfirmEmail.Clear();
                }
            }
            else
            {
                MessageBox.Show("Retry password entries", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblEnterPassword.ForeColor = Color.Red;
                lblReEnterPassword.ForeColor = Color.Red;
                txtPasswordRegister.Clear();
                txtRePasswordRegister.Clear();
            }
           
        }

        private void txtSecurityAnswer_Enter(object sender, EventArgs e)
        {
            if (txtSecurityAnswer.Text == "Enter Answer") // clears default text when clicked
            {
                txtSecurityAnswer.Text = "";
                txtSecurityAnswer.ForeColor = Color.White;
            }
        }

        private void txtSecurityAnswer_Leave(object sender, EventArgs e)
        {
            if (txtSecurityAnswer.Text == "") //  adds default text when it loses focus
            {
                txtSecurityAnswer.Text = "Enter Answer";
                txtSecurityAnswer.ForeColor = Color.DarkSlateGray;
            }
        }

        private void cmbSecurityQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedQuestion.Text = cmbSecurityQuestion.SelectedItem.ToString();
            pnlSecurityAnswer.Visible = true;
        }

        private void btnCloseRegister_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--) // Close all the current open forms
            {
                if (Application.OpenForms[i].Name == "frmFormSeparator")
                {
                    Application.OpenForms[i].Close();
                }
            }

            frmSettingsMainDash settingsMain = new frmSettingsMainDash();
            settingsMain.Show();
            this.Close();
        }
    }
}
