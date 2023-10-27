using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVer_Assignment_2
{
    public class Users
    {
        private List<User> users = new List<User>();

        public Users(string filepath)
        {
            LoadUsers(filepath);
        }
        public void LoadUsers(string filepath)
        {
            try
            {
                // clear existing data in users list
                users.Clear();

                // Read all lines from users.txt text file
                string[] lines = File.ReadAllLines(filepath);

                foreach (string line in lines)
                {
                    //split the line into fields using comma ','
                    string[] fields = line.Split(',');

                    if (fields.Length == 6)
                    {
                        //set id, password, name to fields[0], fields[1], etc...
                        //using try catch to check if id is integer
                        try
                        {
                            int id = int.Parse(fields[0]);
                            string password = fields[1];
                            string name = fields[2];
                            string email = fields[3];
                            string phone = fields[4];
                            string address = fields[5];

                            //Add user data into list
                            users.Add(new User(id, password, name, email, phone, address));
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
                Console.WriteLine("user file doesnt exist.", e);
            }
        }
        public void AppendUser(User user, string filepath)
        {
            try
            {

                // Create a new line with patient's data
                string newUserLine = $"{user.GetId()},{user.GetPassword()},{user.GetName()},{user.GetEmail()},{user.GetPhone()},{user.GetAddress()}";

                // Check if the file already exists
                if (File.Exists(filepath))
                {
                    if (new FileInfo(filepath).Length > 0)
                    {
                        // File exists and is not empty, append the new line
                        File.AppendAllText(filepath, Environment.NewLine + newUserLine);
                    }
                    else
                    {
                        // File exists but is empty, write the new line without a newline
                        File.WriteAllText(filepath, newUserLine);
                    }
                }
                else
                {
                    // File doesn't exist, create it and write the new line
                    File.WriteAllText(filepath, newUserLine);
                }
            }
            catch (Exception e)
            {
                // Log the exception details for debugging and troubleshooting
                Console.WriteLine("An error occurred while appending the user data: " + e.Message);
                // You can also log the stack trace: Console.WriteLine("Exception Stack Trace: " + e.StackTrace);
            }
        }
        public List<User> GetUsersList()
        {
            return users;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User? User(int id, string password)
        {
            foreach (User user in users)
            {
                if (user.HasID(id) && user.HasPass(password))
                {
                    return user;
                }
            }
            return null;
        }
    }
}
