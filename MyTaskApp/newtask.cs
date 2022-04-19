﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MyTaskApp
{
    public partial class newtask : Form
    {
        public newtask()
        {
            InitializeComponent();
        }

        //Opens connection to DB and submits new task based on logged in user.
        private void button_addtask_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    conn.Open();
                    MySqlCommand addtask = new MySqlCommand($"INSERT INTO tasks (user_id, task, completed) VALUES ({ getUserData.UserID }, '{ textBox_newtask.Text }', 0)", conn);
                    addtask.ExecuteNonQuery();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DashBoard.Dash.Load_Data();
        }
    }
}