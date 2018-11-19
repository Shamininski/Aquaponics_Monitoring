namespace AquaponicsMonitoringApp
{
    partial class frmEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditUser));
            this.pnlHeaderLogin = new System.Windows.Forms.Panel();
            this.lblEditUserHeading = new System.Windows.Forms.Label();
            this.btnCloseEditUser = new System.Windows.Forms.Button();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlUpdateUser = new System.Windows.Forms.Panel();
            this.pnlDeleteUser = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblCurrentSQA = new System.Windows.Forms.Label();
            this.lbNotificationInfo = new System.Windows.Forms.Label();
            this.pnlNotificationInfo = new System.Windows.Forms.Panel();
            this.txtEmailDelete = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLoginDetails = new System.Windows.Forms.Label();
            this.pnlLoginDetails = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlCurrentSecurityQuestion = new System.Windows.Forms.Panel();
            this.lblDeleteCurrentSecurityQA = new System.Windows.Forms.Label();
            this.lblCurrentSecQandA = new System.Windows.Forms.Label();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.lblNotificationDetails = new System.Windows.Forms.Label();
            this.pnlNotificationDetails = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmEmail = new System.Windows.Forms.TextBox();
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
            this.pnlSecurityQuestion = new System.Windows.Forms.Panel();
            this.cbxNewSecurityQ = new System.Windows.Forms.CheckBox();
            this.pnlNewSecurityQA = new System.Windows.Forms.Panel();
            this.lblEnterAnswer = new System.Windows.Forms.Label();
            this.txtNewSecurityAnswer = new System.Windows.Forms.TextBox();
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.lblCurrentQA = new System.Windows.Forms.Label();
            this.lblCurrentSecurityQA = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pnlHeaderLogin.SuspendLayout();
            this.pnlUpdateUser.SuspendLayout();
            this.pnlDeleteUser.SuspendLayout();
            this.pnlNotificationInfo.SuspendLayout();
            this.pnlLoginDetails.SuspendLayout();
            this.pnlCurrentSecurityQuestion.SuspendLayout();
            this.pnlNotificationDetails.SuspendLayout();
            this.pnlRegisterLoginDetails.SuspendLayout();
            this.pnlSecurityQuestion.SuspendLayout();
            this.pnlNewSecurityQA.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderLogin
            // 
            this.pnlHeaderLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(55)))));
            this.pnlHeaderLogin.Controls.Add(this.lblEditUserHeading);
            this.pnlHeaderLogin.Controls.Add(this.btnCloseEditUser);
            this.pnlHeaderLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderLogin.Name = "pnlHeaderLogin";
            this.pnlHeaderLogin.Size = new System.Drawing.Size(864, 58);
            this.pnlHeaderLogin.TabIndex = 6;
            // 
            // lblEditUserHeading
            // 
            this.lblEditUserHeading.AutoSize = true;
            this.lblEditUserHeading.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUserHeading.ForeColor = System.Drawing.Color.White;
            this.lblEditUserHeading.Location = new System.Drawing.Point(24, 16);
            this.lblEditUserHeading.Name = "lblEditUserHeading";
            this.lblEditUserHeading.Size = new System.Drawing.Size(164, 23);
            this.lblEditUserHeading.TabIndex = 6;
            this.lblEditUserHeading.Text = "Edit User Settings";
            // 
            // btnCloseEditUser
            // 
            this.btnCloseEditUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCloseEditUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseEditUser.BackgroundImage")));
            this.btnCloseEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseEditUser.FlatAppearance.BorderSize = 0;
            this.btnCloseEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEditUser.Location = new System.Drawing.Point(822, 11);
            this.btnCloseEditUser.Name = "btnCloseEditUser";
            this.btnCloseEditUser.Size = new System.Drawing.Size(39, 39);
            this.btnCloseEditUser.TabIndex = 5;
            this.btnCloseEditUser.UseVisualStyleBackColor = true;
            this.btnCloseEditUser.Click += new System.EventHandler(this.btnCloseEditUser_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(28, 87);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(477, 29);
            this.cmbUsers.TabIndex = 24;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(642, 88);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 34);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(731, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 34);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlUpdateUser
            // 
            this.pnlUpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlUpdateUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateUser.Controls.Add(this.pnlDeleteUser);
            this.pnlUpdateUser.Controls.Add(this.btnUpdateUser);
            this.pnlUpdateUser.Controls.Add(this.lblSecurityQuestion);
            this.pnlUpdateUser.Controls.Add(this.lblNotificationDetails);
            this.pnlUpdateUser.Controls.Add(this.pnlNotificationDetails);
            this.pnlUpdateUser.Controls.Add(this.lblLoginInformation);
            this.pnlUpdateUser.Controls.Add(this.pnlRegisterLoginDetails);
            this.pnlUpdateUser.Controls.Add(this.pnlSecurityQuestion);
            this.pnlUpdateUser.Location = new System.Drawing.Point(28, 157);
            this.pnlUpdateUser.Name = "pnlUpdateUser";
            this.pnlUpdateUser.Size = new System.Drawing.Size(786, 305);
            this.pnlUpdateUser.TabIndex = 32;
            this.pnlUpdateUser.Visible = false;
            // 
            // pnlDeleteUser
            // 
            this.pnlDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeleteUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteUser.Controls.Add(this.btnDeleteUser);
            this.pnlDeleteUser.Controls.Add(this.lblCurrentSQA);
            this.pnlDeleteUser.Controls.Add(this.lbNotificationInfo);
            this.pnlDeleteUser.Controls.Add(this.pnlNotificationInfo);
            this.pnlDeleteUser.Controls.Add(this.lblLoginDetails);
            this.pnlDeleteUser.Controls.Add(this.pnlLoginDetails);
            this.pnlDeleteUser.Controls.Add(this.pnlCurrentSecurityQuestion);
            this.pnlDeleteUser.Location = new System.Drawing.Point(-1, -1);
            this.pnlDeleteUser.Name = "pnlDeleteUser";
            this.pnlDeleteUser.Size = new System.Drawing.Size(786, 309);
            this.pnlDeleteUser.TabIndex = 33;
            this.pnlDeleteUser.Visible = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeleteUser.FlatAppearance.BorderSize = 2;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(523, 143);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(127, 37);
            this.btnDeleteUser.TabIndex = 19;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lblCurrentSQA
            // 
            this.lblCurrentSQA.AutoSize = true;
            this.lblCurrentSQA.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSQA.ForeColor = System.Drawing.Color.White;
            this.lblCurrentSQA.Location = new System.Drawing.Point(412, 21);
            this.lblCurrentSQA.Name = "lblCurrentSQA";
            this.lblCurrentSQA.Size = new System.Drawing.Size(160, 22);
            this.lblCurrentSQA.TabIndex = 17;
            this.lblCurrentSQA.Text = "Security Question";
            // 
            // lbNotificationInfo
            // 
            this.lbNotificationInfo.AutoSize = true;
            this.lbNotificationInfo.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotificationInfo.ForeColor = System.Drawing.Color.White;
            this.lbNotificationInfo.Location = new System.Drawing.Point(32, 194);
            this.lbNotificationInfo.Name = "lbNotificationInfo";
            this.lbNotificationInfo.Size = new System.Drawing.Size(172, 22);
            this.lbNotificationInfo.TabIndex = 17;
            this.lbNotificationInfo.Text = "Notification Details";
            // 
            // pnlNotificationInfo
            // 
            this.pnlNotificationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotificationInfo.Controls.Add(this.txtEmailDelete);
            this.pnlNotificationInfo.Controls.Add(this.lblEmail);
            this.pnlNotificationInfo.Location = new System.Drawing.Point(28, 205);
            this.pnlNotificationInfo.Name = "pnlNotificationInfo";
            this.pnlNotificationInfo.Size = new System.Drawing.Size(359, 80);
            this.pnlNotificationInfo.TabIndex = 16;
            // 
            // txtEmailDelete
            // 
            this.txtEmailDelete.BackColor = System.Drawing.Color.White;
            this.txtEmailDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailDelete.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmailDelete.Location = new System.Drawing.Point(159, 23);
            this.txtEmailDelete.Name = "txtEmailDelete";
            this.txtEmailDelete.ReadOnly = true;
            this.txtEmailDelete.Size = new System.Drawing.Size(189, 26);
            this.txtEmailDelete.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(23, 29);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(112, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.AutoSize = true;
            this.lblLoginDetails.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginDetails.ForeColor = System.Drawing.Color.White;
            this.lblLoginDetails.Location = new System.Drawing.Point(32, 21);
            this.lblLoginDetails.Name = "lblLoginDetails";
            this.lblLoginDetails.Size = new System.Drawing.Size(162, 22);
            this.lblLoginDetails.TabIndex = 15;
            this.lblLoginDetails.Text = "Login Information";
            // 
            // pnlLoginDetails
            // 
            this.pnlLoginDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoginDetails.Controls.Add(this.lblPassword);
            this.pnlLoginDetails.Controls.Add(this.lblUsername);
            this.pnlLoginDetails.Controls.Add(this.txtPassword);
            this.pnlLoginDetails.Controls.Add(this.txtUsername);
            this.pnlLoginDetails.Location = new System.Drawing.Point(28, 36);
            this.pnlLoginDetails.Name = "pnlLoginDetails";
            this.pnlLoginDetails.Size = new System.Drawing.Size(359, 137);
            this.pnlLoginDetails.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(24, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(24, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Location = new System.Drawing.Point(185, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(163, 26);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.Location = new System.Drawing.Point(185, 41);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(163, 26);
            this.txtUsername.TabIndex = 8;
            // 
            // pnlCurrentSecurityQuestion
            // 
            this.pnlCurrentSecurityQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCurrentSecurityQuestion.Controls.Add(this.lblDeleteCurrentSecurityQA);
            this.pnlCurrentSecurityQuestion.Controls.Add(this.lblCurrentSecQandA);
            this.pnlCurrentSecurityQuestion.Location = new System.Drawing.Point(409, 36);
            this.pnlCurrentSecurityQuestion.Name = "pnlCurrentSecurityQuestion";
            this.pnlCurrentSecurityQuestion.Size = new System.Drawing.Size(359, 90);
            this.pnlCurrentSecurityQuestion.TabIndex = 18;
            // 
            // lblDeleteCurrentSecurityQA
            // 
            this.lblDeleteCurrentSecurityQA.AutoSize = true;
            this.lblDeleteCurrentSecurityQA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCurrentSecurityQA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.lblDeleteCurrentSecurityQA.Location = new System.Drawing.Point(16, 46);
            this.lblDeleteCurrentSecurityQA.Name = "lblDeleteCurrentSecurityQA";
            this.lblDeleteCurrentSecurityQA.Size = new System.Drawing.Size(0, 20);
            this.lblDeleteCurrentSecurityQA.TabIndex = 14;
            // 
            // lblCurrentSecQandA
            // 
            this.lblCurrentSecQandA.AutoSize = true;
            this.lblCurrentSecQandA.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSecQandA.ForeColor = System.Drawing.Color.White;
            this.lblCurrentSecQandA.Location = new System.Drawing.Point(17, 17);
            this.lblCurrentSecQandA.Name = "lblCurrentSecQandA";
            this.lblCurrentSecQandA.Size = new System.Drawing.Size(294, 18);
            this.lblCurrentSecQandA.TabIndex = 17;
            this.lblCurrentSecQandA.Text = "Current Security Question and Answer:";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdateUser.FlatAppearance.BorderSize = 2;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(523, 257);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(127, 33);
            this.btnUpdateUser.TabIndex = 19;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.White;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(416, 27);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(234, 22);
            this.lblSecurityQuestion.TabIndex = 17;
            this.lblSecurityQuestion.Text = "Choose Security Question";
            // 
            // lblNotificationDetails
            // 
            this.lblNotificationDetails.AutoSize = true;
            this.lblNotificationDetails.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationDetails.ForeColor = System.Drawing.Color.White;
            this.lblNotificationDetails.Location = new System.Drawing.Point(36, 200);
            this.lblNotificationDetails.Name = "lblNotificationDetails";
            this.lblNotificationDetails.Size = new System.Drawing.Size(172, 22);
            this.lblNotificationDetails.TabIndex = 17;
            this.lblNotificationDetails.Text = "Notification Details";
            // 
            // pnlNotificationDetails
            // 
            this.pnlNotificationDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotificationDetails.Controls.Add(this.txtEmail);
            this.pnlNotificationDetails.Controls.Add(this.txtConfirmEmail);
            this.pnlNotificationDetails.Controls.Add(this.lblConfirmEmail);
            this.pnlNotificationDetails.Controls.Add(this.lblEnterEmail);
            this.pnlNotificationDetails.Location = new System.Drawing.Point(32, 211);
            this.pnlNotificationDetails.Name = "pnlNotificationDetails";
            this.pnlNotificationDetails.Size = new System.Drawing.Size(359, 80);
            this.pnlNotificationDetails.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Location = new System.Drawing.Point(159, 13);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 26);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtConfirmEmail
            // 
            this.txtConfirmEmail.BackColor = System.Drawing.Color.White;
            this.txtConfirmEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmEmail.Location = new System.Drawing.Point(159, 45);
            this.txtConfirmEmail.Name = "txtConfirmEmail";
            this.txtConfirmEmail.Size = new System.Drawing.Size(189, 26);
            this.txtConfirmEmail.TabIndex = 15;
            this.txtConfirmEmail.Enter += new System.EventHandler(this.txtConfirmEmail_Enter);
            this.txtConfirmEmail.Leave += new System.EventHandler(this.txtConfirmEmail_Leave);
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
            this.lblLoginInformation.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInformation.ForeColor = System.Drawing.Color.White;
            this.lblLoginInformation.Location = new System.Drawing.Point(36, 27);
            this.lblLoginInformation.Name = "lblLoginInformation";
            this.lblLoginInformation.Size = new System.Drawing.Size(162, 22);
            this.lblLoginInformation.TabIndex = 15;
            this.lblLoginInformation.Text = "Login Information";
            // 
            // pnlRegisterLoginDetails
            // 
            this.pnlRegisterLoginDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegisterLoginDetails.Controls.Add(this.txtRePasswordRegister);
            this.pnlRegisterLoginDetails.Controls.Add(this.lblReEnterPassword);
            this.pnlRegisterLoginDetails.Controls.Add(this.lblEnterPassword);
            this.pnlRegisterLoginDetails.Controls.Add(this.lblEnterUsername);
            this.pnlRegisterLoginDetails.Controls.Add(this.txtPasswordRegister);
            this.pnlRegisterLoginDetails.Controls.Add(this.txtUsernameRegister);
            this.pnlRegisterLoginDetails.Location = new System.Drawing.Point(32, 42);
            this.pnlRegisterLoginDetails.Name = "pnlRegisterLoginDetails";
            this.pnlRegisterLoginDetails.Size = new System.Drawing.Size(359, 137);
            this.pnlRegisterLoginDetails.TabIndex = 9;
            // 
            // txtRePasswordRegister
            // 
            this.txtRePasswordRegister.BackColor = System.Drawing.Color.White;
            this.txtRePasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRePasswordRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePasswordRegister.ForeColor = System.Drawing.Color.DarkGray;
            this.txtRePasswordRegister.Location = new System.Drawing.Point(185, 100);
            this.txtRePasswordRegister.Name = "txtRePasswordRegister";
            this.txtRePasswordRegister.PasswordChar = '•';
            this.txtRePasswordRegister.Size = new System.Drawing.Size(163, 26);
            this.txtRePasswordRegister.TabIndex = 13;
            this.txtRePasswordRegister.Enter += new System.EventHandler(this.txtRePasswordRegister_Enter);
            this.txtRePasswordRegister.Leave += new System.EventHandler(this.txtRePasswordRegister_Leave);
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
            this.txtPasswordRegister.BackColor = System.Drawing.Color.White;
            this.txtPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordRegister.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPasswordRegister.Location = new System.Drawing.Point(185, 59);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.PasswordChar = '•';
            this.txtPasswordRegister.Size = new System.Drawing.Size(163, 26);
            this.txtPasswordRegister.TabIndex = 9;
            this.txtPasswordRegister.Enter += new System.EventHandler(this.txtPasswordRegister_Enter);
            this.txtPasswordRegister.Leave += new System.EventHandler(this.txtPasswordRegister_Leave);
            // 
            // txtUsernameRegister
            // 
            this.txtUsernameRegister.BackColor = System.Drawing.Color.White;
            this.txtUsernameRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameRegister.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsernameRegister.Location = new System.Drawing.Point(185, 17);
            this.txtUsernameRegister.Name = "txtUsernameRegister";
            this.txtUsernameRegister.Size = new System.Drawing.Size(163, 26);
            this.txtUsernameRegister.TabIndex = 8;
            this.txtUsernameRegister.Enter += new System.EventHandler(this.txtUsernameRegister_Enter);
            this.txtUsernameRegister.Leave += new System.EventHandler(this.txtUsernameRegister_Leave);
            // 
            // pnlSecurityQuestion
            // 
            this.pnlSecurityQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSecurityQuestion.Controls.Add(this.cbxNewSecurityQ);
            this.pnlSecurityQuestion.Controls.Add(this.pnlNewSecurityQA);
            this.pnlSecurityQuestion.Controls.Add(this.lblCurrentQA);
            this.pnlSecurityQuestion.Controls.Add(this.lblCurrentSecurityQA);
            this.pnlSecurityQuestion.Location = new System.Drawing.Point(413, 42);
            this.pnlSecurityQuestion.Name = "pnlSecurityQuestion";
            this.pnlSecurityQuestion.Size = new System.Drawing.Size(359, 209);
            this.pnlSecurityQuestion.TabIndex = 18;
            // 
            // cbxNewSecurityQ
            // 
            this.cbxNewSecurityQ.AutoSize = true;
            this.cbxNewSecurityQ.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxNewSecurityQ.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNewSecurityQ.ForeColor = System.Drawing.Color.White;
            this.cbxNewSecurityQ.Location = new System.Drawing.Point(132, 80);
            this.cbxNewSecurityQ.Name = "cbxNewSecurityQ";
            this.cbxNewSecurityQ.Size = new System.Drawing.Size(222, 21);
            this.cbxNewSecurityQ.TabIndex = 19;
            this.cbxNewSecurityQ.Text = "Choose new Security Question";
            this.cbxNewSecurityQ.UseVisualStyleBackColor = true;
            this.cbxNewSecurityQ.CheckedChanged += new System.EventHandler(this.cbxNewSecurityQ_CheckedChanged);
            // 
            // pnlNewSecurityQA
            // 
            this.pnlNewSecurityQA.Controls.Add(this.lblEnterAnswer);
            this.pnlNewSecurityQA.Controls.Add(this.txtNewSecurityAnswer);
            this.pnlNewSecurityQA.Controls.Add(this.cmbSecurityQuestion);
            this.pnlNewSecurityQA.Location = new System.Drawing.Point(6, 104);
            this.pnlNewSecurityQA.Name = "pnlNewSecurityQA";
            this.pnlNewSecurityQA.Size = new System.Drawing.Size(348, 100);
            this.pnlNewSecurityQA.TabIndex = 18;
            this.pnlNewSecurityQA.Visible = false;
            // 
            // lblEnterAnswer
            // 
            this.lblEnterAnswer.AutoSize = true;
            this.lblEnterAnswer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAnswer.ForeColor = System.Drawing.Color.White;
            this.lblEnterAnswer.Location = new System.Drawing.Point(3, 53);
            this.lblEnterAnswer.Name = "lblEnterAnswer";
            this.lblEnterAnswer.Size = new System.Drawing.Size(109, 20);
            this.lblEnterAnswer.TabIndex = 19;
            this.lblEnterAnswer.Text = "Enter Answer:";
            // 
            // txtNewSecurityAnswer
            // 
            this.txtNewSecurityAnswer.BackColor = System.Drawing.Color.White;
            this.txtNewSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewSecurityAnswer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewSecurityAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtNewSecurityAnswer.Location = new System.Drawing.Point(118, 51);
            this.txtNewSecurityAnswer.Name = "txtNewSecurityAnswer";
            this.txtNewSecurityAnswer.Size = new System.Drawing.Size(227, 26);
            this.txtNewSecurityAnswer.TabIndex = 18;
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurityQuestion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecurityQuestion.FormattingEnabled = true;
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(3, 3);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(342, 28);
            this.cmbSecurityQuestion.TabIndex = 17;
            // 
            // lblCurrentQA
            // 
            this.lblCurrentQA.AutoSize = true;
            this.lblCurrentQA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.lblCurrentQA.Location = new System.Drawing.Point(16, 46);
            this.lblCurrentQA.Name = "lblCurrentQA";
            this.lblCurrentQA.Size = new System.Drawing.Size(0, 20);
            this.lblCurrentQA.TabIndex = 14;
            // 
            // lblCurrentSecurityQA
            // 
            this.lblCurrentSecurityQA.AutoSize = true;
            this.lblCurrentSecurityQA.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSecurityQA.ForeColor = System.Drawing.Color.White;
            this.lblCurrentSecurityQA.Location = new System.Drawing.Point(17, 17);
            this.lblCurrentSecurityQA.Name = "lblCurrentSecurityQA";
            this.lblCurrentSecurityQA.Size = new System.Drawing.Size(294, 18);
            this.lblCurrentSecurityQA.TabIndex = 17;
            this.lblCurrentSecurityQA.Text = "Current Security Question and Answer:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(543, 88);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(93, 34);
            this.btnAddUser.TabIndex = 33;
            this.btnAddUser.Text = "Add New";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 495);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.pnlUpdateUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.pnlHeaderLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditUser";
            this.pnlHeaderLogin.ResumeLayout(false);
            this.pnlHeaderLogin.PerformLayout();
            this.pnlUpdateUser.ResumeLayout(false);
            this.pnlUpdateUser.PerformLayout();
            this.pnlDeleteUser.ResumeLayout(false);
            this.pnlDeleteUser.PerformLayout();
            this.pnlNotificationInfo.ResumeLayout(false);
            this.pnlNotificationInfo.PerformLayout();
            this.pnlLoginDetails.ResumeLayout(false);
            this.pnlLoginDetails.PerformLayout();
            this.pnlCurrentSecurityQuestion.ResumeLayout(false);
            this.pnlCurrentSecurityQuestion.PerformLayout();
            this.pnlNotificationDetails.ResumeLayout(false);
            this.pnlNotificationDetails.PerformLayout();
            this.pnlRegisterLoginDetails.ResumeLayout(false);
            this.pnlRegisterLoginDetails.PerformLayout();
            this.pnlSecurityQuestion.ResumeLayout(false);
            this.pnlSecurityQuestion.PerformLayout();
            this.pnlNewSecurityQA.ResumeLayout(false);
            this.pnlNewSecurityQA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderLogin;
        private System.Windows.Forms.Label lblEditUserHeading;
        private System.Windows.Forms.Button btnCloseEditUser;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlUpdateUser;
        private System.Windows.Forms.Panel pnlRegisterLoginDetails;
        private System.Windows.Forms.TextBox txtRePasswordRegister;
        private System.Windows.Forms.Label lblReEnterPassword;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.Label lblEnterUsername;
        private System.Windows.Forms.TextBox txtPasswordRegister;
        private System.Windows.Forms.TextBox txtUsernameRegister;
        private System.Windows.Forms.Label lblLoginInformation;
        private System.Windows.Forms.Label lblNotificationDetails;
        private System.Windows.Forms.Panel pnlNotificationDetails;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConfirmEmail;
        private System.Windows.Forms.Label lblConfirmEmail;
        private System.Windows.Forms.Label lblEnterEmail;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.Panel pnlSecurityQuestion;
        private System.Windows.Forms.Label lblCurrentQA;
        private System.Windows.Forms.Label lblCurrentSecurityQA;
        private System.Windows.Forms.Panel pnlNewSecurityQA;
        private System.Windows.Forms.Label lblEnterAnswer;
        private System.Windows.Forms.TextBox txtNewSecurityAnswer;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Panel pnlDeleteUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblCurrentSQA;
        private System.Windows.Forms.Label lbNotificationInfo;
        private System.Windows.Forms.Panel pnlNotificationInfo;
        private System.Windows.Forms.TextBox txtEmailDelete;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLoginDetails;
        private System.Windows.Forms.Panel pnlLoginDetails;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlCurrentSecurityQuestion;
        private System.Windows.Forms.Label lblDeleteCurrentSecurityQA;
        private System.Windows.Forms.Label lblCurrentSecQandA;
        private System.Windows.Forms.CheckBox cbxNewSecurityQ;
        private System.Windows.Forms.Button btnAddUser;
    }
}