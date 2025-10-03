namespace EHospital.Models
{
    public class docPatient
    {
        public int DoctorId { get; set; }
        public Doctor Doctors { get; set; }
        public int PatientId { get; set; }
        public Patient Patients { get; set; }

    }
}
