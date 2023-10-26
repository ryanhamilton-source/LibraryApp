using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVer_Assignment_2
{
    public class Librarian
    {
        private int id;
        private string password;
        private string name;
        private string email;
        private string phone;
        private string address;

        public Librarian(int id, string password, string name, string email, string phone, string address)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }
        public bool HasID(int id)
        {
            return id.Equals(this.id);
        }

        public bool HasPass(string password)
        {
            return password.Equals(this.password);
        }

        public int GetId() { return id; }
        public string GetPassword() { return password; }
        public string GetName() { return name; }
        public string GetEmail() { return email; }
        public string GetPhone() { return phone; }
        public string GetAddress() { return address; }
    }
}
