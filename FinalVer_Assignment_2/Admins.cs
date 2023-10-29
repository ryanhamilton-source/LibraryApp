using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVer_Assignment_2
{
    public class Admins
    {
        private List<Admin> admins = new List<Admin>();
        public Admins(string filepath)
        {

            LoadAdmins(filepath);
        }
        public void LoadAdmins(string filepath)
        {
            try
            {
                // clear existing data in admins list
                admins.Clear();

                // Read all lines from admin.txt text file
                string[] lines = File.ReadAllLines(filepath);

                foreach (string line in lines)
                {
                    //split the line into fields using comma ','
                    string[] fields = line.Split(',');

                    if (fields.Length == 3)
                    {
                        //set id and password to fields[0] and fields[1]
                        //using try catch to check if id is integer
                        try
                        {
                            int id = int.Parse(fields[0]);
                            string password = fields[1];
                            string name = fields[2];

                            //Add admins data into list
                            admins.Add(new Admin(id, password, name));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("id needs to be integer: {0}", fields[0]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("admin file doesnt exist.", e);
            }
        }
        public Admin? Admin(int id, string password)
        {
            foreach (Admin admin in admins)
            {
                if (admin.HasID(id) && admin.HasPass(password))
                {
                    return admin;
                }
            }
            return null;
        }
    }
}
