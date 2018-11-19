namespace AquaponicsMonitoringApp
{
    partial class frmTankSensorTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTankSensorTemplate));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.pnlMainDashLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDashSideMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlDashContext = new System.Windows.Forms.Panel();
            this.btnSeeTankDetails = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.lblpHReadingsSheet = new System.Windows.Forms.Label();
            this.btnDownloadpHSensorSheet = new System.Windows.Forms.Button();
            this.lblTempReadingSheet = new System.Windows.Forms.Label();
            this.btnDownloadTempSensorSheet = new System.Windows.Forms.Button();
            this.lblpHReadingHeading = new System.Windows.Forms.Label();
            this.lblTemperatureReadingHeading = new System.Windows.Forms.Label();
            this.chartPH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDashDivider = new System.Windows.Forms.Label();
            this.lblDashSubHeader = new System.Windows.Forms.Label();
            this.lblTankName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeaderMainDash = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pnlMainDashLayout.SuspendLayout();
            this.pnlDashSideMenu.SuspendLayout();
            this.pnlDashContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeaderMainDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainDashLayout
            // 
            this.pnlMainDashLayout.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainDashLayout.ColumnCount = 2;
            this.pnlMainDashLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.68821F));
            this.pnlMainDashLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.31179F));
            this.pnlMainDashLayout.Controls.Add(this.pnlDashSideMenu, 0, 1);
            this.pnlMainDashLayout.Controls.Add(this.pnlDashContext, 1, 1);
            this.pnlMainDashLayout.Controls.Add(this.pictureBox1, 0, 0);
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
            this.pnlDashSideMenu.Controls.Add(this.btnSettings);
            this.pnlDashSideMenu.Controls.Add(this.btnDashboard);
            this.pnlDashSideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashSideMenu.Location = new System.Drawing.Point(3, 80);
            this.pnlDashSideMenu.Name = "pnlDashSideMenu";
            this.pnlDashSideMenu.Size = new System.Drawing.Size(183, 705);
            this.pnlDashSideMenu.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 99);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(181, 41);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "   Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(2, 45);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(181, 41);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "    Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlDashContext
            // 
            this.pnlDashContext.BackColor = System.Drawing.Color.Transparent;
            this.pnlDashContext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDashContext.BackgroundImage")));
            this.pnlDashContext.Controls.Add(this.btnSeeTankDetails);
            this.pnlDashContext.Controls.Add(this.btnPrintReport);
            this.pnlDashContext.Controls.Add(this.lblpHReadingsSheet);
            this.pnlDashContext.Controls.Add(this.btnDownloadpHSensorSheet);
            this.pnlDashContext.Controls.Add(this.lblTempReadingSheet);
            this.pnlDashContext.Controls.Add(this.btnDownloadTempSensorSheet);
            this.pnlDashContext.Controls.Add(this.lblpHReadingHeading);
            this.pnlDashContext.Controls.Add(this.lblTemperatureReadingHeading);
            this.pnlDashContext.Controls.Add(this.chartPH);
            this.pnlDashContext.Controls.Add(this.chartTemperature);
            this.pnlDashContext.Controls.Add(this.lblDashDivider);
            this.pnlDashContext.Controls.Add(this.lblDashSubHeader);
            this.pnlDashContext.Controls.Add(this.lblTankName);
            this.pnlDashContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashContext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDashContext.ForeColor = System.Drawing.Color.White;
            this.pnlDashContext.Location = new System.Drawing.Point(192, 80);
            this.pnlDashContext.Name = "pnlDashContext";
            this.pnlDashContext.Size = new System.Drawing.Size(1191, 705);
            this.pnlDashContext.TabIndex = 2;
            // 
            // btnSeeTankDetails
            // 
            this.btnSeeTankDetails.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSeeTankDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeTankDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeTankDetails.Location = new System.Drawing.Point(970, 627);
            this.btnSeeTankDetails.Name = "btnSeeTankDetails";
            this.btnSeeTankDetails.Size = new System.Drawing.Size(148, 29);
            this.btnSeeTankDetails.TabIndex = 12;
            this.btnSeeTankDetails.Text = "See Tank Details";
            this.btnSeeTankDetails.UseVisualStyleBackColor = false;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(970, 592);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(148, 29);
            this.btnPrintReport.TabIndex = 11;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            // 
            // lblpHReadingsSheet
            // 
            this.lblpHReadingsSheet.AutoSize = true;
            this.lblpHReadingsSheet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpHReadingsSheet.Location = new System.Drawing.Point(673, 545);
            this.lblpHReadingsSheet.Name = "lblpHReadingsSheet";
            this.lblpHReadingsSheet.Size = new System.Drawing.Size(210, 21);
            this.lblpHReadingsSheet.TabIndex = 10;
            this.lblpHReadingsSheet.Text = "pH Sensor Readings Sheet";
            // 
            // btnDownloadpHSensorSheet
            // 
            this.btnDownloadpHSensorSheet.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadpHSensorSheet.FlatAppearance.BorderSize = 0;
            this.btnDownloadpHSensorSheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDownloadpHSensorSheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDownloadpHSensorSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadpHSensorSheet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadpHSensorSheet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDownloadpHSensorSheet.Location = new System.Drawing.Point(584, 539);
            this.btnDownloadpHSensorSheet.Name = "btnDownloadpHSensorSheet";
            this.btnDownloadpHSensorSheet.Size = new System.Drawing.Size(117, 32);
            this.btnDownloadpHSensorSheet.TabIndex = 9;
            this.btnDownloadpHSensorSheet.Text = "Download";
            this.btnDownloadpHSensorSheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadpHSensorSheet.UseVisualStyleBackColor = false;
            this.btnDownloadpHSensorSheet.MouseLeave += new System.EventHandler(this.btnDownloadpHSensorSheet_MouseLeave);
            this.btnDownloadpHSensorSheet.MouseHover += new System.EventHandler(this.btnDownloadpHSensorSheet_MouseHover);
            // 
            // lblTempReadingSheet
            // 
            this.lblTempReadingSheet.AutoSize = true;
            this.lblTempReadingSheet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempReadingSheet.Location = new System.Drawing.Point(114, 545);
            this.lblTempReadingSheet.Name = "lblTempReadingSheet";
            this.lblTempReadingSheet.Size = new System.Drawing.Size(290, 21);
            this.lblTempReadingSheet.TabIndex = 8;
            this.lblTempReadingSheet.Text = "Temperature Sensor Readings Sheet";
            // 
            // btnDownloadTempSensorSheet
            // 
            this.btnDownloadTempSensorSheet.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadTempSensorSheet.FlatAppearance.BorderSize = 0;
            this.btnDownloadTempSensorSheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDownloadTempSensorSheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDownloadTempSensorSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadTempSensorSheet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadTempSensorSheet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDownloadTempSensorSheet.Location = new System.Drawing.Point(24, 539);
            this.btnDownloadTempSensorSheet.Name = "btnDownloadTempSensorSheet";
            this.btnDownloadTempSensorSheet.Size = new System.Drawing.Size(117, 32);
            this.btnDownloadTempSensorSheet.TabIndex = 7;
            this.btnDownloadTempSensorSheet.Text = "Download";
            this.btnDownloadTempSensorSheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadTempSensorSheet.UseVisualStyleBackColor = false;
            this.btnDownloadTempSensorSheet.MouseLeave += new System.EventHandler(this.btnDownloadTempSensorSheet_MouseLeave);
            this.btnDownloadTempSensorSheet.MouseHover += new System.EventHandler(this.btnDownloadTempSensorSheet_MouseHover);
            // 
            // lblpHReadingHeading
            // 
            this.lblpHReadingHeading.AutoSize = true;
            this.lblpHReadingHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblpHReadingHeading.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpHReadingHeading.ForeColor = System.Drawing.Color.White;
            this.lblpHReadingHeading.Location = new System.Drawing.Point(785, 195);
            this.lblpHReadingHeading.Name = "lblpHReadingHeading";
            this.lblpHReadingHeading.Size = new System.Drawing.Size(140, 25);
            this.lblpHReadingHeading.TabIndex = 6;
            this.lblpHReadingHeading.Text = "pH Readings";
            // 
            // lblTemperatureReadingHeading
            // 
            this.lblTemperatureReadingHeading.AutoSize = true;
            this.lblTemperatureReadingHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperatureReadingHeading.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureReadingHeading.ForeColor = System.Drawing.Color.White;
            this.lblTemperatureReadingHeading.Location = new System.Drawing.Point(163, 195);
            this.lblTemperatureReadingHeading.Name = "lblTemperatureReadingHeading";
            this.lblTemperatureReadingHeading.Size = new System.Drawing.Size(241, 25);
            this.lblTemperatureReadingHeading.TabIndex = 5;
            this.lblTemperatureReadingHeading.Text = "Temperature Readings";
            // 
            // chartPH
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPH.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPH.Legends.Add(legend1);
            this.chartPH.Location = new System.Drawing.Point(595, 223);
            this.chartPH.Name = "chartPH";
            this.chartPH.Size = new System.Drawing.Size(523, 309);
            this.chartPH.TabIndex = 4;
            this.chartPH.Text = "pHChart";
            // 
            // chartTemperature
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea2);
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend2);
            this.chartTemperature.Location = new System.Drawing.Point(33, 223);
            this.chartTemperature.Name = "chartTemperature";
            this.chartTemperature.Size = new System.Drawing.Size(523, 309);
            this.chartTemperature.TabIndex = 3;
            this.chartTemperature.Text = "TemperatureChart";
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
            // lblTankName
            // 
            this.lblTankName.AutoSize = true;
            this.lblTankName.BackColor = System.Drawing.Color.Transparent;
            this.lblTankName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTankName.ForeColor = System.Drawing.Color.White;
            this.lblTankName.Location = new System.Drawing.Point(41, 51);
            this.lblTankName.Name = "lblTankName";
            this.lblTankName.Size = new System.Drawing.Size(0, 25);
            this.lblTankName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeaderMainDash
            // 
            this.pnlHeaderMainDash.Controls.Add(this.lblCompanyName);
            this.pnlHeaderMainDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderMainDash.Location = new System.Drawing.Point(192, 3);
            this.pnlHeaderMainDash.Name = "pnlHeaderMainDash";
            this.pnlHeaderMainDash.Size = new System.Drawing.Size(1191, 71);
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
            // frmTankSensorTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(91)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnlMainDashLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTankSensorTemplate";
            this.Text = "TankSensorTemplate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTankSensorTemplate_Load);
            this.pnlMainDashLayout.ResumeLayout(false);
            this.pnlDashSideMenu.ResumeLayout(false);
            this.pnlDashContext.ResumeLayout(false);
            this.pnlDashContext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeaderMainDash.ResumeLayout(false);
            this.pnlHeaderMainDash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMainDashLayout;
        private System.Windows.Forms.Panel pnlDashSideMenu;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlDashContext;
        private System.Windows.Forms.Label lblDashDivider;
        private System.Windows.Forms.Label lblDashSubHeader;
        private System.Windows.Forms.Label lblTankName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHeaderMainDash;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblpHReadingHeading;
        private System.Windows.Forms.Label lblTemperatureReadingHeading;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.Label lblTempReadingSheet;
        private System.Windows.Forms.Button btnDownloadTempSensorSheet;
        private System.Windows.Forms.Label lblpHReadingsSheet;
        private System.Windows.Forms.Button btnDownloadpHSensorSheet;
        private System.Windows.Forms.Button btnSeeTankDetails;
        private System.Windows.Forms.Button btnPrintReport;
    }
}