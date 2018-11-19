namespace AquaponicsMonitoringApp
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.pnlHeaderRegister = new System.Windows.Forms.Panel();
            this.lblRegisterHeader = new System.Windows.Forms.Label();
            this.btnCloseRegister = new System.Windows.Forms.Button();
            this.pnlLogin_Register = new System.Windows.Forms.Panel();
            this.pnlRegisterDetails = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.pnlSecurityQuestion = new System.Windows.Forms.Panel();
            this.pnlSecurityAnswer = new System.Windows.Forms.Panel();
            this.lblSelectedQuestion = new System.Windows.Forms.Label();
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.pnlNotificationDetails = new System.Windows.Forms.Panel();
            this.txtConfirmEmail = new System.Windows.Forms.TextBox();
            this.lblNotificationDetails = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblConfirmEmail = new System.Windows.Forms.Label();
            this.lblEnterEmail = new System.Windows.Forms.Label();
            this.lblLoginInformation = new System.Windows.Forms.Label();
            this.pnlRegisterLoginDetails = new System.Windows.Forms.Panel();
            this.txtRePasswordRegister = new System.Windows.Forms.TextBox();
            this.lblReEnterPassword = new System.Windows.Forms.Label();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.lblEnterUsername = new System.Windows.Forms.Label();
            this.txtPasswordRegister = new System.Windows.Forms.TextBox();
            this.txtUsernameRegister = new System.Windows.Forms.TextBox();
            this.lblEnterNewUser = new System.Windows.Forms.Label();
            this.btnREGISTERform = new System.Windows.Forms.Button();
            this.pnlHeaderRegister.SuspendLayout();
            this.pnlLogin_Register.SuspendLayout();
            this.pnlRegisterDetails.SuspendLayout();
            this.pnlSecurityQuestion.SuspendLayout();
            this.pnlSecurityAnswer.SuspendLayout();
            this.pnlNotificationDetails.SuspendLayout();
            this.pnlRegisterLoginDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderRegister
            // 
            this.pnlHeaderRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.pnlHeaderRegister.Controls.Add(this.lblRegisterHeader);
            this.pnlHeaderRegister.Controls.Add(this.btnCloseRegister);
            this.pnlHeaderRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderRegister.Name = "pnlHeaderRegister";
            this.pnlHeaderRegister.Size = new System.Drawing.Size(486, 58);
            this.pnlHeaderRegister.TabIndex = 5;
            // 
            // lblRegisterHeader
            // 
            this.lblRegisterHeader.AutoSize = true;
            this.lblRegisterHeader.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterHeader.ForeColor = System.Drawing.Color.White;
            this.lblRegisterHeader.Location = new System.Drawing.Point(7, 15);
            this.lblRegisterHeader.Name = "lblRegisterHeader";
            this.lblRegisterHeader.Size = new System.Drawing.Size(83, 23);
            this.lblRegisterHeader.TabIndex = 6;
            this.lblRegisterHeader.Text = "Register";
            // 
            // btnCloseRegister
            // 
            this.btnCloseRegister.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCloseRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseRegister.BackgroundImage")));
            this.btnCloseRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseRegister.FlatAppearance.BorderSize = 0;
            this.btnCloseRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseRegister.Location = new System.Drawing.Point(444, 11);
            this.btnCloseRegister.Name = "btnCloseRegister";
            this.btnCloseRegister.Size = new System.Drawing.Size(39, 39);
            this.btnCloseRegister.TabIndex = 5;
            this.btnCloseRegister.UseVisualStyleBackColor = true;
            this.btnCloseRegister.Click += new System.EventHandler(this.btnCloseRegister_Click);
            // 
            // pnlLogin_Register
            // 
            this.pnlLogin_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin_Register.Controls.Add(this.pnlRegisterDetails);
            this.pnlLogin_Register.Controls.Add(this.btnREGISTERform);
            this.pnlLogin_Register.Location = new System.Drawing.Point(64, 95);
            this.pnlLogin_Register.Name = "pnlLogin_Register";
            this.pnlLogin_Register.Size = new System.Drawing.Size(367, 468);
            this.pnlLogin_Register.TabIndex = 6;
            // 
            // pnlRegisterDetails
            // 
            this.pnlRegisterDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegisterDetails.Controls.Add(this.btnRegister);
            this.pnlRegisterDetails.Controls.Add(this.txtSecurityAnswer);
            this.pnlRegisterDetails.Controls.Add(this.pnlSecurityQuestion);
            this.pnlRegisterDetails.Controls.Add(this.pnlNotificationDetails);
            this.pnlRegisterDetails.Controls.Add(this.lblLoginInformation);
            this.pnlRegisterDetails.Controls.Add(this.pnlRegisterLoginDetails);
            this.pnlRegisterDetails.Controls.Add(this.lblEnterNewUser);
            this.pnlRegisterDetails.Location = new System.Drawing.Point(3, 59);
            this.pnlRegisterDetails.Name = "pnlRegisterDetails";
            this.pnlRegisterDetails.Size = new System.Drawing.Size(359, 406);
            this.pnlRegisterDetails.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(221, 358);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(127, 45);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecurityAnswer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityAnswer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSecurityAnswer.Location = new System.Drawing.Point(7, 358);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(163, 26);
            this.txtSecurityAnswer.TabIndex = 17;
            this.txtSecurityAnswer.Text = "Enter Answer";
            this.txtSecurityAnswer.Enter += new System.EventHandler(this.txtSecurityAnswer_Enter);
            this.txtSecurityAnswer.Leave += new System.EventHandler(this.txtSecurityAnswer_Leave);
            // 
            // pnlSecurityQuestion
            // 
            this.pnlSecurityQuestion.Controls.Add(this.pnlSecurityAnswer);
            this.pnlSecurityQuestion.Controls.Add(this.cmbSecurityQuestion);
            this.pnlSecurityQuestion.Controls.Add(this.lblSecurityQuestion);
            this.pnlSecurityQuestion.Location = new System.Drawing.Point(0, 291);
            this.pnlSecurityQuestion.Name = "pnlSecurityQuestion";
            this.pnlSecurityQuestion.Size = new System.Drawing.Size(359, 64);
            this.pnlSecurityQuestion.TabIndex = 16;
            // 
            // pnlSecurityAnswer
            // 
            this.pnlSecurityAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSecurityAnswer.Controls.Add(this.lblSelectedQuestion);
            this.pnlSecurityAnswer.Location = new System.Drawing.Point(0, 17);
            this.pnlSecurityAnswer.Name = "pnlSecurityAnswer";
            this.pnlSecurityAnswer.Size = new System.Drawing.Size(359, 67);
            this.pnlSecurityAnswer.TabIndex = 18;
            this.pnlSecurityAnswer.Visible = false;
            // 
            // lblSelectedQuestion
            // 
            this.lblSelectedQuestion.AutoSize = true;
            this.lblSelectedQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedQuestion.ForeColor = System.Drawing.Color.White;
            this.lblSelectedQuestion.Location = new System.Drawing.Point(3, 14);
            this.lblSelectedQuestion.Name = "lblSelectedQuestion";
            this.lblSelectedQuestion.Size = new System.Drawing.Size(57, 21);
            this.lblSelectedQuestion.TabIndex = 15;
            this.lblSelectedQuestion.Text = "label1";
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurityQuestion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecurityQuestion.FormattingEnabled = true;
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(6, 24);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(342, 28);
            this.cmbSecurityQuestion.TabIndex = 16;
            this.cmbSecurityQuestion.SelectedIndexChanged += new System.EventHandler(this.cmbSecurityQuestion_SelectedIndexChanged);
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSecurityQuestion.Location = new System.Drawing.Point(3, -4);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(201, 18);
            this.lblSecurityQuestion.TabIndex = 17;
            this.lblSecurityQuestion.Text = "Choose Security Question";
            // 
            // pnlNotificationDetails
            // 
            this.pnlNotificationDetails.Controls.Add(this.txtConfirmEmail);
            this.pnlNotificationDetails.Controls.Add(this.lblNotificationDetails);
            this.pnlNotificationDetails.Controls.Add(this.txtEmail);
            this.pnlNotificationDetails.Controls.Add(this.lblConfirmEmail);
            this.pnlNotificationDetails.Controls.Add(this.lblEnterEmail);
            this.pnlNotificationDetails.Location = new System.Drawing.Point(0, 190);
            this.pnlNotificationDetails.Name = "pnlNotificationDetails";
            this.pnlNotificationDetails.Size = new System.Drawing.Size(359, 80);
            this.pnlNotificationDetails.TabIndex = 15;
            // 
            // txtConfirmEmail
            // 
            this.txtConfirmEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtConfirmEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmEmail.ForeColor = System.Drawing.Color.White;
            this.txtConfirmEmail.Location = new System.Drawing.Point(159, 45);
            this.txtConfirmEmail.Name = "txtConfirmEmail";
            this.txtConfirmEmail.Size = new System.Drawing.Size(189, 26);
            this.txtConfirmEmail.TabIndex = 15;
            // 
            // lblNotificationDetails
            // 
            this.lblNotificationDetails.AutoSize = true;
            this.lblNotificationDetails.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNotificationDetails.Location = new System.Drawing.Point(3, -4);
            this.lblNotificationDetails.Name = "lblNotificationDetails";
            this.lblNotificationDetails.Size = new System.Drawing.Size(150, 18);
            this.lblNotificationDetails.TabIndex = 16;
            this.lblNotificationDetails.Text = "Notification Details";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(159, 13);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // lblConfirmEmail
            // 
            this.lblConfirmEmail.AutoSize = true;
            this.lblConfirmEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblConfirmEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmEmail.ForeColor = System.Drawing.Color.White;
            this.lblConfirmEmail.Location = new System.Drawing.Point(23, 51);
            this.lblConfirmEmail.Name = "lblConfirmEmail";
            this.lblConfirmEmail.Size = new System.Drawing.Size(111, 20);
            this.lblConfirmEmail.TabIndex = 1;
            this.lblConfirmEmail.Text = "Confirm Email:";
            // 
            // lblEnterEmail
            // 
            this.lblEnterEmail.AutoSize = true;
            this.lblEnterEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterEmail.ForeColor = System.Drawing.Color.White;
            this.lblEnterEmail.Location = new System.Drawing.Point(23, 19);
            this.lblEnterEmail.Name = "lblEnterEmail";
            this.lblEnterEmail.Size = new System.Drawing.Size(91, 20);
            this.lblEnterEmail.TabIndex = 0;
            this.lblEnterEmail.Text = "Enter Email:";
            // 
            // lblLoginInformation
            // 
            this.lblLoginInformation.AutoSize = true;
            this.lblLoginInformation.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLoginInformation.Location = new System.Drawing.Point(3, 31);
            this.lblLoginInformation.Name = "lblLoginInformation";
            this.lblLoginInformation.Size = new System.Drawing.Size(136, 18);
            this.lblLoginInformation.TabIndex = 14;
            this.lblLoginInformation.Text = "Login Information";
            // 
            // pnlRegisterLoginDetails
            // 
            this.pnlRegisterLoginDetails.Controls.Add(this.txtRePasswordRegister);
            this.pnlRegisterLoginDetails.Controls.Add(this.lblReEnterPassword);
            this.pnlRegisterLoginDetails.Controls.Add(this.lblEnterPassword);
            this.pnlRegisterLoginDetails.Controls.Add(this.lblEnterUsername);
            this.pnlRegisterLoginDetails.Controls.Add(this.txtPasswordRegister);
            this.pnlRegisterLoginDetails.Controls.Add(this.txtUsernameRegister);
            this.pnlRegisterLoginDetails.Location = new System.Drawing.Point(0, 38);
            this.pnlRegisterLoginDetails.Name = "pnlRegisterLoginDetails";
            this.pnlRegisterLoginDetails.Size = new System.Drawing.Size(359, 137);
            this.pnlRegisterLoginDetails.TabIndex = 8;
            // 
            // txtRePasswordRegister
            // 
            this.txtRePasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtRePasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRePasswordRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePasswordRegister.ForeColor = System.Drawing.Color.White;
            this.txtRePasswordRegister.Location = new System.Drawing.Point(185, 100);
            this.txtRePasswordRegister.Name = "txtRePasswordRegister";
            this.txtRePasswordRegister.PasswordChar = '•';
            this.txtRePasswordRegister.Size = new System.Drawing.Size(163, 26);
            this.txtRePasswordRegister.TabIndex = 13;
            // 
            // lblReEnterPassword
            // 
            this.lblReEnterPassword.AutoSize = true;
            this.lblReEnterPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReEnterPassword.ForeColor = System.Drawing.Color.White;
            this.lblReEnterPassword.Location = new System.Drawing.Point(24, 102);
            this.lblReEnterPassword.Name = "lblReEnterPassword";
            this.lblReEnterPassword.Size = new System.Drawing.Size(150, 20);
            this.lblReEnterPassword.TabIndex = 12;
            this.lblReEnterPassword.Text = "Re-enter Password:";
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPassword.ForeColor = System.Drawing.Color.White;
            this.lblEnterPassword.Location = new System.Drawing.Point(24, 61);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(124, 20);
            this.lblEnterPassword.TabIndex = 11;
            this.lblEnterPassword.Text = "Enter Password:";
            // 
            // lblEnterUsername
            // 
            this.lblEnterUsername.AutoSize = true;
            this.lblEnterUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterUsername.ForeColor = System.Drawing.Color.White;
            this.lblEnterUsername.Location = new System.Drawing.Point(24, 19);
            this.lblEnterUsername.Name = "lblEnterUsername";
            this.lblEnterUsername.Size = new System.Drawing.Size(128, 20);
            this.lblEnterUsername.TabIndex = 10;
            this.lblEnterUsername.Text = "Enter Username:";
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordRegister.ForeColor = System.Drawing.Color.White;
            this.txtPasswordRegister.Location = new System.Drawing.Point(185, 59);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.PasswordChar = '•';
            this.txtPasswordRegister.Size = new System.Drawing.Size(163, 26);
            this.txtPasswordRegister.TabIndex = 9;
            // 
            // txtUsernameRegister
            // 
            this.txtUsernameRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtUsernameRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameRegister.ForeColor = System.Drawing.Color.White;
            this.txtUsernameRegister.Location = new System.Drawing.Point(185, 17);
            this.txtUsernameRegister.Name = "txtUsernameRegister";
            this.txtUsernameRegister.Size = new System.Drawing.Size(163, 26);
            this.txtUsernameRegister.TabIndex = 8;
            // 
            // lblEnterNewUser
            // 
            this.lblEnterNewUser.AutoSize = true;
            this.lblEnterNewUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNewUser.ForeColor = System.Drawing.Color.White;
            this.lblEnterNewUser.Location = new System.Drawing.Point(3, 0);
            this.lblEnterNewUser.Name = "lblEnterNewUser";
            this.lblEnterNewUser.Size = new System.Drawing.Size(124, 18);
            this.lblEnterNewUser.TabIndex = 5;
            this.lblEnterNewUser.Text = "Enter New User:";
            // 
            // btnREGISTERform
            // 
            this.btnREGISTERform.BackColor = System.Drawing.Color.Transparent;
            this.btnREGISTERform.FlatAppearance.BorderSize = 0;
            this.btnREGISTERform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnREGISTERform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREGISTERform.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREGISTERform.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnREGISTERform.Image = ((System.Drawing.Image)(resources.GetObject("btnREGISTERform.Image")));
            this.btnREGISTERform.Location = new System.Drawing.Point(10, 18);
            this.btnREGISTERform.Name = "btnREGISTERform";
            this.btnREGISTERform.Size = new System.Drawing.Size(115, 38);
            this.btnREGISTERform.TabIndex = 1;
            this.btnREGISTERform.Text = " REGISTER";
            this.btnREGISTERform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnREGISTERform.UseVisualStyleBackColor = false;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(486, 594);
            this.Controls.Add(this.pnlHeaderRegister);
            this.Controls.Add(this.pnlLogin_Register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.pnlHeaderRegister.ResumeLayout(false);
            this.pnlHeaderRegister.PerformLayout();
            this.pnlLogin_Register.ResumeLayout(false);
            this.pnlRegisterDetails.ResumeLayout(false);
            this.pnlRegisterDetails.PerformLayout();
            this.pnlSecurityQuestion.ResumeLayout(false);
            this.pnlSecurityQuestion.PerformLayout();
            this.pnlSecurityAnswer.ResumeLayout(false);
            this.pnlSecurityAnswer.PerformLayout();
            this.pnlNotificationDetails.ResumeLayout(false);
            this.pnlNotificationDetails.PerformLayout();
            this.pnlRegisterLoginDetails.ResumeLayout(false);
            this.pnlRegisterLoginDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderRegister;
        private System.Windows.Forms.Label lblRegisterHeader;
        private System.Windows.Forms.Button btnCloseRegister;
        private System.Windows.Forms.Panel pnlLogin_Register;
        private System.Windows.Forms.Panel pnlRegisterDetails;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Panel pnlSecurityQuestion;
        private System.Windows.Forms.Panel pnlSecurityAnswer;
        private System.Windows.Forms.Label lblSelectedQuestion;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.Panel pnlNotificationDetails;
        private System.Windows.Forms.TextBox txtConfirmEmail;
        private System.Windows.Forms.Label lblNotificationDetails;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblConfirmEmail;
        private System.Windows.Forms.Label lblEnterEmail;
        private System.Windows.Forms.Label lblLoginInformation;
        private System.Windows.Forms.Panel pnlRegisterLoginDetails;
        private System.Windows.Forms.TextBox txtRePasswordRegister;
        private System.Windows.Forms.Label lblReEnterPassword;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.Label lblEnterUsername;
        private System.Windows.Forms.TextBox txtPasswordRegister;
        private System.Windows.Forms.TextBox txtUsernameRegister;
        private System.Windows.Forms.Label lblEnterNewUser;
        private System.Windows.Forms.Button btnREGISTERform;
    }
}