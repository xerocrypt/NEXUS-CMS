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
    public partial class frmAddStep : Form
    {
        public frmAddStep()
        {
            InitializeComponent();
        }

        private void cmdAddStep_Click(object sender, EventArgs e)
        {
            try
            {
                string loadSet = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";

                string Query = "insert into " + ConnectionSettings.Settings.scriptDB + "." + ConnectionSettings.Settings.scriptTable + "(StepID, Test, Action, ExpectedResult, ActualResult, Note) values('" + this.txtStepID.Text + "', '" + this.txtTest.Text + "', '" + this .txtAction.Text + "', '" + this.txtExpected.Text + "', '" + this.txtActual.Text + "', '" + this.txtNote.Text + "') ;";
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

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmAddStep_Load(object sender, EventArgs e)
        {
            lblScriptName.Text = "Adding step to " + ConnectionSettings.Settings.scriptTable;
        }
    }
}
