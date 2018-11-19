namespace AquaponicsMonitoringApp
{
    partial class frmEditSensor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditSensor));
            this.pnlHeaderLogin = new System.Windows.Forms.Panel();
            this.lblEditSensorHeading = new System.Windows.Forms.Label();
            this.btnCloseEditSensor = new System.Windows.Forms.Button();
            this.cmbTanks = new System.Windows.Forms.ComboBox();
            this.pnlDeleteSensor = new System.Windows.Forms.Panel();
            this.pnlDeleteThisSensor = new System.Windows.Forms.Panel();
            this.btnDeleteSensor = new System.Windows.Forms.Button();
            this.lblDeleteThisEmail = new System.Windows.Forms.Label();
            this.txtDeleteEmail = new System.Windows.Forms.TextBox();
            this.cmbSensorsToDelete = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlUpdateSensor = new System.Windows.Forms.Panel();
            this.pnlUpdateCriticalRanges = new System.Windows.Forms.Panel();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.btnUpdateSensor = new System.Windows.Forms.Button();
            this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
            this.lblSetPhCriticalRange = new System.Windows.Forms.Label();
            this.nudMinValue = new System.Windows.Forms.NumericUpDown();
            this.cmbSensorsToUpdate = new System.Windows.Forms.ComboBox();
            this.pnlHeaderLogin.SuspendLayout();
            this.pnlDeleteSensor.SuspendLayout();
            this.pnlDeleteThisSensor.SuspendLayout();
            this.pnlUpdateSensor.SuspendLayout();
            this.pnlUpdateCriticalRanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderLogin
            // 
            this.pnlHeaderLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(55)))));
            this.pnlHeaderLogin.Controls.Add(this.lblEditSensorHeading);
            this.pnlHeaderLogin.Controls.Add(this.btnCloseEditSensor);
            this.pnlHeaderLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderLogin.Name = "pnlHeaderLogin";
            this.pnlHeaderLogin.Size = new System.Drawing.Size(666, 58);
            this.pnlHeaderLogin.TabIndex = 5;
            // 
            // lblEditSensorHeading
            // 
            this.lblEditSensorHeading.AutoSize = true;
            this.lblEditSensorHeading.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSensorHeading.ForeColor = System.Drawing.Color.White;
            this.lblEditSensorHeading.Location = new System.Drawing.Point(24, 16);
            this.lblEditSensorHeading.Name = "lblEditSensorHeading";
            this.lblEditSensorHeading.Size = new System.Drawing.Size(108, 23);
            this.lblEditSensorHeading.TabIndex = 6;
            this.lblEditSensorHeading.Text = "Edit Sensor";
            // 
            // btnCloseEditSensor
            // 
            this.btnCloseEditSensor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCloseEditSensor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseEditSensor.BackgroundImage")));
            this.btnCloseEditSensor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseEditSensor.FlatAppearance.BorderSize = 0;
            this.btnCloseEditSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEditSensor.Location = new System.Drawing.Point(624, 11);
            this.btnCloseEditSensor.Name = "btnCloseEditSensor";
            this.btnCloseEditSensor.Size = new System.Drawing.Size(39, 39);
            this.btnCloseEditSensor.TabIndex = 5;
            this.btnCloseEditSensor.UseVisualStyleBackColor = true;
            this.btnCloseEditSensor.Click += new System.EventHandler(this.btnCloseEditSensor_Click);
            // 
            // cmbTanks
            // 
            this.cmbTanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTanks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTanks.FormattingEnabled = true;
            this.cmbTanks.Location = new System.Drawing.Point(28, 79);
            this.cmbTanks.Name = "cmbTanks";
            this.cmbTanks.Size = new System.Drawing.Size(174, 29);
            this.cmbTanks.TabIndex = 23;
            this.cmbTanks.SelectedIndexChanged += new System.EventHandler(this.cmbTanks_SelectedIndexChanged);
            // 
            // pnlDeleteSensor
            // 
            this.pnlDeleteSensor.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeleteSensor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteSensor.Controls.Add(this.pnlDeleteThisSensor);
            this.pnlDeleteSensor.Controls.Add(this.cmbSensorsToDelete);
            this.pnlDeleteSensor.Location = new System.Drawing.Point(247, 145);
            this.pnlDeleteSensor.Name = "pnlDeleteSensor";
            this.pnlDeleteSensor.Size = new System.Drawing.Size(397, 185);
            this.pnlDeleteSensor.TabIndex = 25;
            this.pnlDeleteSensor.Visible = false;
            // 
            // pnlDeleteThisSensor
            // 
            this.pnlDeleteThisSensor.Controls.Add(this.btnDeleteSensor);
            this.pnlDeleteThisSensor.Controls.Add(this.lblDeleteThisEmail);
            this.pnlDeleteThisSensor.Controls.Add(this.txtDeleteEmail);
            this.pnlDeleteThisSensor.Location = new System.Drawing.Point(3, 70);
            this.pnlDeleteThisSensor.Name = "pnlDeleteThisSensor";
            this.pnlDeleteThisSensor.Size = new System.Drawing.Size(389, 110);
            this.pnlDeleteThisSensor.TabIndex = 4;
            // 
            // btnDeleteSensor
            // 
            this.btnDeleteSensor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDeleteSensor.FlatAppearance.BorderSize = 0;
            this.btnDeleteSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSensor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSensor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSensor.Location = new System.Drawing.Point(248, 67);
            this.btnDeleteSensor.Name = "btnDeleteSensor";
            this.btnDeleteSensor.Size = new System.Drawing.Size(134, 28);
            this.btnDeleteSensor.TabIndex = 22;
            this.btnDeleteSensor.Text = "Delete Sensor";
            this.btnDeleteSensor.UseVisualStyleBackColor = false;
            this.btnDeleteSensor.Click += new System.EventHandler(this.btnDeleteSensor_Click);
            // 
            // lblDeleteThisEmail
            // 
            this.lblDeleteThisEmail.AutoSize = true;
            this.lblDeleteThisEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteThisEmail.ForeColor = System.Drawing.Color.White;
            this.lblDeleteThisEmail.Location = new System.Drawing.Point(11, 7);
            this.lblDeleteThisEmail.Name = "lblDeleteThisEmail";
            this.lblDeleteThisEmail.Size = new System.Drawing.Size(149, 21);
            this.lblDeleteThisEmail.TabIndex = 5;
            this.lblDeleteThisEmail.Text = "Delete this Sensor:";
            // 
            // txtDeleteEmail
            // 
            this.txtDeleteEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteEmail.Location = new System.Drawing.Point(159, 5);
            this.txtDeleteEmail.Name = "txtDeleteEmail";
            this.txtDeleteEmail.ReadOnly = true;
            this.txtDeleteEmail.Size = new System.Drawing.Size(223, 26);
            this.txtDeleteEmail.TabIndex = 4;
            // 
            // cmbSensorsToDelete
            // 
            this.cmbSensorsToDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensorsToDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSensorsToDelete.FormattingEnabled = true;
            this.cmbSensorsToDelete.Location = new System.Drawing.Point(16, 25);
            this.cmbSensorsToDelete.Name = "cmbSensorsToDelete";
            this.cmbSensorsToDelete.Size = new System.Drawing.Size(224, 29);
            this.cmbSensorsToDelete.TabIndex = 3;
            this.cmbSensorsToDelete.SelectedIndexChanged += new System.EventHandler(this.cmbSensorsToDelete_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(247, 105);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 34);
            this.btnUpdate.TabIndex = 26;
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
            this.btnDelete.Location = new System.Drawing.Point(350, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 34);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlUpdateSensor
            // 
            this.pnlUpdateSensor.BackColor = System.Drawing.Color.Transparent;
            this.pnlUpdateSensor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateSensor.Controls.Add(this.pnlUpdateCriticalRanges);
            this.pnlUpdateSensor.Controls.Add(this.cmbSensorsToUpdate);
            this.pnlUpdateSensor.Location = new System.Drawing.Point(247, 144);
            this.pnlUpdateSensor.Name = "pnlUpdateSensor";
            this.pnlUpdateSensor.Size = new System.Drawing.Size(397, 214);
            this.pnlUpdateSensor.TabIndex = 28;
            this.pnlUpdateSensor.Visible = false;
            // 
            // pnlUpdateCriticalRanges
            // 
            this.pnlUpdateCriticalRanges.Controls.Add(this.lblMaxValue);
            this.pnlUpdateCriticalRanges.Controls.Add(this.lblMinValue);
            this.pnlUpdateCriticalRanges.Controls.Add(this.btnUpdateSensor);
            this.pnlUpdateCriticalRanges.Controls.Add(this.nudMaxValue);
            this.pnlUpdateCriticalRanges.Controls.Add(this.lblSetPhCriticalRange);
            this.pnlUpdateCriticalRanges.Controls.Add(this.nudMinValue);
            this.pnlUpdateCriticalRanges.Location = new System.Drawing.Point(3, 70);
            this.pnlUpdateCriticalRanges.Name = "pnlUpdateCriticalRanges";
            this.pnlUpdateCriticalRanges.Size = new System.Drawing.Size(389, 139);
            this.pnlUpdateCriticalRanges.TabIndex = 4;
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxValue.ForeColor = System.Drawing.Color.White;
            this.lblMaxValue.Location = new System.Drawing.Point(232, 42);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(129, 18);
            this.lblMaxValue.TabIndex = 27;
            this.lblMaxValue.Text = "Maximum value:";
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinValue.ForeColor = System.Drawing.Color.White;
            this.lblMinValue.Location = new System.Drawing.Point(11, 42);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(124, 18);
            this.lblMinValue.TabIndex = 26;
            this.lblMinValue.Text = "Minimum value:";
            // 
            // btnUpdateSensor
            // 
            this.btnUpdateSensor.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdateSensor.FlatAppearance.BorderSize = 0;
            this.btnUpdateSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSensor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSensor.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSensor.Location = new System.Drawing.Point(248, 102);
            this.btnUpdateSensor.Name = "btnUpdateSensor";
            this.btnUpdateSensor.Size = new System.Drawing.Size(134, 28);
            this.btnUpdateSensor.TabIndex = 22;
            this.btnUpdateSensor.Text = "Update Sensor";
            this.btnUpdateSensor.UseVisualStyleBackColor = false;
            this.btnUpdateSensor.Click += new System.EventHandler(this.btnUpdateSensor_Click_1);
            // 
            // nudMaxValue
            // 
            this.nudMaxValue.DecimalPlaces = 1;
            this.nudMaxValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMaxValue.Location = new System.Drawing.Point(235, 63);
            this.nudMaxValue.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudMaxValue.Name = "nudMaxValue";
            this.nudMaxValue.Size = new System.Drawing.Size(125, 27);
            this.nudMaxValue.TabIndex = 24;
            // 
            // lblSetPhCriticalRange
            // 
            this.lblSetPhCriticalRange.AutoSize = true;
            this.lblSetPhCriticalRange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPhCriticalRange.ForeColor = System.Drawing.Color.White;
            this.lblSetPhCriticalRange.Location = new System.Drawing.Point(11, 11);
            this.lblSetPhCriticalRange.Name = "lblSetPhCriticalRange";
            this.lblSetPhCriticalRange.Size = new System.Drawing.Size(266, 21);
            this.lblSetPhCriticalRange.TabIndex = 25;
            this.lblSetPhCriticalRange.Text = "Set the Critical Range for Sensor: ";
            // 
            // nudMinValue
            // 
            this.nudMinValue.DecimalPlaces = 1;
            this.nudMinValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMinValue.Location = new System.Drawing.Point(14, 63);
            this.nudMinValue.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudMinValue.Name = "nudMinValue";
            this.nudMinValue.Size = new System.Drawing.Size(124, 27);
            this.nudMinValue.TabIndex = 23;
            // 
            // cmbSensorsToUpdate
            // 
            this.cmbSensorsToUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensorsToUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSensorsToUpdate.FormattingEnabled = true;
            this.cmbSensorsToUpdate.Location = new System.Drawing.Point(16, 25);
            this.cmbSensorsToUpdate.Name = "cmbSensorsToUpdate";
            this.cmbSensorsToUpdate.Size = new System.Drawing.Size(224, 29);
            this.cmbSensorsToUpdate.TabIndex = 3;
            this.cmbSensorsToUpdate.SelectedIndexChanged += new System.EventHandler(this.cmbSensorsToUpdate_SelectedIndexChanged);
            // 
            // frmEditSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(666, 370);
            this.Controls.Add(this.pnlUpdateSensor);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlDeleteSensor);
            this.Controls.Add(this.cmbTanks);
            this.Controls.Add(this.pnlHeaderLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditSensor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditSensor";
            this.pnlHeaderLogin.ResumeLayout(false);
            this.pnlHeaderLogin.PerformLayout();
            this.pnlDeleteSensor.ResumeLayout(false);
            this.pnlDeleteThisSensor.ResumeLayout(false);
            this.pnlDeleteThisSensor.PerformLayout();
            this.pnlUpdateSensor.ResumeLayout(false);
            this.pnlUpdateCriticalRanges.ResumeLayout(false);
            this.pnlUpdateCriticalRanges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderLogin;
        private System.Windows.Forms.Label lblEditSensorHeading;
        private System.Windows.Forms.Button btnCloseEditSensor;
        private System.Windows.Forms.ComboBox cmbTanks;
        private System.Windows.Forms.Panel pnlDeleteSensor;
        private System.Windows.Forms.Panel pnlDeleteThisSensor;
        private System.Windows.Forms.Button btnDeleteSensor;
        private System.Windows.Forms.Label lblDeleteThisEmail;
        private System.Windows.Forms.TextBox txtDeleteEmail;
        private System.Windows.Forms.ComboBox cmbSensorsToDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlUpdateSensor;
        private System.Windows.Forms.Panel pnlUpdateCriticalRanges;
        private System.Windows.Forms.Button btnUpdateSensor;
        private System.Windows.Forms.ComboBox cmbSensorsToUpdate;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.NumericUpDown nudMaxValue;
        private System.Windows.Forms.Label lblSetPhCriticalRange;
        private System.Windows.Forms.NumericUpDown nudMinValue;
    }
}