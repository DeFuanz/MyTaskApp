using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This class holds the code for creating a new username and password for taskApp

namespace MyTaskApp
{
    public partial class form_createAcc : Form
    {
        public form_createAcc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_newuser.Text == "" || textBox_newpwd.Text == "")
            {
                MessageBox.Show("Please enter a valid username and password");
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    conn.Open();

                    //Checks to see if the username already exists before inserting into database
                    string CheckUser = $"SELECT COUNT(*) FROM appusers WHERE Username = '{ textBox_newuser.Text.Trim() }'";
                    MySqlCommand checkcmd = new MySqlCommand(CheckUser, conn);
                    int checkedUser = Convert.ToInt32(checkcmd.ExecuteScalar());
                    if (checkedUser > 0)
                    {
                        MessageBox.Show("User already exists");
                        return;
                    }

                    //inserts the new username and password into the database
                    string insert = $"INSERT INTO appusers (username, passwd) VALUES ('{textBox_newuser.Text.Trim()}','{textBox_newpwd.Text}')";
                    MySqlCommand incmd = new MySqlCommand(insert, conn);
                    incmd.ExecuteNonQuery();

                    //checks the database to make sure the new username and password was actually created
                    string checkLogin = $"SELECT * FROM appusers WHERE username = '{textBox_newuser.Text}' AND passwd = '{textBox_newpwd.Text}'";
                    MySqlCommand cmd = new MySqlCommand(checkLogin, conn);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    //Lets the user know if the account was created or if there was an error
                    while (dr.Read())
                    {
                        if (textBox_newuser.Text == dr[1].ToString() && textBox_newpwd.Text == dr[2].ToString())
                        {
                            MessageBox.Show("New account Created. Please Log In");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Issue creating new account. Please try again");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button_closeapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
