using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NEXUS_Informatix
{
    public partial class frmTestScript : Form
    {
        public frmTestScript()
        {
            InitializeComponent();
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdLoadScript_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTestScript_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdAddStep_Click(object sender, EventArgs e)
        {
            frmAddStep myNewStep = new frmAddStep();
            myNewStep.Show();
        }

        private void cmdListScripts_Click(object sender, EventArgs e)
        {
            ConnectionSettings.Settings.scriptTable = txtScriptName.Text;
            string loadSet = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";
            try
            {
                MySqlConnection mySession = new MySqlConnection(loadSet);
                MySqlCommand dbCommand2 = new MySqlCommand(" select * from " + ConnectionSettings.Settings.scriptDB + "." + ConnectionSettings.Settings.scriptTable + ";", mySession);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = dbCommand2;
                DataTable tutorial = new DataTable();
                sda.Fill(tutorial);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = tutorial;
                dataGrid.DataSource = bsource;
                sda.Update(tutorial);

                lblServerStatus.Text = "Connected to Server";
            }

            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();

                lblServerStatus.Text = "Connection Error!";
            }
        }
    }
}
