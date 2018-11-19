namespace AquaponicsMonitoringApp
{
    partial class frmSettingsMainDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingsMainDash));
            this.pnlMainDashLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDashSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.btnNotificationSettings = new System.Windows.Forms.Button();
            this.btnAddSensor = new System.Windows.Forms.Button();
            this.btnEditSensor = new System.Windows.Forms.Button();
            this.pnlDashContext = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSensorInfo = new System.Windows.Forms.Button();
            this.gbxSensorLocation = new System.Windows.Forms.GroupBox();
            this.pnlExistingTank = new System.Windows.Forms.Panel();
            this.cbxChooseNewTank = new System.Windows.Forms.CheckBox();
            this.cmbExistingTanks = new System.Windows.Forms.ComboBox();
            this.lblChooseExistingTank = new System.Windows.Forms.Label();
            this.cbxExistingTank = new System.Windows.Forms.CheckBox();
            this.txtTankName = new System.Windows.Forms.TextBox();
            this.lblTankName = new System.Windows.Forms.Label();
            this.gbxCriticalRange = new System.Windows.Forms.GroupBox();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlPhCriticalRange = new System.Windows.Forms.Panel();
            this.lblMaxPH = new System.Windows.Forms.Label();
            this.lblMinPH = new System.Windows.Forms.Label();
            this.lblSetPhCriticalRange = new System.Windows.Forms.Label();
            this.nudMaxPH = new System.Windows.Forms.NumericUpDown();
            this.nudMinPH = new System.Windows.Forms.NumericUpDown();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblSetTempCriticalRanges = new System.Windows.Forms.Label();
            this.nudMaxTemp = new System.Windows.Forms.NumericUpDown();
            this.nudMinTemp = new System.Windows.Forms.NumericUpDown();
            this.gbxSensorInfo = new System.Windows.Forms.GroupBox();
            this.cmbSensorType = new System.Windows.Forms.ComboBox();
            this.txtSensorName = new System.Windows.Forms.TextBox();
            this.lblChooseSensorType = new System.Windows.Forms.Label();
            this.lblEnterSensorName = new System.Windows.Forms.Label();
            this.lblSystemSettings = new System.Windows.Forms.Label();
            this.lblDashDivider = new System.Windows.Forms.Label();
            this.lblDashSubHeader = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeaderMainDash = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pnlMainDashLayout.SuspendLayout();
            this.pnlDashSideMenu.SuspendLayout();
            this.pnlDashContext.SuspendLayout();
            this.gbxSensorLocation.SuspendLayout();
            this.pnlExistingTank.SuspendLayout();
            this.gbxCriticalRange.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            this.pnlPhCriticalRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTemp)).BeginInit();
            this.gbxSensorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlHeaderMainDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainDashLayout
            // 
            this.pnlMainDashLayout.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainDashLayout.ColumnCount = 2;
            this.pnlMainDashLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.1117F));
            this.pnlMainDashLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.88831F));
            this.pnlMainDashLayout.Controls.Add(this.pnlDashSideMenu, 0, 1);
            this.pnlMainDashLayout.Controls.Add(this.pnlDashContext, 1, 1);
            this.pnlMainDashLayout.Controls.Add(this.imgLogo, 0, 0);
            this.pnlMainDashLayout.Controls.Add(this.pnlHeaderMainDash, 1, 0);
            this.pnlMainDashLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainDashLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlMainDashLayout.Name = "pnlMainDashLayout";
            this.pnlMainDashLayout.RowCount = 2;
            this.pnlMainDashLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.771574F));
            this.pnlMainDashLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.22842F));
            this.pnlMainDashLayout.Size = new System.Drawing.Size(1386, 788);
            this.pnlMainDashLayout.TabIndex = 1;
            // 
            // pnlDashSideMenu
            // 
            this.pnlDashSideMenu.Controls.Add(this.btnLogout);
            this.pnlDashSideMenu.Controls.Add(this.btnUserSettings);
            this.pnlDashSideMenu.Controls.Add(this.btnNotificationSettings);
            this.pnlDashSideMenu.Controls.Add(this.btnAddSensor);
            this.pnlDashSideMenu.Controls.Add(this.btnEditSensor);
            this.pnlDashSideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashSideMenu.Location = new System.Drawing.Point(3, 80);
            this.pnlDashSideMenu.Name = "pnlDashSideMenu";
            this.pnlDashSideMenu.Size = new System.Drawing.Size(203, 705);
            this.pnlDashSideMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 233);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(201, 41);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "   Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserSettings.FlatAppearance.BorderSize = 0;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUserSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSettings.Image")));
            this.btnUserSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSettings.Location = new System.Drawing.Point(2, 186);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(201, 41);
            this.btnUserSettings.TabIndex = 4;
            this.btnUserSettings.Text = "   User Settings";
            this.btnUserSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserSettings.UseVisualStyleBackColor = true;
            this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
            // 
            // btnNotificationSettings
            // 
            this.btnNotificationSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotificationSettings.FlatAppearance.BorderSize = 0;
            this.btnNotificationSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificationSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificationSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNotificationSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnNotificationSettings.Image")));
            this.btnNotificationSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificationSettings.Location = new System.Drawing.Point(2, 139);
            this.btnNotificationSettings.Name = "btnNotificationSettings";
            this.btnNotificationSettings.Size = new System.Drawing.Size(201, 41);
            this.btnNotificationSettings.TabIndex = 3;
            this.btnNotificationSettings.Text = "   Notification Settings";
            this.btnNotificationSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificationSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotificationSettings.UseVisualStyleBackColor = true;
            this.btnNotificationSettings.Click += new System.EventHandler(this.btnNotificationSettings_Click);
            // 
            // btnAddSensor
            // 
            this.btnAddSensor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSensor.FlatAppearance.BorderSize = 0;
            this.btnAddSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSensor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSensor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddSensor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSensor.Image")));
            this.btnAddSensor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSensor.Location = new System.Drawing.Point(3, 51);
            this.btnAddSensor.Name = "btnAddSensor";
            this.btnAddSensor.Size = new System.Drawing.Size(201, 41);
            this.btnAddSensor.TabIndex = 2;
            this.btnAddSensor.Text = "   Add Sensor";
            this.btnAddSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSensor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSensor.UseVisualStyleBackColor = true;
            this.btnAddSensor.Click += new System.EventHandler(this.btnAddSensor_Click);
            // 
            // btnEditSensor
            // 
            this.btnEditSensor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSensor.FlatAppearance.BorderSize = 0;
            this.btnEditSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSensor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSensor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditSensor.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSensor.Image")));
            this.btnEditSensor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSensor.Location = new System.Drawing.Point(3, 92);
            this.btnEditSensor.Name = "btnEditSensor";
            this.btnEditSensor.Size = new System.Drawing.Size(201, 41);
            this.btnEditSensor.TabIndex = 1;
            this.btnEditSensor.Text = "   Edit Sensor";
            this.btnEditSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSensor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditSensor.UseVisualStyleBackColor = true;
            this.btnEditSensor.Click += new System.EventHandler(this.btnEditSensor_Click);
            // 
            // pnlDashContext
            // 
            this.pnlDashContext.BackColor = System.Drawing.Color.Transparent;
            this.pnlDashContext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDashContext.BackgroundImage")));
            this.pnlDashContext.Controls.Add(this.label1);
            this.pnlDashContext.Controls.Add(this.btnAddSensorInfo);
            this.pnlDashContext.Controls.Add(this.gbxSensorLocation);
            this.pnlDashContext.Controls.Add(this.gbxCriticalRange);
            this.pnlDashContext.Controls.Add(this.gbxSensorInfo);
            this.pnlDashContext.Controls.Add(this.lblSystemSettings);
            this.pnlDashContext.Controls.Add(this.lblDashDivider);
            this.pnlDashContext.Controls.Add(this.lblDashSubHeader);
            this.pnlDashContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashContext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDashContext.ForeColor = System.Drawing.Color.White;
            this.pnlDashContext.Location = new System.Drawing.Point(212, 80);
            this.pnlDashContext.Name = "pnlDashContext";
            this.pnlDashContext.Size = new System.Drawing.Size(1171, 705);
            this.pnlDashContext.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(42, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "ADD NEW SENSOR";
            // 
            // btnAddSensorInfo
            // 
            this.btnAddSensorInfo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddSensorInfo.Location = new System.Drawing.Point(502, 621);
            this.btnAddSensorInfo.Name = "btnAddSensorInfo";
            this.btnAddSensorInfo.Size = new System.Drawing.Size(131, 34);
            this.btnAddSensorInfo.TabIndex = 10;
            this.btnAddSensorInfo.Text = "Add Sensor";
            this.btnAddSensorInfo.UseVisualStyleBackColor = false;
            this.btnAddSensorInfo.Click += new System.EventHandler(this.btnAddSensorInfo_Click);
            // 
            // gbxSensorLocation
            // 
            this.gbxSensorLocation.Controls.Add(this.pnlExistingTank);
            this.gbxSensorLocation.Controls.Add(this.cbxExistingTank);
            this.gbxSensorLocation.Controls.Add(this.txtTankName);
            this.gbxSensorLocation.Controls.Add(this.lblTankName);
            this.gbxSensorLocation.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSensorLocation.ForeColor = System.Drawing.Color.White;
            this.gbxSensorLocation.Location = new System.Drawing.Point(308, 480);
            this.gbxSensorLocation.Name = "gbxSensorLocation";
            this.gbxSensorLocation.Size = new System.Drawing.Size(513, 135);
            this.gbxSensorLocation.TabIndex = 9;
            this.gbxSensorLocation.TabStop = false;
            this.gbxSensorLocation.Text = "Location of Sensor";
            // 
            // pnlExistingTank
            // 
            this.pnlExistingTank.Controls.Add(this.cbxChooseNewTank);
            this.pnlExistingTank.Controls.Add(this.cmbExistingTanks);
            this.pnlExistingTank.Controls.Add(this.lblChooseExistingTank);
            this.pnlExistingTank.Location = new System.Drawing.Point(0, 30);
            this.pnlExistingTank.Name = "pnlExistingTank";
            this.pnlExistingTank.Size = new System.Drawing.Size(540, 83);
            this.pnlExistingTank.TabIndex = 6;
            this.pnlExistingTank.Visible = false;
            // 
            // cbxChooseNewTank
            // 
            this.cbxChooseNewTank.AutoSize = true;
            this.cbxChooseNewTank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChooseNewTank.Location = new System.Drawing.Point(254, 48);
            this.cbxChooseNewTank.Name = "cbxChooseNewTank";
            this.cbxChooseNewTank.Size = new System.Drawing.Size(155, 24);
            this.cbxChooseNewTank.TabIndex = 7;
            this.cbxChooseNewTank.Text = "Create New Tank";
            this.cbxChooseNewTank.UseVisualStyleBackColor = true;
            this.cbxChooseNewTank.CheckedChanged += new System.EventHandler(this.cbxChooseNewTank_CheckedChanged);
            // 
            // cmbExistingTanks
            // 
            this.cmbExistingTanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExistingTanks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExistingTanks.FormattingEnabled = true;
            this.cmbExistingTanks.Location = new System.Drawing.Point(248, 5);
            this.cmbExistingTanks.Name = "cmbExistingTanks";
            this.cmbExistingTanks.Size = new System.Drawing.Size(205, 29);
            this.cmbExistingTanks.TabIndex = 5;
            // 
            // lblChooseExistingTank
            // 
            this.lblChooseExistingTank.AutoSize = true;
            this.lblChooseExistingTank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseExistingTank.Location = new System.Drawing.Point(48, 8);
            this.lblChooseExistingTank.Name = "lblChooseExistingTank";
            this.lblChooseExistingTank.Size = new System.Drawing.Size(175, 21);
            this.lblChooseExistingTank.TabIndex = 3;
            this.lblChooseExistingTank.Text = "Choose Existing Tank:";
            // 
            // cbxExistingTank
            // 
            this.cbxExistingTank.AutoSize = true;
            this.cbxExistingTank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxExistingTank.Location = new System.Drawing.Point(254, 83);
            this.cbxExistingTank.Name = "cbxExistingTank";
            this.cbxExistingTank.Size = new System.Drawing.Size(176, 24);
            this.cbxExistingTank.TabIndex = 3;
            this.cbxExistingTank.Text = "Choose Existing Tank";
            this.cbxExistingTank.UseVisualStyleBackColor = true;
            this.cbxExistingTank.CheckedChanged += new System.EventHandler(this.cbxExistingTank_CheckedChanged);
            // 
            // txtTankName
            // 
            this.txtTankName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTankName.Location = new System.Drawing.Point(254, 39);
            this.txtTankName.Name = "txtTankName";
            this.txtTankName.Size = new System.Drawing.Size(205, 27);
            this.txtTankName.TabIndex = 2;
            // 
            // lblTankName
            // 
            this.lblTankName.AutoSize = true;
            this.lblTankName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTankName.Location = new System.Drawing.Point(54, 42);
            this.lblTankName.Name = "lblTankName";
            this.lblTankName.Size = new System.Drawing.Size(148, 21);
            this.lblTankName.TabIndex = 0;
            this.lblTankName.Text = "Enter Tank Name:";
            // 
            // gbxCriticalRange
            // 
            this.gbxCriticalRange.Controls.Add(this.pnlMessage);
            this.gbxCriticalRange.Controls.Add(this.pnlPhCriticalRange);
            this.gbxCriticalRange.Controls.Add(this.lblMaxTemp);
            this.gbxCriticalRange.Controls.Add(this.lblMinTemp);
            this.gbxCriticalRange.Controls.Add(this.lblSetTempCriticalRanges);
            this.gbxCriticalRange.Controls.Add(this.nudMaxTemp);
            this.gbxCriticalRange.Controls.Add(this.nudMinTemp);
            this.gbxCriticalRange.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCriticalRange.ForeColor = System.Drawing.Color.White;
            this.gbxCriticalRange.Location = new System.Drawing.Point(308, 314);
            this.gbxCriticalRange.Name = "gbxCriticalRange";
            this.gbxCriticalRange.Size = new System.Drawing.Size(513, 151);
            this.gbxCriticalRange.TabIndex = 7;
            this.gbxCriticalRange.TabStop = false;
            this.gbxCriticalRange.Text = "Critical Range ";
            // 
            // pnlMessage
            // 
            this.pnlMessage.Controls.Add(this.lblMessage);
            this.pnlMessage.Location = new System.Drawing.Point(20, 18);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(473, 136);
            this.pnlMessage.TabIndex = 10;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMessage.Location = new System.Drawing.Point(120, 55);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(250, 23);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Choose a Sensor Type First";
            // 
            // pnlPhCriticalRange
            // 
            this.pnlPhCriticalRange.Controls.Add(this.lblMaxPH);
            this.pnlPhCriticalRange.Controls.Add(this.lblMinPH);
            this.pnlPhCriticalRange.Controls.Add(this.lblSetPhCriticalRange);
            this.pnlPhCriticalRange.Controls.Add(this.nudMaxPH);
            this.pnlPhCriticalRange.Controls.Add(this.nudMinPH);
            this.pnlPhCriticalRange.Location = new System.Drawing.Point(37, 15);
            this.pnlPhCriticalRange.Name = "pnlPhCriticalRange";
            this.pnlPhCriticalRange.Size = new System.Drawing.Size(443, 145);
            this.pnlPhCriticalRange.TabIndex = 10;
            this.pnlPhCriticalRange.Visible = false;
            // 
            // lblMaxPH
            // 
            this.lblMaxPH.AutoSize = true;
            this.lblMaxPH.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPH.Location = new System.Drawing.Point(232, 64);
            this.lblMaxPH.Name = "lblMaxPH";
            this.lblMaxPH.Size = new System.Drawing.Size(109, 18);
            this.lblMaxPH.TabIndex = 11;
            this.lblMaxPH.Text = "Maximum pH:";
            // 
            // lblMinPH
            // 
            this.lblMinPH.AutoSize = true;
            this.lblMinPH.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPH.Location = new System.Drawing.Point(11, 64);
            this.lblMinPH.Name = "lblMinPH";
            this.lblMinPH.Size = new System.Drawing.Size(104, 18);
            this.lblMinPH.TabIndex = 10;
            this.lblMinPH.Text = "Minimum pH:";
            // 
            // lblSetPhCriticalRange
            // 
            this.lblSetPhCriticalRange.AutoSize = true;
            this.lblSetPhCriticalRange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPhCriticalRange.Location = new System.Drawing.Point(11, 33);
            this.lblSetPhCriticalRange.Name = "lblSetPhCriticalRange";
            this.lblSetPhCriticalRange.Size = new System.Drawing.Size(292, 21);
            this.lblSetPhCriticalRange.TabIndex = 9;
            this.lblSetPhCriticalRange.Text = "Set the Critical Range for pH Sensor: ";
            // 
            // nudMaxPH
            // 
            this.nudMaxPH.DecimalPlaces = 1;
            this.nudMaxPH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxPH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMaxPH.Location = new System.Drawing.Point(235, 85);
            this.nudMaxPH.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nudMaxPH.Name = "nudMaxPH";
            this.nudMaxPH.Size = new System.Drawing.Size(187, 27);
            this.nudMaxPH.TabIndex = 8;
            // 
            // nudMinPH
            // 
            this.nudMinPH.DecimalPlaces = 1;
            this.nudMinPH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinPH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMinPH.Location = new System.Drawing.Point(14, 85);
            this.nudMinPH.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nudMinPH.Name = "nudMinPH";
            this.nudMinPH.Size = new System.Drawing.Size(187, 27);
            this.nudMinPH.TabIndex = 7;
            this.nudMinPH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(269, 74);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(183, 18);
            this.lblMaxTemp.TabIndex = 6;
            this.lblMaxTemp.Text = "Maximum Temperature:";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(48, 74);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(178, 18);
            this.lblMinTemp.TabIndex = 5;
            this.lblMinTemp.Text = "Minimum Temperature:";
            // 
            // lblSetTempCriticalRanges
            // 
            this.lblSetTempCriticalRanges.AutoSize = true;
            this.lblSetTempCriticalRanges.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTempCriticalRanges.Location = new System.Drawing.Point(48, 43);
            this.lblSetTempCriticalRanges.Name = "lblSetTempCriticalRanges";
            this.lblSetTempCriticalRanges.Size = new System.Drawing.Size(420, 21);
            this.lblSetTempCriticalRanges.TabIndex = 4;
            this.lblSetTempCriticalRanges.Text = "Set the Critical Range for Temperature Sensor (in °C):";
            // 
            // nudMaxTemp
            // 
            this.nudMaxTemp.DecimalPlaces = 1;
            this.nudMaxTemp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxTemp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMaxTemp.Location = new System.Drawing.Point(272, 95);
            this.nudMaxTemp.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudMaxTemp.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxTemp.Name = "nudMaxTemp";
            this.nudMaxTemp.Size = new System.Drawing.Size(187, 27);
            this.nudMaxTemp.TabIndex = 1;
            this.nudMaxTemp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudMinTemp
            // 
            this.nudMinTemp.DecimalPlaces = 1;
            this.nudMinTemp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinTemp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMinTemp.Location = new System.Drawing.Point(51, 95);
            this.nudMinTemp.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudMinTemp.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinTemp.Name = "nudMinTemp";
            this.nudMinTemp.Size = new System.Drawing.Size(187, 27);
            this.nudMinTemp.TabIndex = 0;
            this.nudMinTemp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // gbxSensorInfo
            // 
            this.gbxSensorInfo.Controls.Add(this.cmbSensorType);
            this.gbxSensorInfo.Controls.Add(this.txtSensorName);
            this.gbxSensorInfo.Controls.Add(this.lblChooseSensorType);
            this.gbxSensorInfo.Controls.Add(this.lblEnterSensorName);
            this.gbxSensorInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSensorInfo.ForeColor = System.Drawing.Color.White;
            this.gbxSensorInfo.Location = new System.Drawing.Point(308, 161);
            this.gbxSensorInfo.Name = "gbxSensorInfo";
            this.gbxSensorInfo.Size = new System.Drawing.Size(513, 135);
            this.gbxSensorInfo.TabIndex = 4;
            this.gbxSensorInfo.TabStop = false;
            this.gbxSensorInfo.Text = "Sensor Information";
            // 
            // cmbSensorType
            // 
            this.cmbSensorType.BackColor = System.Drawing.Color.White;
            this.cmbSensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensorType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSensorType.FormattingEnabled = true;
            this.cmbSensorType.Items.AddRange(new object[] {
            "SELECT SENSOR TYPE:",
            "Temperature",
            "pH"});
            this.cmbSensorType.Location = new System.Drawing.Point(254, 75);
            this.cmbSensorType.Name = "cmbSensorType";
            this.cmbSensorType.Size = new System.Drawing.Size(205, 29);
            this.cmbSensorType.TabIndex = 3;
            this.cmbSensorType.SelectedIndexChanged += new System.EventHandler(this.cmbSensorType_SelectedIndexChanged);
            // 
            // txtSensorName
            // 
            this.txtSensorName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensorName.Location = new System.Drawing.Point(254, 36);
            this.txtSensorName.Name = "txtSensorName";
            this.txtSensorName.Size = new System.Drawing.Size(205, 27);
            this.txtSensorName.TabIndex = 2;
            // 
            // lblChooseSensorType
            // 
            this.lblChooseSensorType.AutoSize = true;
            this.lblChooseSensorType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSensorType.Location = new System.Drawing.Point(54, 78);
            this.lblChooseSensorType.Name = "lblChooseSensorType";
            this.lblChooseSensorType.Size = new System.Drawing.Size(167, 21);
            this.lblChooseSensorType.TabIndex = 1;
            this.lblChooseSensorType.Text = "Choose Sensor Type:";
            // 
            // lblEnterSensorName
            // 
            this.lblEnterSensorName.AutoSize = true;
            this.lblEnterSensorName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSensorName.Location = new System.Drawing.Point(54, 39);
            this.lblEnterSensorName.Name = "lblEnterSensorName";
            this.lblEnterSensorName.Size = new System.Drawing.Size(160, 21);
            this.lblEnterSensorName.TabIndex = 0;
            this.lblEnterSensorName.Text = "Enter Sensor Name:";
            // 
            // lblSystemSettings
            // 
            this.lblSystemSettings.AutoSize = true;
            this.lblSystemSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemSettings.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemSettings.ForeColor = System.Drawing.Color.White;
            this.lblSystemSettings.Location = new System.Drawing.Point(41, 57);
            this.lblSystemSettings.Name = "lblSystemSettings";
            this.lblSystemSettings.Size = new System.Drawing.Size(166, 25);
            this.lblSystemSettings.TabIndex = 3;
            this.lblSystemSettings.Text = "System Settings";
            // 
            // lblDashDivider
            // 
            this.lblDashDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDashDivider.Location = new System.Drawing.Point(0, 139);
            this.lblDashDivider.Name = "lblDashDivider";
            this.lblDashDivider.Size = new System.Drawing.Size(1200, 1);
            this.lblDashDivider.TabIndex = 2;
            // 
            // lblDashSubHeader
            // 
            this.lblDashSubHeader.AutoSize = true;
            this.lblDashSubHeader.Location = new System.Drawing.Point(42, 92);
            this.lblDashSubHeader.Name = "lblDashSubHeader";
            this.lblDashSubHeader.Size = new System.Drawing.Size(371, 19);
            this.lblDashSubHeader.TabIndex = 1;
            this.lblDashSubHeader.Text = "Aquaponics && Aquaculture Monitoring System";
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLogo.BackgroundImage")));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLogo.Location = new System.Drawing.Point(3, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(203, 71);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // pnlHeaderMainDash
            // 
            this.pnlHeaderMainDash.Controls.Add(this.lblCompanyName);
            this.pnlHeaderMainDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderMainDash.Location = new System.Drawing.Point(212, 3);
            this.pnlHeaderMainDash.Name = "pnlHeaderMainDash";
            this.pnlHeaderMainDash.Size = new System.Drawing.Size(1171, 71);
            this.pnlHeaderMainDash.TabIndex = 3;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(3, 29);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(139, 23);
            this.lblCompanyName.TabIndex = 3;
            this.lblCompanyName.Text = "La Pieus Aqua";
            // 
            // frmSettingsMainDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnlMainDashLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettingsMainDash";
            this.Text = "frmSettingsMainDash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMainDashLayout.ResumeLayout(false);
            this.pnlDashSideMenu.ResumeLayout(false);
            this.pnlDashContext.ResumeLayout(false);
            this.pnlDashContext.PerformLayout();
            this.gbxSensorLocation.ResumeLayout(false);
            this.gbxSensorLocation.PerformLayout();
            this.pnlExistingTank.ResumeLayout(false);
            this.pnlExistingTank.PerformLayout();
            this.gbxCriticalRange.ResumeLayout(false);
            this.gbxCriticalRange.PerformLayout();
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            this.pnlPhCriticalRange.ResumeLayout(false);
            this.pnlPhCriticalRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTemp)).EndInit();
            this.gbxSensorInfo.ResumeLayout(false);
            this.gbxSensorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlHeaderMainDash.ResumeLayout(false);
            this.pnlHeaderMainDash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMainDashLayout;
        private System.Windows.Forms.Panel pnlDashSideMenu;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlHeaderMainDash;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnAddSensor;
        private System.Windows.Forms.Button btnEditSensor;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUserSettings;
        private System.Windows.Forms.Button btnNotificationSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlDashContext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSensorInfo;
        private System.Windows.Forms.GroupBox gbxSensorLocation;
        private System.Windows.Forms.Panel pnlExistingTank;
        private System.Windows.Forms.CheckBox cbxChooseNewTank;
        private System.Windows.Forms.ComboBox cmbExistingTanks;
        private System.Windows.Forms.Label lblChooseExistingTank;
        private System.Windows.Forms.CheckBox cbxExistingTank;
        private System.Windows.Forms.TextBox txtTankName;
        private System.Windows.Forms.Label lblTankName;
        private System.Windows.Forms.GroupBox gbxCriticalRange;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlPhCriticalRange;
        private System.Windows.Forms.Label lblMaxPH;
        private System.Windows.Forms.Label lblMinPH;
        private System.Windows.Forms.Label lblSetPhCriticalRange;
        private System.Windows.Forms.NumericUpDown nudMaxPH;
        private System.Windows.Forms.NumericUpDown nudMinPH;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblSetTempCriticalRanges;
        private System.Windows.Forms.NumericUpDown nudMaxTemp;
        private System.Windows.Forms.NumericUpDown nudMinTemp;
        private System.Windows.Forms.GroupBox gbxSensorInfo;
        private System.Windows.Forms.ComboBox cmbSensorType;
        private System.Windows.Forms.TextBox txtSensorName;
        private System.Windows.Forms.Label lblChooseSensorType;
        private System.Windows.Forms.Label lblEnterSensorName;
        private System.Windows.Forms.Label lblSystemSettings;
        private System.Windows.Forms.Label lblDashDivider;
        private System.Windows.Forms.Label lblDashSubHeader;
    }
}