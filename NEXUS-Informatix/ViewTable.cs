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
    public partial class frmViewTable : Form
    {
        public frmViewTable()
        {
            InitializeComponent();
        }

        //Load data button - Fetch and load the entire table
        private void cmdLoad_Click(object sender, EventArgs e)
        {
            string loadSet = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";
            try
            {
                MySqlConnection mySession = new MySqlConnection(loadSet);
                MySqlCommand dbCommand = new MySqlCommand(" select * from informatics.testrecords ; ", mySession);

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

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Open New Record window
        private void button1_Click(object sender, EventArgs e)
        {
            frmNewRecord myNewForm6 = new frmNewRecord();
            myNewForm6.Show();
        }

        private void frmViewTable_Load(object sender, EventArgs e)
        {

        }
    }
}
