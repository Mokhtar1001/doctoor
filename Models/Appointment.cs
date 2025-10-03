namespace EHospital.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;

        public string? PatientName { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool IsBooked { get; set; } = false;
    }
}
