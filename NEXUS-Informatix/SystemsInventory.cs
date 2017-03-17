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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void SystemsInventory_Load(object sender, EventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdLoad_Click(object sender, EventArgs e)
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

                lblServerStatus.Text = "Connected to Server";
            }

            catch
            {
                frmConnectError myNewForm3 = new frmConnectError();
                myNewForm3.Show();
            }
        }

        private void cmdAddSystem_Click(object sender, EventArgs e)
        {
            frmAddSystem myInventoryUpdate = new frmAddSystem();
            myInventoryUpdate.Show();
        }
    }
}
