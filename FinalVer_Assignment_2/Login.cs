using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVer_Assignment_2
{
    public class Login
    {
        public enum Roles
        {
            Admin,
            User,
            Librarian,
            Unknown
        }
        public Login()
        {

        }
        public object? GetAuthenticatedUser(Roles role, int id, string password)
        {
            switch (role)
            {
                case Roles.Admin:
                    return Program.admins.Admin(id, password);
                case Roles.User:
                    return Program.users.User(id, password);
                case Roles.Librarian:
                    return Program.librarians.Librarian(id, password);
                default:
                    return null;
            }
        }
        public Roles IdentifyRole(int id, string password)
        {

            //check if user is an admin
            if (Program.admins.Admin(id, password) != null)
            {
                return Roles.Admin;
            }
            if (Program.users.User(id, password) != null)
            {
                return Roles.User;
            }
            if (Program.librarians.Librarian(id, password) != null)
            {
                return Roles.Librarian;
            }

            return Roles.Unknown;

        }
    }
}
