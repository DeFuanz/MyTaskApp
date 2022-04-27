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

namespace MyTaskApp
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            
        }
        //Allows dashboard to be accessed in the newtask.cs file to refresh the dashboard after creating a new task
        public static DashBoard Dash;
        BridgeData bd = new BridgeData();


  
        //Loads the user dashboard with custom info such as tasks, username, etc
        public void Load_Data()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    //Opens connection and loads all uncompleted tasks associated with the logged in user
                    conn.Open();
                    MySqlCommand ldtask = new MySqlCommand($"SELECT task FROM tasks WHERE user_id = @userid AND completed = 0", conn);
                    ldtask.Parameters.AddWithValue("@userid", getUserData.UserID);
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

        //This method calls for the database to clear all tasks listed under the user logged in
        public void DeleteData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    conn.Open();
                    MySqlCommand dltask = new MySqlCommand($"DELETE FROM tasks WHERE user_id = @userid",conn);
                    dltask.Parameters.AddWithValue("@userid", getUserData.UserID);
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
            }
        }

        //loads the tasks and user data after logging in
        private void dashboard_Load(object sender, EventArgs e)
        {
            userlabel.Text = getUserData.UserName;
            label_date.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");
            Load_Data();
            Dash = this;
    }

        //Creates a new task
        private void button1_Click(object sender, EventArgs e)
        {
            if (bd.SubmitTask(textBox_addtask.Text) == 1)
            {
                textBox_addtask.Clear();
                MessageBox.Show("Task Added");
                //Add load data here
            }
        }

        //This button uses DeleteData() to clear all the tasks from the database
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

        //This button allows the user to update the task to completed on all selected tasks
        //Then calls a refresh to the checkbox to get updated uncompleted tasks. 
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                    {
                        conn.Open();
                        MySqlCommand fintask = new MySqlCommand($"UPDATE tasks SET completed = 1 WHERE task = @checked", conn);
                        fintask.Parameters.AddWithValue("@checked", checkedListBox1.CheckedItems[i]);
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

        //loads the dashboard on button click
        private void button4_Click(object sender, EventArgs e)
        {
            panel_tasks.Hide();
            panel_home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_home.Hide();
            panel_tasks.Show();
        }
    }
}
