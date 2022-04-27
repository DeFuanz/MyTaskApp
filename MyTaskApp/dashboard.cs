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
        //Allows calling of data bridging methods
        public BridgeData bd = new BridgeData();

        //Logs the user out and confirms
        private void Button_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form_login fl = new Form_login();
                fl.Show();
            }
        }

        //loads all dashboard information after login
        private void Dashboard_Load(object sender, EventArgs e)
        {
            userlabel.Text = getUserData.UserName;
            label_date.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");
            checkedListBox1.DataSource = bd.PopulateTasks(getUserData.UserID);
        }

        //Creates a new task and refreshes the datasource
        private void Button1_Click(object sender, EventArgs e)
        {
            if (bd.SubmitTask(textBox_addtask.Text) == 1)
            {
                textBox_addtask.Clear();
                checkedListBox1.DataSource = null;
                checkedListBox1.DataSource = bd.PopulateTasks(getUserData.UserID);
            }
            else
            {
                MessageBox.Show("Please enter a task");
            }
        }

        //Deletes all of the tasks from the users profile and refreshes datasource
        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to clear all tasks?", "Alert", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == dr)
            {
                bd.ClearTasks(getUserData.UserID);
                checkedListBox1.DataSource = null;
                checkedListBox1.DataSource = bd.PopulateTasks(getUserData.UserID);
            }
            else
            {
                return;
            }
        }

        //Marks selected tasks as completed and refreshes the shown tasks
        private void Button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string checkedtask = checkedListBox1.CheckedItems[i].ToString(); //Thinking of passing checked items as string to bridge layer instead of here
                bd.MarkCompleteTask(checkedtask);
            }
            checkedListBox1.DataSource = null;
            checkedListBox1.DataSource = bd.PopulateTasks(getUserData.UserID);
        }

        //loads the dashboard welcome on button click
        private void Button4_Click(object sender, EventArgs e)
        {
            panel_tasks.Hide();
            panel_home.Show();
        }

        //Loads the tasksmanagement tab on button click
        private void Button5_Click(object sender, EventArgs e)
        {
            panel_home.Hide();
            panel_tasks.Show();
        }
    }
}