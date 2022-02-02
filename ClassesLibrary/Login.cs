using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        private string _userName;
        private string _password;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //FQTOR
        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        //Default un-QTOR
        public Login() { }

        //ToString()
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Username: {0} " +
                "\nPassword: {1}\n",
                UserName, Password);

        }
    }
}
