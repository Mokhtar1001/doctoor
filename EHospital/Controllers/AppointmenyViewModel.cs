namespace EHospital.Controllers
{
    public class AppointmentViewModel
    {
        public int AppointmentId { get; set; } // لو عايز تعدل أو تكمل appointment موجود
        public string PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
    }
}
