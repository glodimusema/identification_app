using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identification_app.Classes
{
    class clsUser
    {
        int id;
        string username;
        string passwords;
        string niveau;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Passwords { get => passwords; set => passwords = value; }
        public string Niveau { get => niveau; set => niveau = value; }
    }
}
