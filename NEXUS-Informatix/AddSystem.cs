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
    public partial class frmAddSystem : Form
    {
        public frmAddSystem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string loadSet = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";

                string Query = "insert into informatics.inventory (SystemName, Function, Address, Description, ScriptFileNames, Notes) values('" + this.txtSystemName.Text + "', '" + this.txtFunction.Text + "', '" + this.txtSystemAddress.Text + "', '" + this.txtDescription.Text + "', '" + this.txtScriptFiles.Text + "', '" + this.txtNotes.Text + "') ;";
                MySqlConnection conDataBase = new MySqlConnection(loadSet);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Record Added");
            }

            // Exception handling for MySQL server connection
            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();
            }
        }

        private void frmAddSystem_Load(object sender, EventArgs e)
        {

        }
    }
}
