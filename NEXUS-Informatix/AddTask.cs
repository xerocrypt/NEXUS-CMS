using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace NEXUS_Informatix
{
    public partial class frmAddTask : Form
    {
        public frmAddTask()
        {
            InitializeComponent();

            byte[] packetData = System.Text.ASCIIEncoding.ASCII.GetBytes("The version number here");
            string ipAddress = "192.168.1.3";
            int portNumber = 1981;

            IPEndPoint destpoint = new IPEndPoint(IPAddress.Parse(ipAddress), portNumber);

            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            client.SendTo(packetData, destpoint);

        }

        private void cmdPost_Click(object sender, EventArgs e)
        {
            try
            {
                string loadSet = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";

                string Query = "insert into informatics.casework (tasknumber, subject, sender, recipient, system, description, deadline, status) values('" + this.txtTaskNumber.Text + "', '" + this.txtSubject.Text + "', '" + this.txtFrom.Text + "', '" + this.txtRecipient.Text + "', '" + this.txtSystem.Text + "', '" + this.txtDescription.Text + "', '" + this.txtDeadline.Text + "', '" + this.txtStatus.Text + "') ;";
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

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";

                string Query = "update informatics.casework set tasknumber='" + this.txtTaskNumber.Text + "',subject='" + this.txtSubject.Text + "',sender='" + this.txtFrom.Text + "',recipient='" + this.txtRecipient.Text + "',system='" + this.txtSystem.Text + "',description='" + this.txtDescription.Text + "',deadline='" + this.txtDeadline.Text + "',status='" + this.txtStatus.Text + "' where tasknumber='" + this.txtTaskNumber.Text + "';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;

                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");

                while (MyReader2.Read())
                {
                }

                MyConn2.Close();//Connection closed here
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }

           
        }
 

