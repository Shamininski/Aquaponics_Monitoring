namespace AquaponicsMonitoringApp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlHeaderLogin = new System.Windows.Forms.Panel();
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.btnCloseLogin = new System.Windows.Forms.Button();
            this.pnlLogin_Register = new System.Windows.Forms.Panel();
            this.cbxForgotPassword = new System.Windows.Forms.CheckBox();
            this.pnlLoginDetails = new System.Windows.Forms.Panel();
            this.cbxSeePassword = new System.Windows.Forms.CheckBox();
            this.lblEnterLoginDetails = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.btnLOGINform = new System.Windows.Forms.Button();
            this.pnlHeaderLogin.SuspendLayout();
            this.pnlLogin_Register.SuspendLayout();
            this.pnlLoginDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderLogin
            // 
            this.pnlHeaderLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.pnlHeaderLogin.Controls.Add(this.lblLoginHeader);
            this.pnlHeaderLogin.Controls.Add(this.btnCloseLogin);
            this.pnlHeaderLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderLogin.Name = "pnlHeaderLogin";
            this.pnlHeaderLogin.Size = new System.Drawing.Size(486, 58);
            this.pnlHeaderLogin.TabIndex = 4;
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.AutoSize = true;
            this.lblLoginHeader.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeader.ForeColor = System.Drawing.Color.White;
            this.lblLoginHeader.Location = new System.Drawing.Point(7, 15);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(59, 23);
            this.lblLoginHeader.TabIndex = 6;
            this.lblLoginHeader.Text = "Login";
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCloseLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseLogin.BackgroundImage")));
            this.btnCloseLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseLogin.FlatAppearance.BorderSize = 0;
            this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLogin.Location = new System.Drawing.Point(444, 11);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Size = new System.Drawing.Size(39, 39);
            this.btnCloseLogin.TabIndex = 5;
            this.btnCloseLogin.UseVisualStyleBackColor = true;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // pnlLogin_Register
            // 
            this.pnlLogin_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin_Register.Controls.Add(this.cbxForgotPassword);
            this.pnlLogin_Register.Controls.Add(this.pnlLoginDetails);
            this.pnlLogin_Register.Controls.Add(this.btnLOGINform);
            this.pnlLogin_Register.Location = new System.Drawing.Point(63, 93);
            this.pnlLogin_Register.Name = "pnlLogin_Register";
            this.pnlLogin_Register.Size = new System.Drawing.Size(367, 468);
            this.pnlLogin_Register.TabIndex = 5;
            // 
            // cbxForgotPassword
            // 
            this.cbxForgotPassword.AutoSize = true;
            this.cbxForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbxForgotPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxForgotPassword.ForeColor = System.Drawing.Color.White;
            this.cbxForgotPassword.Location = new System.Drawing.Point(196, 382);
            this.cbxForgotPassword.Name = "cbxForgotPassword";
            this.cbxForgotPassword.Size = new System.Drawing.Size(129, 20);
            this.cbxForgotPassword.TabIndex = 3;
            this.cbxForgotPassword.Text = "Forgot Password";
            this.cbxForgotPassword.UseVisualStyleBackColor = false;
            this.cbxForgotPassword.CheckedChanged += new System.EventHandler(this.cbxForgotPassword_CheckedChanged);
            // 
            // pnlLoginDetails
            // 
            this.pnlLoginDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoginDetails.Controls.Add(this.cbxSeePassword);
            this.pnlLoginDetails.Controls.Add(this.lblEnterLoginDetails);
            this.pnlLoginDetails.Controls.Add(this.btnLogin);
            this.pnlLoginDetails.Controls.Add(this.lblPasswordLogin);
            this.pnlLoginDetails.Controls.Add(this.lblUsernameLogin);
            this.pnlLoginDetails.Controls.Add(this.txtPasswordLogin);
            this.pnlLoginDetails.Controls.Add(this.txtUsernameLogin);
            this.pnlLoginDetails.Location = new System.Drawing.Point(0, 133);
            this.pnlLoginDetails.Name = "pnlLoginDetails";
            this.pnlLoginDetails.Size = new System.Drawing.Size(367, 246);
            this.pnlLoginDetails.TabIndex = 2;
            this.pnlLoginDetails.Visible = false;
            // 
            // cbxSeePassword
            // 
            this.cbxSeePassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxSeePassword.AutoSize = true;
            this.cbxSeePassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxSeePassword.FlatAppearance.BorderSize = 0;
            this.cbxSeePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxSeePassword.Image = ((System.Drawing.Image)(resources.GetObject("cbxSeePassword.Image")));
            this.cbxSeePassword.Location = new System.Drawing.Point(328, 127);
            this.cbxSeePassword.Name = "cbxSeePassword";
            this.cbxSeePassword.Size = new System.Drawing.Size(29, 29);
            this.cbxSeePassword.TabIndex = 6;
            this.cbxSeePassword.UseVisualStyleBackColor = true;
            this.cbxSeePassword.CheckedChanged += new System.EventHandler(this.cbxSeePassword_CheckedChanged);
            // 
            // lblEnterLoginDetails
            // 
            this.lblEnterLoginDetails.AutoSize = true;
            this.lblEnterLoginDetails.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterLoginDetails.ForeColor = System.Drawing.Color.White;
            this.lblEnterLoginDetails.Location = new System.Drawing.Point(25, 26);
            this.lblEnterLoginDetails.Name = "lblEnterLoginDetails";
            this.lblEnterLoginDetails.Size = new System.Drawing.Size(148, 18);
            this.lblEnterLoginDetails.TabIndex = 5;
            this.lblEnterLoginDetails.Text = "Enter Login Details:";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(167, 191);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(158, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.lblPasswordLogin.Location = new System.Drawing.Point(32, 130);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(86, 21);
            this.lblPasswordLogin.TabIndex = 3;
            this.lblPasswordLogin.Text = "Password:";
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameLogin.ForeColor = System.Drawing.Color.White;
            this.lblUsernameLogin.Location = new System.Drawing.Point(32, 70);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(92, 21);
            this.lblUsernameLogin.TabIndex = 2;
            this.lblUsernameLogin.Text = "Username:";
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.txtPasswordLogin.Location = new System.Drawing.Point(162, 128);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '•';
            this.txtPasswordLogin.Size = new System.Drawing.Size(163, 27);
            this.txtPasswordLogin.TabIndex = 1;
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.txtUsernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameLogin.ForeColor = System.Drawing.Color.White;
            this.txtUsernameLogin.Location = new System.Drawing.Point(162, 68);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(163, 27);
            this.txtUsernameLogin.TabIndex = 0;
            // 
            // btnLOGINform
            // 
            this.btnLOGINform.BackColor = System.Drawing.Color.Transparent;
            this.btnLOGINform.FlatAppearance.BorderSize = 0;
            this.btnLOGINform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLOGINform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOGINform.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGINform.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLOGINform.Image = ((System.Drawing.Image)(resources.GetObject("btnLOGINform.Image")));
            this.btnLOGINform.Location = new System.Drawing.Point(27, 15);
            this.btnLOGINform.Name = "btnLOGINform";
            this.btnLOGINform.Size = new System.Drawing.Size(107, 38);
            this.btnLOGINform.TabIndex = 0;
            this.btnLOGINform.Text = " LOGIN";
            this.btnLOGINform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLOGINform.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(486, 594);
            this.Controls.Add(this.pnlLogin_Register);
            this.Controls.Add(this.pnlHeaderLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.pnlHeaderLogin.ResumeLayout(false);
            this.pnlHeaderLogin.PerformLayout();
            this.pnlLogin_Register.ResumeLayout(false);
            this.pnlLogin_Register.PerformLayout();
            this.pnlLoginDetails.ResumeLayout(false);
            this.pnlLoginDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeaderLogin;
        private System.Windows.Forms.Button btnCloseLogin;
        private System.Windows.Forms.Panel pnlLogin_Register;
        private System.Windows.Forms.Button btnLOGINform;
        private System.Windows.Forms.Panel pnlLoginDetails;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Label lblEnterLoginDetails;
        private System.Windows.Forms.Label lblLoginHeader;
        private System.Windows.Forms.CheckBox cbxForgotPassword;
        private System.Windows.Forms.CheckBox cbxSeePassword;
    }
}