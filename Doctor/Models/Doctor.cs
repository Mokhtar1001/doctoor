using Doctor.Models;

namespace Doctor.Models
{
    public class doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Specialty { get; set; } = null!;
        public string imgUrl { get; set; }
        public List<Appointment> Appointments { get; set; } = new();
    }
}
