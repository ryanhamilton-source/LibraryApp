namespace FinalVer_Assignment_1;
class Program
{
    public static Patients patients = new Patients("patient.txt");
    public static Doctors doctors = new Doctors("doctor.txt");
    public static Admins admins = new Admins("admin.txt");
    public static Appointments appointments = new Appointments("appointment.txt");

    static void Main(string[] args)
    {
        Login login = new Login();
        login.use();
    }
}

