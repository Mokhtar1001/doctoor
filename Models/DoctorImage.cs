using Microsoft.EntityFrameworkCore;

namespace EHospital.Models
{
    [PrimaryKey(nameof(DoctorId), nameof(Image))]
    public class DoctorImage
    {
        public int DoctorId { get; set; }
        public string Image { get; set; }
    }
}
