using System;
namespace FinalVer_Assignment_1
{
	public class Doctor
	{
        private int id;
        private string password;
        private string name;
        private string email;
        private string phone;
        private string address;

        public Doctor(int id, string password, string name, string email, string phone, string address)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }

        public Login.Roles IdentifyRole()
        {
            return Login.Roles.Doctor;
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Utils.MenuHeader("Doctor Menu");
                help();
                int choice = readChoice();
                if (choice >= 1 && choice <= 8)
                {
                    switch (choice)
                    {
                        case 1:
                            ListDoctorDetails();
                            break;
                        case 2:
                            ListPatients();
                            break;
                        case 3:
                            ListAppointments();
                            break;
                        case 4:
                            CheckParticularPatient();
                            break;
                        case 5:
                            ListAppointmentsWithPatient();
                            break;
                        case 6:
                            return;
                        case 7:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }

        public void ListAppointmentsWithPatient()
        {
            Console.Clear();
            Utils.MenuHeader("Appointments With");

            int id = Utils.GetInt("Enter the ID of the patient you would like to view appointments for");
            List<Appointment> patientAppointments = GetPatientAppointments(id);

            if (patientAppointments.Count == 0)
            {
                Console.WriteLine("No appointments found for the specified patient.");
            }
            else
            {
                Utils.AppointmentDetailHeader();
                foreach (Appointment appointment in patientAppointments)
                {
                    Console.WriteLine(appointment.ToString());
                }
            }
            Console.ReadKey();
        }

        public void CheckParticularPatient()
        {
            Console.Clear();
            Utils.MenuHeader("Check Patient Details");

            int id = Utils.GetInt("Enter the ID of the patient to check");
            List<Patient> patients = LoadPatientsData();
            Patient? patient = patients.FirstOrDefault(p => p.GetId() == id);

            if (patient != null)
            {
                Utils.PatientHeader();
                Console.WriteLine(patient.ToString());
            }
            else
            {
                Console.WriteLine("No patients found.");
            }
            Console.ReadKey();
        }

        public void ListAppointments()
        {
            Console.Clear();
            Utils.MenuHeader("My Appointments");

            List<Appointment> doctorAppointments = GetDoctorAppointments();
            Utils.AppointmentDetailHeader();
            if (doctorAppointments.Count == 0)
            {
                Console.WriteLine("No appointments from patient.");
            }
            else
            {
                foreach (Appointment appointment in doctorAppointments)
                {
                    Console.WriteLine(appointment.ToString());
                }
            }
            Console.ReadKey();
        }

        public void ListPatients()
        {
            Console.Clear();
            Utils.MenuHeader("My Patients");

            Console.WriteLine("\nPatients assigned to {0}", name);
            List<Patient> registeredPatients = GetRegisteredPatients();
            Utils.PatientHeader();
            if (registeredPatients.Count == 0)
            {
                Console.WriteLine("No patients found.");
            }
            else
            {
                foreach (Patient patient in registeredPatients)
                {
                    Console.WriteLine(patient.ToString());
                }
            }

            Console.ReadKey();
        }

        private List<Patient> GetRegisteredPatients()
        {
            List<Patient> registeredPatients = new List<Patient>();
            List<Appointment> allAppointments = LoadAppointmentsData();
            List<Appointment> doctorAppointments = GetDoctorAppointments();
            List<int> patientIds = doctorAppointments.Select(appointment => appointment.GetPatientId()).Distinct().ToList();

            List<Patient> patients = LoadPatientsData();
            foreach (int patientId in patientIds)
            {
                Patient? patient = patients.FirstOrDefault(p => p.GetId() == patientId);
                if (patient != null)
                {
                    registeredPatients.Add(patient);
                }
            }
            return registeredPatients;
        }

        private List<Appointment> GetPatientAppointments(int patientId)
        {
            List<Appointment> doctorAppointments = GetDoctorAppointments();
            List<Appointment> patientAppointments = doctorAppointments.Where(appointment => appointment.GetPatientId() == patientId).ToList();
            return patientAppointments;
        }

        private List<Appointment> GetDoctorAppointments()
        {
            List<Appointment> allAppointments = LoadAppointmentsData();
            List<Appointment> doctorAppointments = allAppointments.Where(appointment => appointment.GetDoctorId() == id).ToList();

            return doctorAppointments;
        }

        private List<Patient> LoadPatientsData()
        {
            return Program.patients.GetPatientsList();
        }

        private List<Appointment> LoadAppointmentsData()
        {
            return Program.appointments.GetAppointmentsList();
        }

        public void ListDoctorDetails()
        {
            Console.Clear();
            Utils.MenuHeader("My Details");
            Utils.UserDetailHeader();
            Console.WriteLine(this.ToString());
            Console.ReadKey();
        }

        private int readChoice()
        {
            return Utils.GetInt("choice");
        }

        public override string ToString()
        {
            return string.Format(Utils.UserDetailsFormat, name, email, phone, address);
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

        public void help()
        {
            Console.WriteLine("Welcome to DOTNET Hospital Management System {0}\n", name);

            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("1. List doctor details");
            Console.WriteLine("2. List patients");
            Console.WriteLine("3. List appointments");
            Console.WriteLine("4. Check particular patient");
            Console.WriteLine("5. List appointments with patient");
            Console.WriteLine("6. Log Out");
            Console.WriteLine("7. Exit");
        }
    }
}

