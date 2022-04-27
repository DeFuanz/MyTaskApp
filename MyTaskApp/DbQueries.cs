using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskApp
{
    public class DbQueries
    {
        public List<string> tasks = new List<string>();
        //Fetches login information and stores user data such as name/ID for later use.
        public void LoginQuery(string user)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    string checkLogin = $"SELECT * FROM appusers WHERE username = @Username";
                    MySqlCommand cmd = new MySqlCommand(checkLogin, conn);
                    cmd.Parameters.AddWithValue("@Username", user.Trim());

                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        getUserData.UserName = dr[1].ToString();
                        getUserData.Password = dr[2].ToString();
                        getUserData.UserID = Convert.ToInt32(dr[0].ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        //Checks to see if the entered username is already existing
        public void CheckAccCreate(string user)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    conn.Open();

                    //Checks to see if the username already exists before inserting into database
                    string CheckUser = $"SELECT COUNT(*) FROM appusers WHERE Username = '{ user }'";
                    MySqlCommand checkcmd = new MySqlCommand(CheckUser, conn);
                    int checkedUser = Convert.ToInt32(checkcmd.ExecuteScalar());
                    if (checkedUser == 0)
                    {
                        checkNewAccData.UserExists = 1;
                    }
                    else
                    {
                        checkNewAccData.UserExists = 0;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        //Inserts new username and password into database
        public void CreateAcc(string user, string pwd)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    conn.Open();
                    string insert = $"INSERT INTO appusers (username, passwd) VALUES ('{user}','{pwd}')";
                    MySqlCommand incmd = new MySqlCommand(insert, conn);
                    incmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }
        }

        public void LoadTasks(int userid)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    //Opens connection and loads all uncompleted tasks associated with the logged in user
                    conn.Open();
                    MySqlCommand ldtask = new MySqlCommand($"SELECT task FROM tasks WHERE user_id = @userid AND completed = 0", conn);
                    ldtask.Parameters.AddWithValue("@userid", userid);
                    MySqlDataReader dr = ldtask.ExecuteReader();
                    while (dr.Read())
                    {
                        string taskItem = dr["task"].ToString();
                        tasks.Remove(taskItem);
                        tasks.Add(taskItem);
                    }

                }
            }
            catch (Exception)
            {
            }
        }

        public void InsertTask(string task)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    conn.Open();
                    MySqlCommand addtask = new MySqlCommand($"INSERT INTO tasks (user_id, task, completed) VALUES (@userid, @task, 0)", conn);
                    addtask.Parameters.AddWithValue(@"userid", getUserData.UserID);
                    addtask.Parameters.AddWithValue("@task", task);
                    addtask.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }
        }

        public void DeleteTasks(int userid)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {
                    conn.Open();
                    MySqlCommand dltask = new MySqlCommand($"DELETE FROM tasks WHERE user_id = @userid", conn);
                    dltask.Parameters.AddWithValue("@userid", userid);
                    dltask.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }
        }

        public void UpdateTaskComp(string selectedtask)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(helpconn.conVal("taskdb")))
                {

                    conn.Open();
                    MySqlCommand fintask = new MySqlCommand($"UPDATE tasks SET completed = 1 WHERE task = @checked", conn);
                    fintask.Parameters.AddWithValue("@checked", selectedtask);
                    fintask.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {
            }
        }
    }
}
