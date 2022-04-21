using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//This class allows the user to communicate with the database and log in if username and password are correct

namespace MyTaskApp
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        
        //Checks entered username and password against database to log user in
        private void button_login_Click(object sender, EventArgs e)
        {
            if (checkBox_remember.Checked)
            {
                Properties.Settings.Default.userName = textBox_user.Text;
                Properties.Settings.Default.passUser = textBox_pwd.Text;
                Properties.Settings.Default.Save();
            }
            //Checks if fields are empty
            if (textBox_user.Text == "" || textBox_pwd.Text == "")
            {
                MessageBox.Show("Please enter a vlid username and password");
                return;
            }
            try
            {
                //Creates a connection via the helpconn class that grabs the connection string from app config file
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    conn.Open();
                    //selects username entered and checks to make sure the password matches
                    string checkLogin = $"SELECT * FROM appusers WHERE username = @Username";
                    MySqlCommand cmd = new MySqlCommand(checkLogin, conn);
                    cmd.Parameters.AddWithValue("@Username", textBox_user.Text.ToString());
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        //logins in and shows users dashboard if correct
                        if (textBox_user.Text == dr[1].ToString() && textBox_pwd.Text == dr[2].ToString())
                        {   
                            getUserData user = new getUserData();
                            getUserData.UserName = dr[1].ToString();
                            getUserData.UserID = Convert.ToInt32(dr[0].ToString());
                            this.Hide();
                            DashBoard db = new DashBoard();
                            db.Show();
                            DashBoard.Dash.Load_Data();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login. Please Try Again");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Flags catch if error reaching the database
                MessageBox.Show(ex.Message);
            }
        }

        //Opens the form to create a new account
        private void button_newacc_Click(object sender, EventArgs e)
        {
            form_createAcc ca = new form_createAcc();
            ca.Show();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.userName != string.Empty)
            {
                textBox_user.Text = Properties.Settings.Default.userName;
                textBox_pwd.Text = Properties.Settings.Default.passUser;
            }
        }
    }
}
