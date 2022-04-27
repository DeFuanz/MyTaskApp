using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;


namespace MyTaskApp
{
    public class DataQueries
    {
        public BindingList<string> taskList = new BindingList<string>();

        public void FetchLogin()
        {
            if (getUserData.PreLogUser == "" || getUserData.PreLogUser == "")
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
                    cmd.Parameters.AddWithValue("@Username", getUserData.PreLogUser.ToString());
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        //logins in and shows users dashboard if correct
                        getUserData.UserName = dr[1].ToString();
                        getUserData.UserID = Convert.ToInt32(dr[0].ToString());
                        getUserData.LogPwd = dr[2].ToString();
                    }
                    Load_Data();
                }
            }
            catch (Exception ex)
            {
                //Flags catch if error reaching the database
                MessageBox.Show(ex.Message);
            }
        }

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
                        taskList.Add(newItem);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void AddTask()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    conn.Open();
                    MySqlCommand addtask = new MySqlCommand($"INSERT INTO tasks (user_id, task, completed) VALUES (@userid, @task, 0)", conn);
                    addtask.Parameters.AddWithValue(@"userid", getUserData.UserID);
                    addtask.Parameters.AddWithValue("@task", GetTask.TaskText);
                    addtask.ExecuteNonQuery();
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
                    MySqlCommand dltask = new MySqlCommand($"DELETE FROM tasks WHERE user_id = @userid", conn);
                    dltask.Parameters.AddWithValue("@userid", getUserData.UserID);
                    dltask.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
