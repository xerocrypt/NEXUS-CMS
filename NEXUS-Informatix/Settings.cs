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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        // Cancel button
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Load  connection settings into DLL buffers
        private void cmdSet_Click(object sender, EventArgs e)
        {
            ConnectionSettings.Settings.serverIP = txtServerAddress.Text;
            ConnectionSettings.Settings.userName = txtUserName.Text;
            ConnectionSettings.Settings.authKey = txtPassword.Text;

            this.Close();
        }

        private void txtServerAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
