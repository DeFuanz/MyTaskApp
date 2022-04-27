using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskApp
{
    //This class saves the logged in user as well as username to use throughout the app
    class getUserData
    {
        private static string un;
        private static int uid;
        private static string pwd;

        public static string UserName
        {
            get { return un; }
            set { un = value; }
        }

        public static int UserID
        {
            get { return uid; }
            set { uid = value; }
        }

        public static string Password
        {
            get { return pwd; }
            set { pwd = value; }
        }
    }

    //This class contains a 0/1 depending on if the sql query shows the username already exists or not
    class checkNewAccData
    {
        private static int UE;

        public static int UserExists
        {
            get { return UE; }
            set { UE = value; }
        }
    }

    class grabTask
    {
        private static string tsk;
        public static string TaskItem
        {
            get { return tsk; }
            set { tsk = value; }
        }
    }
}
