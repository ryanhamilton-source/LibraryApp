using System;
using System.Numerics;

namespace FinalVer_Assignment_1
{
	public class Login
	{
        public enum Roles
        {
            Admin,
            Doctor,
            Patient,
            Unknown
        }

        public Login()
        {
        }

        public void use()
        {
            while (true)
            {
                Console.Clear();
                Utils.MenuHeader("Login");
                int id = ReadID();
                string password = ReadPass();

                Roles role = IdentifyRole(id, password);

                if (role != Roles.Unknown)
                {
                    var authenticateUser = GetAuthenticatedUser(role, id, password);

                    if (authenticateUser != null)
                    {
                        Console.WriteLine("Valid Credentials");
                        Console.ReadKey();
                        Console.Clear();

                        switch (role)
                        {
                            case Roles.Admin:
                                ((Admin)authenticateUser).Menu();
                                break;
                            case Roles.Doctor:
                                ((Doctor)authenticateUser).Menu();
                                break;
                            case Roles.Patient:
                                ((Patient)authenticateUser).Menu();
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Credentials. Please try again.");
                    Console.ReadKey();
                }
            }
        }

        private object? GetAuthenticatedUser(Roles role, int id, string password)
        {
            switch (role)
            {
                case Roles.Admin:
                    return Program.admins.Admin(id, password);
                case Roles.Doctor:
                    return Program.doctors.Doctor(id, password);
                case Roles.Patient:
                    return Program.patients.Patient(id, password);
                default:
                    return null;
            }
        }

        private Roles IdentifyRole(int id, string password)
        {

            //check if user is an admin
            if (Program.admins.Admin(id, password) != null)
            {
                return Roles.Admin;
            }
            if (Program.doctors.Doctor(id, password) != null)
            {
                return Roles.Doctor;
            }
            if (Program.patients.Patient(id, password) != null)
            {
                return Roles.Patient;
            }
            return Roles.Unknown;
        }

        private int ReadID()
        {
            return Utils.GetInt("ID");
        }

        private string ReadPass()
        {
            return Utils.GetPass("Password");
        }
    }
}

