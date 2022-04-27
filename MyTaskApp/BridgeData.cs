using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyTaskApp
{
    //This file contains the methods that will be called in the UI to connect/manipulate dataqueries when called
    public class BridgeData
    {
        readonly DbQueries dq = new DbQueries();

        public int VerifyLogin(string enteredUser, string enteredPass)
        {
            if (enteredUser == "" || enteredPass == "")
            {

                return 0;
            }
            else
            {
                dq.LoginQuery(enteredUser);
                if (enteredUser == getUserData.UserName && enteredPass == getUserData.Password)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int CreateAccount(string enteredUser, string enteredPass)
        {

            if (enteredUser == "" || enteredPass == "")
            {
                return 0;
            }
            else
            {
                dq.CheckAccCreate(enteredUser);
                if (checkNewAccData.UserExists == 1)
                {
                    dq.CreateAcc(enteredUser, enteredPass);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public List<string> PopulateTasks(int userid)
        {
            dq.LoadTasks(userid);
            List<string> tasks = new List<string>();
            foreach (string tsk in dq.tasks)
            {
                tasks.Add(tsk);
            }
            return tasks;
        }

        public int SubmitTask(string task)
        {
            if (task == "")
            {
                return 0;
            }
            else
            {
                grabTask.TaskItem = task;
                dq.InsertTask(grabTask.TaskItem);
                return 1;
            }
        }

        public void ClearTasks(int userid)
        {
            dq.DeleteTasks(userid);
            dq.tasks.Clear();
            PopulateTasks(userid);
        }

        public void MarkCompleteTask(string selectedtask)
        {
            dq.tasks.Remove(selectedtask);
            dq.UpdateTaskComp(selectedtask);
        }
    }
}

