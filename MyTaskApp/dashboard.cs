﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyTaskApp
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            
        }

        public static DashBoard Dash;


  
        //Loads the user dashboard with custom info such as tasks, username, etc
        public void Load_Data()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    //Opens connection and loads all uncompleted tasks associated with the logged in user
                    conn.Open();
                    MySqlCommand ldtask = new MySqlCommand($"SELECT task FROM tasks WHERE user_id = '{ getUserData.UserID }' AND completed = 0", conn);
                    MySqlDataReader dr = ldtask.ExecuteReader();

                    while (dr.Read())
                    {
                        //Calls to remove and tasks and repopulates if new task added (refreshes dashboard)

                        string newItem = dr["task"].ToString();
                        checkedListBox1.Items.Remove(newItem);
                        checkedListBox1.Items.Add(newItem);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    conn.Open();
                    MySqlCommand dltask = new MySqlCommand($"DELETE FROM tasks WHERE user_id = '{getUserData.UserID}'",conn);
                    dltask.ExecuteNonQuery();
                    checkedListBox1.Items.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Logs the user out
        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form_login fl = new Form_login();
                fl.Show();
                MessageBox.Show("Logout successful");
            }
        }

        //loads the tasks and user data after logging in
        private void dashboard_Load(object sender, EventArgs e)
        {
            userlabel.Text = getUserData.UserName;
            Load_Data();
            Dash = this;
    }

        //Creates a new task
        private void button1_Click(object sender, EventArgs e)
        {
            newtask nt = new newtask();
            nt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to clear all tasks?", "Alert", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == dr)
            {
                DeleteData();
            }
            else
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                    {
                        conn.Open();
                        MySqlCommand fintask = new MySqlCommand($"UPDATE tasks SET completed = 1 WHERE task = '{checkedListBox1.CheckedItems[i]}'", conn);
                        fintask.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }
            }
            checkedListBox1.Items.Clear();
            Load_Data();
        }
    }
}