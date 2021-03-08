using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzyfratorUI
{
    public class Passwords
    {
        private static string pwd = "";

        public static string getPassword()
        {
            return pwd;
        }

        public static bool setPassword(string pass)
        {
            pwd = pass;
            return true;
        }

        public int index
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string login
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }
        public string email
        {
            get;
            set;
        }
        public string notes
        {
            get;
            set;
        }
    }
}
