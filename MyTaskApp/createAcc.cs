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
        BridgeData bd = new BridgeData();
        public form_createAcc()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (bd.CreateAccount(textBox_newuser.Text.Trim(), textBox_newpwd.Text.Trim()) == 1){
                MessageBox.Show("Account created. Please Log in.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something Went Wrong. Please try again.");
                return;
            }
        }

        private void button_closeapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
