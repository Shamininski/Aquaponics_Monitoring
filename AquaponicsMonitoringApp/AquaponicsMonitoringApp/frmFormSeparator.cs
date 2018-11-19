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
    /// <summary>
    /// Form Creator: Eldané
    /// This form is used to provide a partially transparent barrier between two forms when one
    /// form overlap another form. 
    /// The barrier allows the user to focus on only one form while seeing the form below.
    /// </summary>
    public partial class frmFormSeparator : Form
    {
        public frmFormSeparator()
        {
            InitializeComponent();
        }

        private void frmFormSeparator_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.Opacity = 0.5;

        }

        private void frmFormSeparator_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.No;
        }

    }
}
