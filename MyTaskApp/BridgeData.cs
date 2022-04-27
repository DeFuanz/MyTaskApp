using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyTaskApp
{
    //This file contains the logical side that munipulates queries and produces results for the UI
    public class BridgeData
    {
        DbQueries dq = new DbQueries();

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
    }
}
