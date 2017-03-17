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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        // Quit application
        private void cmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSettings myNewForm = new frmSettings();
            myNewForm.Show();
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            frmAbout myNewForm2 = new frmAbout();
            myNewForm2.Show();
        }

        // Connection settings button
        private void button2_Click(object sender, EventArgs e)
        {
            frmSettings myNewForm = new frmSettings();
            myNewForm.Show();
        }

        // Load all records button
        private void button3_Click(object sender, EventArgs e)
        {
            frmViewTable myNewForm5 = new frmViewTable();
            myNewForm5.Show();
        }

        // About button
        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAbout myNewForm2 = new frmAbout();
            myNewForm2.Show();
        }

        // New Record button
        private void cmdNewRecord_Click(object sender, EventArgs e)
        {
            frmNewRecord myNewForm4 = new frmNewRecord();
            myNewForm4.Show();
        }

        private void cmdTasks_Click(object sender, EventArgs e)
        {
            frmTasks myNewForm6 = new frmTasks();
            myNewForm6.Show();
        }

        private void cmdBugReport_Click(object sender, EventArgs e)
        {
            string loadSet = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";
            try
            {
                MySqlConnection mySession = new MySqlConnection(loadSet);
                MySqlCommand dbCommand = new MySqlCommand(" select * from informatics.bugreports ; ", mySession);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = dbCommand;
                DataTable tutorial = new DataTable();
                sda.Fill(tutorial);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = tutorial;
                dataGrid.DataSource = bsource;
                sda.Update(tutorial);

            }

            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();
            }
        }

        private void grpActions_Enter(object sender, EventArgs e)
        {

        }

        private void cmdStoredAccounts_Click(object sender, EventArgs e)
        {
            frmStoredLogins myTestAccounts = new frmStoredLogins();
            myTestAccounts.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void connectionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connectionSettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSettings mySettings = new frmSettings();
            mySettings.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout myApplication = new frmAbout();
            myApplication.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdTestScripts_Click(object sender, EventArgs e)
        {
            frmTestScript myTestScripts = new frmTestScript();
            myTestScripts.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string loadSet = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";
            try
            {
                MySqlConnection mySession = new MySqlConnection(loadSet);
                MySqlCommand dbCommand = new MySqlCommand(" select * from informatics.inventory ; ", mySession);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = dbCommand;
                DataTable tutorial = new DataTable();
                sda.Fill(tutorial);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = tutorial;
                dataGrid.DataSource = bsource;
                sda.Update(tutorial);

            }

            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();
            }
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            string loadSet = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";
            try
            {
                MySqlConnection mySession = new MySqlConnection(loadSet);
                MySqlCommand dbCommand = new MySqlCommand(" select * from informatics.casework ; ", mySession);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = dbCommand;
                DataTable tutorial = new DataTable();
                sda.Fill(tutorial);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = tutorial;
                dataGrid.DataSource = bsource;
                sda.Update(tutorial);
                lblStatus.Text = "Connected to server";
            }

            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();
            }
        }

        private void cmdAddBug_Click(object sender, EventArgs e)
        {
            frmBugReport myBugReport = new frmBugReport();
            myBugReport.Show();
        }

        private void cmdAddSystem_Click(object sender, EventArgs e)
        {
            frmAddSystem myInventoryUpdate = new frmAddSystem();
            myInventoryUpdate.Show();
        }
    }
}
