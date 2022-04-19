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
    }
}
