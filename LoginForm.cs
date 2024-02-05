using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cmpt_291_MilestoneOne
{
    public partial class LoginForm : Form
    {

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void OpenConnection()
        /*
         * purpose: establishes connection with sql server
         *          call before myconnection commands
         * 
         */
        {
            // choose server, DB, login type;
            string server = "DESKTOP-LFJL7JC";
            string database = "Car_Rental_Service";
            string connectionString = "Server = " + server + "; Database = " + database + "; Trusted_Connection = yes";

            SqlConnection myConnection = new(connectionString);

            try
            {
                myConnection.Open(); //open connection
                myCommand = new SqlCommand
                {
                    Connection = myConnection //link command stream to the c...
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            return;

        }

        private void CloseConnection()
        /*
         * purpose: closes sql connection
         *          call after myconnection commands
         */
        {
            myCommand.Connection.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(username.Text) && // check entry boxes arnt empty
                !string.IsNullOrEmpty(password.Text))
            {
                OpenConnection();
                string table = "dbo.Login";

                myCommand.CommandText = "select * from " + table + " where U_ID = '" + username.Text.ToString() + "' and P_ID = '" + password.Text.ToString() + "'";

                myReader = myCommand.ExecuteReader();

                if (myReader.HasRows) // check record was found
                {
                    while (myReader.Read())
                    {
                        if (username.Text.ToString() == myReader["U_ID"].ToString() && // compare username
                            password.Text.ToString() == myReader["P_ID"].ToString()) // compare password
                        {
                            MainForm main = new MainForm(); // login in succesfull time to log in
                            main.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!");
                }

                CloseConnection();
            }
            else
            {
                MessageBox.Show("Please fill out username and password");
            }


        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
