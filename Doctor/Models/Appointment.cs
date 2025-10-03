using Doctor.Models;

namespace Doctor.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }
        public doctor Doctor { get; set; } = null!;

        public string? PatientName { get; set; }

        public DateTime Date { get; set; }
        public TimeSpan time { get; set; }

        public bool IsBooked { get; set; } = false;
        public TimeSpan StartTime { get; internal set; }
    }
}
