using System;
using System.Xml.Linq;

namespace FinalVer_Assignment_1
{
	public class Patients
	{
        private List<Patient> patients = new List<Patient>();

        public Patients(string filepath)
        {
            LoadPatients(filepath);
        }

        public void LoadPatients(string filepath)
        {
            try
            {
                // clear existing data in patients list
                patients.Clear();

                // Read all lines from patients.txt text file
                string[] lines = File.ReadAllLines(filepath);

                foreach (string line in lines)
                {
                    //split the line into fields using comma ','
                    string[] fields = line.Split(',');

                    if (fields.Length == 7)
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
                            string doctorName = fields[6];

                            //Add patients data into list
                            patients.Add(new Patient(id, password, name, email, phone, address, doctorName));
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
                Console.WriteLine("patient file doesnt exist.", e);
            }
        }

        public void AppendPatient(Patient patient, string filepath)
        {
            try
            {

                // Create a new line with patient's data
                string newPatientLine = $"{patient.GetId()},{patient.GetPassword()},{patient.GetName()},{patient.GetEmail()},{patient.GetPhone()},{patient.GetAddress()},{patient.GetDoctorName()}";

                // Check if the file already exists
                if (File.Exists(filepath))
                {
                    if (new FileInfo(filepath).Length > 0)
                    {
                        // File exists and is not empty, append the new line
                        File.AppendAllText(filepath, Environment.NewLine + newPatientLine);
                    }
                    else
                    {
                        // File exists but is empty, write the new line without a newline
                        File.WriteAllText(filepath, newPatientLine);
                    }
                }
                else
                {
                    // File doesn't exist, create it and write the new line
                    File.WriteAllText(filepath, newPatientLine);
                }
            }
            catch (Exception e)
            {
                // Log the exception details for debugging and troubleshooting
                Console.WriteLine("An error occurred while appending the patient data: " + e.Message);
                // You can also log the stack trace: Console.WriteLine("Exception Stack Trace: " + e.StackTrace);
            }
        }

        public void UpdatePatientFile(Patient patient, string filepath)
        {
            try
            {
                List<string> updatedLines = new List<string>();

                foreach (Patient existingPatient in patients)
                {
                    if (existingPatient.GetId() == patient.GetId())
                    {
                        // Update the patient's data
                        existingPatient.SetName(patient.GetName());
                        existingPatient.SetEmail(patient.GetEmail());
                        existingPatient.SetPhone(patient.GetPhone());
                        existingPatient.SetAddress(patient.GetAddress());
                        existingPatient.SetDoctorName(patient.GetDoctorName()); // Update doctor's name

                        // Add the updated patient data as a line
                        string updatedLine = $"{existingPatient.GetId()},{existingPatient.GetPassword()},{existingPatient.GetName()},{existingPatient.GetEmail()},{existingPatient.GetPhone()},{existingPatient.GetAddress()},{existingPatient.GetDoctorName()}";
                        updatedLines.Add(updatedLine);
                    }
                    else
                    {
                        // Keep the existing patient data as it is
                        string existingLine = $"{existingPatient.GetId()},{existingPatient.GetPassword()},{existingPatient.GetName()},{existingPatient.GetEmail()},{existingPatient.GetPhone()},{existingPatient.GetAddress()},{existingPatient.GetDoctorName()}";
                        updatedLines.Add(existingLine);
                    }
                }

                // Write the updated patient data back to the file
                File.WriteAllLines(filepath, updatedLines);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while updating the patient file: " + e.Message);
            }
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public List<Patient> GetPatientsList()
        {
            return patients;
        }

        public Patient? Patient(int id, string password)
        {
            foreach (Patient patient in patients)
            {
                if (patient.HasID(id) && patient.HasPass(password))
                {
                    return patient;
                }
            }
            return null;
        }
    }
}

