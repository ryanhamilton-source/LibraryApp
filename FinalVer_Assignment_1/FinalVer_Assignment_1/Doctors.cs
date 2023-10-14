using System;
using System.Numerics;

namespace FinalVer_Assignment_1
{
	public class Doctors
    {
        private List<Doctor> doctors = new List<Doctor>();

        public Doctors(string filepath)
        {
            LoadDoctors(filepath);
        }

        public void LoadDoctors(string filepath)
        {
            try
            {
                // clear existing data in doctors list
                doctors.Clear();

                // Read all lines from doctor.txt text file
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

                            //Add doctors data into list
                            doctors.Add(new Doctor(id, password, name, email, phone, address));
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
                Console.WriteLine("doctor file doesnt exist.", e);
            }
        }

        public void AppendDoctor(Doctor doctor, string filepath)
        {
            try
            {
                // Create a new line with patient's data
                string newDoctorLine = $"{doctor.GetId()},{doctor.GetPassword()},{doctor.GetName()},{doctor.GetEmail()},{doctor.GetPhone()},{doctor.GetAddress()}";

                // Check if the file already exists
                if (File.Exists(filepath))
                {
                    if (new FileInfo(filepath).Length > 0)
                    {
                        // File exists and is not empty, append the new line
                        File.AppendAllText(filepath, Environment.NewLine + newDoctorLine);
                    }
                    else
                    {
                        // File exists but is empty, write the new line without a newline
                        File.WriteAllText(filepath, newDoctorLine);
                    }
                }
                else
                {
                    // File doesn't exist, create it and write the new line
                    File.WriteAllText(filepath, newDoctorLine);
                }
            }
            catch (Exception e)
            {
                // Log the exception details for debugging and troubleshooting
                Console.WriteLine("An error occurred while appending the patient data: " + e.Message);
                // You can also log the stack trace: Console.WriteLine("Exception Stack Trace: " + e.StackTrace);
            }
        }

        public Doctor? Doctor(int id, string password)
        {
            foreach (Doctor doctor in doctors)
            {
                if (doctor.HasID(id) && doctor.HasPass(password))
                {
                    return doctor;
                }
            }
            return null;
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public List<Doctor> GetDoctorsList()
        {
            return doctors;
        }
    }
}

