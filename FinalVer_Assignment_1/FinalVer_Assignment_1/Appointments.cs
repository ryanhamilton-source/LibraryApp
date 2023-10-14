using System;
namespace FinalVer_Assignment_1
{
	public class Appointments
	{
        private List<Appointment> appointments = new List<Appointment>();

        public Appointments(string filepath)
        {
            LoadAppointments(filepath);
        }

        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }

        public List<Appointment> GetAppointmentsList()
        {
            return appointments;
        }

        public void SaveAppointmentsToFile(string filepath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    foreach (Appointment appointment in appointments)
                    {
                        // Format the appointment details as a string and write to the file
                        string appointmentData = $"{appointment.GetDoctorId()},{appointment.GetPatientId()},{appointment.GetDoctorName()},{appointment.GetPatientName()},{appointment.GetDescription()}";
                        writer.WriteLine(appointmentData);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while saving appointments: " + e.Message);
            }
        }

        public void LoadAppointments(string filepath)
        {
            try
            {
                // clear existing data in appointments list
                appointments.Clear();

                // Read all lines from appointment.txt text file
                string[] lines = File.ReadAllLines(filepath);

                foreach (string line in lines)
                {
                    //split the line into fields using comma ','
                    string[] fields = line.Split(',');

                    if (fields.Length == 5)
                    {
                        //set id and password to fields[0] and fields[1]
                        //using try catch to check if id is integer
                        try
                        {
                            int docId = int.Parse(fields[0]);
                            int patId = int.Parse(fields[1]);
                            string docName = fields[2];
                            string patName = fields[3];
                            string description = fields[4];
                            //Add admins data into list
                            appointments.Add(new Appointment(docId, patId, docName, patName, description));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invallid appointment data");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("admin file doesnt exist.", e);
            }
        }
    }
}

