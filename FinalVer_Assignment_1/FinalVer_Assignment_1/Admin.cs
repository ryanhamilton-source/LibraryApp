using System;
using System.Text.RegularExpressions;

namespace FinalVer_Assignment_1
{
	public class Admin
	{
        private int id { get; set; }
        private string password { get; set; }
        private string name { get; set; }
        private int nextPatientId = 30000;
        private int nextDoctorId = 20000;

        public Admin(int id, string password, string name)
        {
            this.id = id;
            this.password = password;
            this.name = name;
        }

        public Login.Roles IdentifyRole()
        {
            return Login.Roles.Admin;
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Utils.MenuHeader("Administrator Menu");
                help();
                int choice = readChoice();
                if (choice >= 1 && choice <= 8)
                {
                    switch (choice)
                    {
                        case 1:
                            ListAllDoctors();
                            break;
                        case 2:
                            CheckDoctorDetails();
                            break;
                        case 3:
                            ListAllPatients();
                            break;
                        case 4:
                            CheckPatientDetails();
                            break;
                        case 5:
                            AddDoctor();
                            break;
                        case 6:
                            AddPatient();
                            break;
                        case 7:
                            return;
                        case 8:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }

        public void AddDoctor()
        {
            Console.Clear();
            Utils.MenuHeader("Add Doctor");

            // Generate a unique doctor ID
            int doctorId = GenerateUniqueDoctorId();

            // Generate a random password for the new doctor
            string password = GenerateRandomPassword(8); // You can adjust the password length as needed

            // Prompt the user to enter doctor details
            Console.WriteLine("Registering a new doctor with the DOTNET Hospital Management System");

            string firstName = Utils.GetNonEmptyString("First Name");
            string lastName = Utils.GetNonEmptyString("Last Name");

            string email;
            do
            {
                email = Utils.GetNonEmptyString("Email");
                if (!Utils.IsValidEmail(email))
                {
                    Console.WriteLine("Invalid email address. Please enter valid email.");
                }
            } while (!Utils.IsValidEmail(email));

            string phone;
            do
            {
                phone = Utils.GetNonEmptyString("Phone");
                if (!Utils.IsValidPhoneNumber(phone))
                {
                    Console.WriteLine("Invalid phone number. Please enter a valid phone number.");
                }
            } while (!Utils.IsValidPhoneNumber(phone));

            string streetNumber = Utils.GetNonEmptyString("Street Number");
            string street = Utils.GetNonEmptyString("Street");
            string city = Utils.GetNonEmptyString("City");
            string state = Utils.GetNonEmptyString("State");

            // Combine first name and last name into one name field
            string fullName = $"{firstName} {lastName}";

            // Combine street number, street, city, and state into one address field
            string address = $"{streetNumber} {street} {city} {state}";

            // Create a new doctor instance with the entered data
            Doctor doctor = new Doctor(doctorId, password, fullName, email, phone, address);

            // Add the new doctor to the Doctors list
            Program.doctors.AddDoctor(doctor);

            // Save the updated doctor list to the file
            Program.doctors.AppendDoctor(doctor, "doctor.txt");

            Console.WriteLine("{0} added to the system.", fullName);
            Console.ReadKey();
        }

        public void AddPatient()
        {
            Console.Clear();
            Utils.MenuHeader("Add Patient");

            // Generate a unique patient ID
            int patientId = GenerateUniquePatientId();

            // Generate a random password for the new patient
            string password = GenerateRandomPassword(8); // You can adjust the password length as needed

            // Prompt the user to enter patient details
            Console.WriteLine("Registering a new patient with the DOTNET Hospital Management System");

            string firstName = Utils.GetNonEmptyString("First Name");
            string lastName = Utils.GetNonEmptyString("Last Name");

            string email;
            do
            {
                email = Utils.GetNonEmptyString("Email");
                if (!Utils.IsValidEmail(email))
                {
                    Console.WriteLine("Invalid email address. Please enter valid email.");
                }
            } while (!Utils.IsValidEmail(email));

            string phone;
            do
            {
                phone = Utils.GetNonEmptyString("Phone");
                if (!Utils.IsValidPhoneNumber(phone))
                {
                    Console.WriteLine("Invalid phone number. Please enter a valid phone number.");
                }
            } while (!Utils.IsValidPhoneNumber(phone));

            string streetNumber = Utils.GetNonEmptyString("Street Number");
            string street = Utils.GetNonEmptyString("Street");
            string city = Utils.GetNonEmptyString("City");
            string state = Utils.GetNonEmptyString("State");
            string doctorName = "";

            // Combine first name and last name into one name field
            string fullName = $"{firstName} {lastName}";

            // Combine street number, street, city, and state into one address field
            string address = $"{streetNumber} {street} {city} {state}";

            // Create a new patient instance with the entered data
            Patient patient = new Patient(patientId, password, fullName, email, phone, address, doctorName);

            // Add the new patient to the Patients list
            Program.patients.AddPatient(patient);

            // Save the updated patient list to the file
            Program.patients.AppendPatient(patient, "patient.txt");

            Console.WriteLine("{0} added to the system.", fullName);
            Console.ReadKey();
        }

        public void CheckPatientDetails()
        {
            Console.Clear();
            Utils.MenuHeader("Patient Details");

            int id = Utils.GetInt("Please enter the ID of the patient who's details you are checking");
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

        public void ListAllPatients()
        {
            Console.Clear();
            Utils.MenuHeader("All Patients");
            Console.WriteLine("\nAll patients registered to the DOTNET Hospital Management System");
            List<Patient> patients = LoadPatientsData();
            if (patients.Count == 0)
            {
                Console.WriteLine("No patients found.");
            }
            else
            {
                Utils.PatientHeader();
                foreach (Patient patient in patients)
                {
                    Console.WriteLine(patient.ToString());
                }
            }
            Console.ReadKey();
        }

        public void CheckDoctorDetails()
        {
            Console.Clear();
            Utils.MenuHeader("Doctor Details");

            int id = Utils.GetInt("Please enter the ID of the doctor who's details you are checking");
            List<Doctor> doctors = LoadDoctorsData();
            Doctor? doctor = doctors.FirstOrDefault(p => p.GetId() == id);

            if (doctor != null)
            {
                Utils.UserDetailHeader();
                Console.WriteLine(doctor.ToString());
            }
            else
            {
                Console.WriteLine("No doctors found.");
            }
            Console.ReadKey();
        }

        public void ListAllDoctors()
        {
            Console.Clear();
            Utils.MenuHeader("All Doctors");
            Console.WriteLine("\nAll doctors registered to the DOTNET Hospital Management System");
            List<Doctor> doctors = LoadDoctorsData();
            if (doctors.Count == 0)
            {
                Console.WriteLine("No doctors found.");
            }
            else
            {
                Utils.UserDetailHeader();
                foreach (Doctor doctor in doctors)
                {
                    Console.WriteLine(doctor.ToString());
                }
            }
            Console.ReadKey();
        }

        private List<Doctor> LoadDoctorsData()
        {
            return Program.doctors.GetDoctorsList();
        }

        private List<Patient> LoadPatientsData()
        {
            return Program.patients.GetPatientsList();
        }

        private int GenerateUniqueDoctorId()
        {
            List<Doctor> doctors = LoadDoctorsData();
            if (doctors.Count == 0)
            {
                return nextDoctorId;
            }
            int maxId = doctors.Max(doctor => doctor.GetId());
            nextDoctorId = Math.Max(nextDoctorId, maxId + 1);
            int newId = nextDoctorId;

            return newId;
        }

        private int GenerateUniquePatientId()
        {
            List<Patient> patients = LoadPatientsData();
            if (patients.Count == 0)
            {
                return nextPatientId;
            }
            int maxId = patients.Max(patient => patient.GetId());
            nextPatientId = Math.Max(nextPatientId, maxId + 1);
            int newId = nextPatientId;

            return newId;
        }

        private string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string password = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)])
                .ToArray());

            return password;
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

        public void help()
        {
            Console.WriteLine("Welcome to DOTNET Hospital Management System {0}\n", name);

            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("1. List all doctors");
            Console.WriteLine("2. Check doctor details");
            Console.WriteLine("3. List all patients");
            Console.WriteLine("4. Check patient details");
            Console.WriteLine("5. Add doctor");
            Console.WriteLine("6. Add patient");
            Console.WriteLine("7. Log Out");
            Console.WriteLine("8. Exit");
        }
    }
}

