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
    public partial class frmNewTestAccount : Form
    {
        public frmNewTestAccount()
        {
            InitializeComponent();
        }

        private void cmdStore_Click(object sender, EventArgs e)
        {
            try
            {
                string loadSet = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";

                string Query = "insert into informatics.storedaccounts (StoreID, System, SystemAddress, LoginName, AuthKey, Notes) values('" + this.txtStoreID.Text + "', '" + this.txtSystem.Text + "', '" + this.txtAddress.Text + "', '" + this.txtLogin.Text + "', '" + this.txtPassword.Text + "', '" + this.txtNotes.Text + "') ;";
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

        // Close the current window
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
