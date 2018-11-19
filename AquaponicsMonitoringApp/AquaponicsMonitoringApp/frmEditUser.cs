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
    /// This form is used to update an existing user's information, register a new user or delete
    /// an existing user.
    /// </summary>
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();
            User user = new User();
            List<User> allUsers = user.getAllRegisteredUsers();

            cmbUsers.Items.Add("SELECT A USER:");
            foreach (User item in allUsers)
            {
                cmbUsers.Items.Add(item.Username + " - " + item.Email);
            }

            cmbUsers.SelectedIndex = 0;
        }

        private void btnCloseEditUser_Click(object sender, EventArgs e)
        {

            frmSettingsMainDash Settings = new frmSettingsMainDash();
            Settings.Show();
            this.Close();
        }

        int selectedID = 0;
        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex != 0)
            {
                btnUpdate.BackColor = Color.DarkGreen;
                btnDelete.BackColor = Color.DarkGreen;
                btnAddUser.BackColor = Color.DarkSlateGray;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAddUser.Enabled = false;


                User selectedUser = new User();
                List<User> allUsers = selectedUser.getAllRegisteredUsers();
                selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

                selectedID = selectedUser.UserID;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlDeleteUser.Visible = false;
            pnlUpdateUser.Visible = true;

            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.Enabled = false;

            btnDelete.FlatStyle = FlatStyle.Standard;
            btnDelete.BackColor = Color.DarkGreen;
            btnDelete.Enabled = true;

            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex-1];

            txtUsernameRegister.Text = selectedUser.Username;

            txtPasswordRegister.PasswordChar = '\0';
            txtPasswordRegister.Text = selectedUser.Password;

            txtRePasswordRegister.PasswordChar = '\0';
            txtRePasswordRegister.Text = selectedUser.Password;

            txtEmail.Text = selectedUser.Email;
            txtConfirmEmail.Text = selectedUser.Email;

            lblCurrentQA.Text = string.Format("{0}-{1}",selectedUser.SecurityQ,selectedUser.SecurityA);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlUpdateUser.Visible = true;
            pnlDeleteUser.Visible = true;

            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Enabled = false;

            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnUpdate.BackColor = Color.DarkGreen;
            btnUpdate.Enabled = true;

            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

            txtUsername.Text = selectedUser.Username;

            txtPassword.PasswordChar = '\0';
            txtPassword.Text = selectedUser.Password;

            txtEmailDelete.Text = selectedUser.Email;

            lblDeleteCurrentSecurityQA.Text = string.Format("{0}-{1}", selectedUser.SecurityQ, selectedUser.SecurityA);
        }

        private void cbxNewSecurityQ_CheckedChanged(object sender, EventArgs e)
        {
            cmbSecurityQuestion.Items.Clear();
            User user = new User();
            List<string> allSecurityQuestions = user.getSecurityQuestions();

            foreach (string item in allSecurityQuestions)
            {
                cmbSecurityQuestion.Items.Add(item);
            }

            pnlNewSecurityQA.Visible = true;
            cbxNewSecurityQ.Visible = false;
            cmbSecurityQuestion.SelectedIndex = 0;
        }

        private void txtUsernameRegister_Enter(object sender, EventArgs e)
        {
            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

            if (txtUsernameRegister.Text == selectedUser.Username) // clears default text when clicked
            {
                txtUsernameRegister.Text = "";
                txtUsernameRegister.ForeColor = Color.Black;
            }
        }

        private void txtUsernameRegister_Leave(object sender, EventArgs e)
        {
            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

            if (txtUsernameRegister.Text == "") //  adds default text when it loses focus
            {
                txtUsernameRegister.Text = selectedUser.Username;
                txtUsernameRegister.ForeColor = Color.DarkGray;
            }
        }

        private void txtPasswordRegister_Enter(object sender, EventArgs e)
        {
            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

            if (txtPasswordRegister.Text == selectedUser.Password) // clears default text when clicked
            {
                txtPasswordRegister.Text = "";
                txtPasswordRegister.ForeColor = Color.Black;
                txtPasswordRegister.PasswordChar = '•';

            }
        }

        private void txtPasswordRegister_Leave(object sender, EventArgs e)
        {
            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

            if (txtPasswordRegister.Text == "") //  adds default text when it loses focus
            {
                txtPasswordRegister.Text = selectedUser.Password;
                txtPasswordRegister.ForeColor = Color.DarkGray;
            }
        }

        private void txtRePasswordRegister_Enter(object sender, EventArgs e)
        {
            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

            if (txtRePasswordRegister.Text == selectedUser.Password) // clears default text when clicked
            {
                txtRePasswordRegister.Text = "";
                txtRePasswordRegister.ForeColor = Color.Black;
                txtRePasswordRegister.PasswordChar = '•';

            }
        }

        private void txtRePasswordRegister_Leave(object sender, EventArgs e)
        {
            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

            if (txtRePasswordRegister.Text == "") //  adds default text when it loses focus
            {
                txtRePasswordRegister.Text = selectedUser.Password;
                txtRePasswordRegister.ForeColor = Color.DarkGray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

            if (txtEmail.Text == selectedUser.Email) // clears default text when clicked
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

            if (txtEmail.Text == "") //  adds default text when it loses focus
            {
                txtEmail.Text = selectedUser.Email;
                txtEmail.ForeColor = Color.DarkGray;
            }
        }

        private void txtConfirmEmail_Enter(object sender, EventArgs e)
        {
            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

            if (txtConfirmEmail.Text == selectedUser.Email) // clears default text when clicked
            {
                txtConfirmEmail.Text = "";
                txtConfirmEmail.ForeColor = Color.Black;
            }
        }

        private void txtConfirmEmail_Leave(object sender, EventArgs e)
        {
            User selectedUser = new User();
            List<User> allUsers = selectedUser.getAllRegisteredUsers();
            selectedUser = allUsers[cmbUsers.SelectedIndex - 1];

            if (txtConfirmEmail.Text == "") //  adds default text when it loses focus
            {
                txtConfirmEmail.Text = selectedUser.Email;
                txtConfirmEmail.ForeColor = Color.DarkGray;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
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

            if ((pnlNewSecurityQA.Visible == true))
            {
                if (cmbSecurityQuestion.SelectedIndex != 0)
                {
                    securityQuestion = cmbSecurityQuestion.SelectedItem.ToString();

                    if (txtNewSecurityAnswer.Text != "")
                    {
                        securityQuestionAnswer = txtNewSecurityAnswer.Text;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Security Answer! Please try again.","Invalid Security Answer",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        txtNewSecurityAnswer.Clear();
                        lblEnterAnswer.ForeColor = Color.Red;
                    }

                    if ((securityQuestion != "")&&(securityQuestionAnswer != ""))
                    {
                        securityQAValid = true;
                    }

                }
                else
                {
                    string[] fields = lblCurrentQA.Text.Split('-');
                    securityQuestion = fields[0];
                    securityQuestionAnswer = fields[1];
                    securityQAValid = true;
                }
            }
            else
            {
                string[] fields = lblCurrentQA.Text.Split('-');
                securityQuestion = fields[0];
                securityQuestionAnswer = fields[1];
                securityQAValid = true;
            }

            if (password == confirmPassword)
            {
                if (email == confirmEmail)
                {
                    if ((passwordValid == true) && (emailValid == true) && (securityQAValid == true))
                    {
                        User user = new User(username, password, email, securityQuestion, securityQuestionAnswer, selectedID);
                        user.updateUsers();

                        MessageBox.Show("User was successfully updated!", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmEditUser EditUser = new frmEditUser();
                        EditUser.Show();
                        this.Close();
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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmailDelete.Text;
            string securityQuestion = "";
            string securityQuestionAnswer = "";

            string[] fields = lblDeleteCurrentSecurityQA.Text.Split('-');
            securityQuestion = fields[0];
            securityQuestionAnswer = fields[1];

            string loggedUser = user.getCurrentLoggedUser();
            string[] loggedUserDetails = loggedUser.Split(';');
            string usernameLogged = loggedUserDetails[0];
            string passwordLogged = loggedUserDetails[1];

            if ((username != usernameLogged) && (password != passwordLogged))
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm User Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    user = new User(username, password, email, securityQuestion, securityQuestionAnswer, selectedID);
                    user.deleteUsers();
                    MessageBox.Show("User was succefully deleted!", "Successful Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmEditUser EditUser = new frmEditUser();
                    EditUser.Show();

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("This user is currently logged into the system and therefore cannot be deleted", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmFormSeparator Separator = new frmFormSeparator();
            Separator.Show();
            frmRegister register = new frmRegister();
            register.Show();
        }
    }
}
