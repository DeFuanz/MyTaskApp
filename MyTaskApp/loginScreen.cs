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

        BridgeData bd = new BridgeData();
        
        //Checks entered username and password against database to log user in
        private void button_login_Click(object sender, EventArgs e)
        {
            if (checkBox_remember.Checked)
            {
                Properties.Settings.Default.userName = textBox_user.Text;
                Properties.Settings.Default.passUser = textBox_pwd.Text;
                Properties.Settings.Default.Save();
            }
            
            if (bd.VerifyLogin(textBox_user.Text, textBox_pwd.Text) == 1)
            {
                this.Hide();
                DashBoard db = new DashBoard();
                db.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login");
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

        private void button_closeapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
