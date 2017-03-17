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
    public partial class frmNewRecord : Form
    {
        public frmNewRecord()
        {
            InitializeComponent();
        }

        private void frmNewRecord_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Cancel button
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add Record button
        private void cmdAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string loadSet = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";

                string Query = "insert into informatics.testrecords (testnumber, testedsystem, testname, testdate, outcome, notes, testerName) values('" + this.txtTestNumber.Text + "', '" + this.txtTargetSystem.Text + "', '" + this.txtTestName.Text + "', '" + this.txtDate.Text + "', '" + this.txtOutcome.Text + "', '" + this.txtCaseNotes.Text + "', '" + this.txtTesterName.Text + "') ;";
                MySqlConnection conDataBase = new MySqlConnection(loadSet);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Record Added");
                while (myReader.Read())
                {
                }
            }

            // Exception handling for MySQL server connection
            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
                    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
