using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CecilioNolenAuditReview
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection();
        DataSet newDS = new DataSet();
        OleDbDataAdapter newAdapter = new OleDbDataAdapter();
        OleDbCommandBuilder cmdBuilder;

        public Form1()
        {
            InitializeComponent();

            conn.ConnectionString =
               "Provider=SQLNCLI11;" +
               "Server=74.117.171.115,32000;" +
               "Database=CS340318;" +
               "UID=UAFS18;" +
               "PWD=UApass100;";
        }

        private void LoginSubmit_Btn_Click(object sender, EventArgs e)
        {
            string uname = Username_Txt.Text;
            string pass  = Password_Txt.Text;

            try
            {
                conn.Open();
                String sql = "";
                OleDbDataReader reader;
                OleDbCommand cmd = new OleDbCommand();

                sql = "SELECT COUNT(ARCEMP_ID) FROM ARCEMP WHERE ? = ARCEMP_USERNAME AND ? = ARCEMP_PASSWORD;";
                cmd.CommandText = sql;
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("Username", Username_Txt.Text);
                cmd.Parameters.AddWithValue("Password", Password_Txt.Text);

                reader = cmd.ExecuteReader();


                cmdBuilder = new OleDbCommandBuilder(newAdapter);

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
                conn.Close();
            }
        }
    }
}
