namespace AquaponicsMonitoringApp
{
    partial class frmLiveGraph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLiveGraph));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlMainDashLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDashSideMenu = new System.Windows.Forms.Panel();
            this.btnLiveGraph = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlDashContext = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDashDivider = new System.Windows.Forms.Label();
            this.lblDashSubHeader = new System.Windows.Forms.Label();
            this.lblDashboardActions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeaderMainDash = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pnlMainDashLayout.SuspendLayout();
            this.pnlDashSideMenu.SuspendLayout();
            this.pnlDashContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.pnlMainDashLayout.Size = new System.Drawing.Size(1370, 749);
            this.pnlMainDashLayout.TabIndex = 1;
            // 
            // pnlDashSideMenu
            // 
            this.pnlDashSideMenu.Controls.Add(this.btnLiveGraph);
            this.pnlDashSideMenu.Controls.Add(this.btnDashboard);
            this.pnlDashSideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashSideMenu.Location = new System.Drawing.Point(3, 76);
            this.pnlDashSideMenu.Name = "pnlDashSideMenu";
            this.pnlDashSideMenu.Size = new System.Drawing.Size(181, 670);
            this.pnlDashSideMenu.TabIndex = 1;
            // 
            // btnLiveGraph
            // 
            this.btnLiveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLiveGraph.FlatAppearance.BorderSize = 0;
            this.btnLiveGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiveGraph.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiveGraph.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLiveGraph.Image = ((System.Drawing.Image)(resources.GetObject("btnLiveGraph.Image")));
            this.btnLiveGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLiveGraph.Location = new System.Drawing.Point(3, 92);
            this.btnLiveGraph.Name = "btnLiveGraph";
            this.btnLiveGraph.Size = new System.Drawing.Size(179, 41);
            this.btnLiveGraph.TabIndex = 4;
            this.btnLiveGraph.Text = "   Live Graph";
            this.btnLiveGraph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLiveGraph.UseVisualStyleBackColor = true;
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
            this.btnDashboard.Size = new System.Drawing.Size(179, 41);
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
            this.pnlDashContext.Controls.Add(this.checkedListBox1);
            this.pnlDashContext.Controls.Add(this.chart1);
            this.pnlDashContext.Controls.Add(this.lblDashDivider);
            this.pnlDashContext.Controls.Add(this.lblDashSubHeader);
            this.pnlDashContext.Controls.Add(this.lblDashboardActions);
            this.pnlDashContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashContext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDashContext.ForeColor = System.Drawing.Color.White;
            this.pnlDashContext.Location = new System.Drawing.Point(190, 76);
            this.pnlDashContext.Name = "pnlDashContext";
            this.pnlDashContext.Size = new System.Drawing.Size(1177, 670);
            this.pnlDashContext.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(273, 194);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(873, 441);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chartCombined";
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
            // lblDashboardActions
            // 
            this.lblDashboardActions.AutoSize = true;
            this.lblDashboardActions.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboardActions.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardActions.ForeColor = System.Drawing.Color.White;
            this.lblDashboardActions.Location = new System.Drawing.Point(41, 51);
            this.lblDashboardActions.Name = "lblDashboardActions";
            this.lblDashboardActions.Size = new System.Drawing.Size(237, 25);
            this.lblDashboardActions.TabIndex = 0;
            this.lblDashboardActions.Text = "Combined Live Graph";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeaderMainDash
            // 
            this.pnlHeaderMainDash.Controls.Add(this.lblCompanyName);
            this.pnlHeaderMainDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderMainDash.Location = new System.Drawing.Point(190, 3);
            this.pnlHeaderMainDash.Name = "pnlHeaderMainDash";
            this.pnlHeaderMainDash.Size = new System.Drawing.Size(1177, 67);
            this.pnlHeaderMainDash.TabIndex = 3;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(3, 27);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(139, 23);
            this.lblCompanyName.TabIndex = 3;
            this.lblCompanyName.Text = "La Pieus Aqua";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(61, 229);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 92);
            this.checkedListBox1.TabIndex = 4;
            // 
            // frmLiveGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnlMainDashLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLiveGraph";
            this.Text = "frmLiveGraph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLiveGraph_Load);
            this.pnlMainDashLayout.ResumeLayout(false);
            this.pnlDashSideMenu.ResumeLayout(false);
            this.pnlDashContext.ResumeLayout(false);
            this.pnlDashContext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeaderMainDash.ResumeLayout(false);
            this.pnlHeaderMainDash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMainDashLayout;
        private System.Windows.Forms.Panel pnlDashSideMenu;
        private System.Windows.Forms.Button btnLiveGraph;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlDashContext;
        private System.Windows.Forms.Label lblDashDivider;
        private System.Windows.Forms.Label lblDashSubHeader;
        private System.Windows.Forms.Label lblDashboardActions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHeaderMainDash;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}