using System;
namespace FinalVer_Assignment_1
{
	public class Appointment
	{
        private int doctorId;
        private int patientId;
        private string doctorName;
        private string patientName;
        private string description;

        public Appointment(int doctorId, int patientId, string doctorName, string patientName, string description)
        {
            this.doctorId = doctorId;
            this.patientId = patientId;
            this.doctorName = doctorName;
            this.patientName = patientName;
            this.description = description;
        }
        public int GetDoctorId()
        {
            return doctorId;
        }

        public int GetPatientId()
        {
            return patientId;
        }

        public string GetDoctorName()
        {
            return doctorName;
        }

        public string GetPatientName()
        {
            return patientName;
        }

        public string GetDescription()
        {
            return description;
        }

        public override string ToString()
        {
            return string.Format(Utils.appointmentDetailsFormat, doctorName, patientName, description);
        }
    }
}

