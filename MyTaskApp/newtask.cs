using MySql.Data.MySqlClient;
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
                    MySqlCommand addtask = new MySqlCommand($"INSERT INTO tasks (user_id, task, completed) VALUES (@userid, @task, 0)", conn);
                    addtask.Parameters.AddWithValue(@"userid", getUserData.UserID);
                    addtask.Parameters.AddWithValue("@task", textBox_newtask.Text);
                    addtask.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DashBoard.Dash.Load_Data();
        }

        private void button_closeapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
