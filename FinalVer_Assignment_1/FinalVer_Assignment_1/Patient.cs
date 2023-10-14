using System;
using System.Numerics;

namespace FinalVer_Assignment_1
{
	public class Patient
	{
        private int id;
        private string password;
        private string name;
        private string email;
        private string phone;
        private string address;
        private string doctorName;

        public Patient(int id, string password, string name, string email, string phone, string address, string doctorName = "")
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.doctorName = doctorName;
        }

        public Login.Roles IdentifyRole()
        {
            return Login.Roles.Patient;
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Utils.MenuHeader("Patient Menu");
                help();
                int choice = readChoice();
                if (choice >= 1 && choice <= 6)
                {
                    switch (choice)
                    {
                        case 1:
                            ListPatientDetails();
                            break;
                        case 2:
                            ListDoctorDetails();
                            break;
                        case 3:
                            ListAllAppointments();
                            break;
                        case 4:
                            BookAppointment();
                            break;
                        case 5:
                            return;
                        case 6:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }

        public void ListAllAppointments()
        {
            Console.Clear();
            Utils.MenuHeader("My Appointments");

            Console.WriteLine("\nAppointments for {0}", name);
            Utils.AppointmentDetailHeader();
            List<Appointment> patientAppointments = GetPatientAppointments();
            if (patientAppointments.Count == 0)
            {
                Console.WriteLine("You dont have any appointments with doctors.");
            }
            else
            {
                foreach (Appointment appointment in patientAppointments)
                {
                    Console.WriteLine(appointment.ToString());
                }
            }

            Console.ReadKey();
        }

        public void ListDoctorDetails()
        {
            Console.Clear();
            Utils.MenuHeader("My Doctor");

            int patientDoctorId = GetPatientDoctorId();
            Doctor? patientDoctor = GetDoctorById(patientDoctorId);
            if (patientDoctor != null)
            {
                Console.WriteLine("\nYour doctor:");
                Utils.UserDetailHeader();
                Console.WriteLine(patientDoctor.ToString());
            }
            else
            {
                Console.WriteLine("No doctors found.");
            }
            Console.ReadKey();
        }

        public void BookAppointment()
        {
            Console.Clear();
            Utils.MenuHeader("Book Appointment");

            if (!RegisteredDoctor(id))
            {
                // If the patient is not registered with any doctor, allow them to choose a doctor
                List<Doctor> availableDoctors = LoadDoctorsData();

                Console.WriteLine("You are not registered with any doctor. Please choose which doctor you would like to register with:");

                for (int i = 0; i < availableDoctors.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {availableDoctors[i]}");
                }

                int choice = Utils.GetInt("Please choose a doctor");

                if (choice >= 1 && choice <= availableDoctors.Count)
                {
                    Doctor selectedDoctor = availableDoctors[choice - 1];
                    doctorName = selectedDoctor.GetName();
                    string description = string.Empty;
                    while (true)
                    {
                        description = Utils.GetString("Description of the appointment");
                        if (!string.IsNullOrWhiteSpace(description))
                        {
                            UpdateDoctorNameInPatientFile(id, doctorName);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Description cannot be empty or white space. Please select doctor again.");
                            Console.ReadKey();
                            return;
                        }
                    }
                    // Create a new appointment and add it to the list
                    Appointment appointment = new Appointment(selectedDoctor.GetId(), id, selectedDoctor.GetName(), name, description);
                    Program.appointments.AddAppointment(appointment);

                    Console.WriteLine("The appointment has been booked successfully.");
                    Program.appointments.SaveAppointmentsToFile("appointment.txt"); // Save the updated list to the file
                }
                else
                {
                    Console.WriteLine("Invalid doctor selection.");
                }
            }
            else
            {
                // If the patient is already registered with a doctor, book an appointment with that doctor
                int patientDoctorId = GetPatientDoctorId();

                Doctor? patientDoctor = GetDoctorById(patientDoctorId);

                if (patientDoctor != null)
                {
                    Console.WriteLine($"You are booking a new appointment with {patientDoctor.GetName()}");
                    string description = string.Empty;
                    while (true)
                    {
                        description = Utils.GetString("Description of the appointment");
                        if (!string.IsNullOrWhiteSpace(description))
                        {
                            UpdateDoctorNameInPatientFile(id, doctorName);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Description cannot be empty or white space. Please select doctor again.");
                            Console.ReadKey();
                            return;
                        }
                    } // Prompt for description
                      // Create a new appointment and add it to the list
                    Appointment appointment = new Appointment(patientDoctor.GetId(), id, patientDoctor.GetName(), name, description);
                    Program.appointments.AddAppointment(appointment);

                    Console.WriteLine("The appointment has been booked successfully.");
                    Program.appointments.SaveAppointmentsToFile("appointment.txt"); // Save the updated list to the file
                }
                else
                {
                    Console.WriteLine("No doctors found. Please try again.");
                }

            }
            Console.ReadKey();
        }

        public void ListPatientDetails()
        {
            Console.Clear();
            Utils.MenuHeader("My Details");
            Console.WriteLine("\n{0}'s Details\n", name);
            Console.WriteLine("Patient ID: {0}", id);
            Console.WriteLine("Full Name: {0}", name);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Email: {0}", email);
            Console.WriteLine("Phone: {0}", phone);
            Console.ReadKey();
        }

        private bool RegisteredDoctor(int patientId)
        {
            List<Appointment> allAppointments = LoadAppointmentsData();
            return allAppointments.Any(appointment => appointment.GetPatientId() == patientId);
        }

        private Doctor? GetDoctorById(int doctorId)
        {
            List<Doctor> allDoctors = LoadDoctorsData();
            return allDoctors.FirstOrDefault(doctor => doctor.GetId() == doctorId);
        }

        private int GetPatientDoctorId()
        {
            List<Appointment> allAppointments = LoadAppointmentsData();
            int PatientDocId = allAppointments.Where(appointment => appointment.GetPatientId() == id).Select(appointment => appointment.GetDoctorId()).FirstOrDefault();
            return PatientDocId;
        }


        private List<Appointment> GetPatientAppointments()
        {
            List<Appointment> allAppointments = LoadAppointmentsData();
            List<Appointment> patientAppointments = allAppointments.Where(appointment => appointment.GetPatientId() == id).ToList();
            return patientAppointments;
        }

        private List<Doctor> LoadDoctorsData()
        {
            return Program.doctors.GetDoctorsList();
        }

        private List<Appointment> LoadAppointmentsData()
        {
            return Program.appointments.GetAppointmentsList();
        }

        private void UpdateDoctorNameInPatientFile(int patientId, string doctorName)
        {
            // Get the patient with the specified ID
            Patient? patientToUpdate = Program.patients.Patient(patientId, password);

            // Update the doctorName property of the patient
            if (patientToUpdate != null)
            {
                patientToUpdate.doctorName = doctorName;

                // Update the patient's data in the patient.txt file
                Program.patients.UpdatePatientFile(patientToUpdate, "patient.txt");
            }
        }

        private int readChoice()
        {
            return Utils.GetInt("choice");
        }
        public bool HasID(int id)
        {
            return id.Equals(this.id);
        }

        public bool HasPass(string password)
        {
            return password.Equals(this.password);
        }
        public int GetId()
        {
            return id;
        }

        public string GetPassword()
        {
            return password;
        }

        public string GetName()
        {
            return name;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetPhone()
        {
            return phone;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetDoctorName()
        {
            return doctorName;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetDoctorName(string doctorName)
        {
            this.doctorName = doctorName;
        }

        public override string ToString()
        {
            return string.Format(Utils.patientsFormat, name, doctorName, email, phone, address);
        }

        public void help()
        {
            Console.WriteLine("Welcome to DOTNET Hospital Management System {0}\n", name);

            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("1. List patient details");
            Console.WriteLine("2. List my doctor details");
            Console.WriteLine("3. List all appointments");
            Console.WriteLine("4. Book appoinment");
            Console.WriteLine("5. Exit to login");
            Console.WriteLine("6. Exit System");
        }
    }
}

