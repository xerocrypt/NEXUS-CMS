using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace NEXUS_Informatix
{
    public partial class frmBugReport : Form
    {
        public frmBugReport()
        {
            InitializeComponent();
        }

        // Close bug report form
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdPost_Click(object sender, EventArgs e)
        {
            try
            {
                string loadSet = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";

                string Query = "insert into informatics.bugreports (IssueNum, Summary, Supplier, CreatedDate, CreatedBy, Product, Type, Severity, Status, Description) values('" + this.txtIssueNum.Text + "', '" + this.txtSummary.Text + "', '" + this.txtSupplier.Text + "', '" + this.txtDate.Text + "', '" + this.txtCreatedBy.Text + "', '" + this.txtProduct.Text + "', '" + this.txtIssueType.Text + "', '" + this.txtSeverity.Text + "', '" + this.txtStatus.Text + "','" + this.txtDescription.Text + "') ;";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=" + ConnectionSettings.Settings.serverIP + ";port=3306;username=" + ConnectionSettings.Settings.userName + ";password=" + ConnectionSettings.Settings.authKey + ";";

                string Query = "update informatics.bugreports set IssueNum='" + this.txtIssueNum.Text + "',Summary='" + this.txtSummary.Text + "',Supplier='" + this.txtSupplier.Text + "',CreatedDate='" + this.txtDate.Text + "',CreatedBy='" + this.txtCreatedBy.Text + "',Product='" + this.txtProduct.Text + "',Type='" + this.txtIssueType.Text + "', Severity='" + this.txtSeverity.Text + "', Status='" + this.txtStatus.Text + "', Description='" + this.txtDescription.Text + "'; where IssueNum='" + this.txtIssueNum.Text + "';";

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

        private void frmBugReport_Load(object sender, EventArgs e)
        {

        }

     
    }
}
