using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVer_Assignment_2
{
    public class Admin
    {
        private int id { get; set; }
        private string password { get; set; }
        private string name { get; set; }

        public Admin(int id, string password, string name)
        {
            this.id = id;
            this.password = password;
            this.name = name;
        }
        public bool HasID(int id)
        {
            return id.Equals(this.id);
        }

        public bool HasPass(string password)
        {
            return password.Equals(this.password);
        }
    }
}
