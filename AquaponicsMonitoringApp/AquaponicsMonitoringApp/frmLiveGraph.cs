using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AquaponicsMonitoringApp
{
    public partial class frmLiveGraph : Form
    {
        public frmLiveGraph()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmMainDashboard MainDash = new frmMainDashboard();
            MainDash.Show();
            this.Close();
        }

        private void frmLiveGraph_Load(object sender, EventArgs e)
        {
            btnLiveGraph.BackColor = Color.FromArgb(58, 131, 79);
            pnlMainDashLayout.BackColor = Color.FromArgb(40, 91, 55);
        }

    }
}
