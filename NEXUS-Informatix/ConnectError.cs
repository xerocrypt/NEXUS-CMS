using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NEXUS_Informatix
{
    public partial class frmConnectError : Form
    {
        public frmConnectError()
        {
            InitializeComponent();
        }

        // Close dialogue
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConnectError_Load(object sender, EventArgs e)
        {

        }
    }
}
