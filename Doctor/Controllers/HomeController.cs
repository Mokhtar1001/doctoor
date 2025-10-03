using Doctor.Models;
using Doctor.DataAccess;
using Doctor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EHospital.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context = new();
        private ApplicationDbContext context = new ();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          var doctors=  context.doctors.AsQueryable();
            return View(doctors.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult BookAppointment()
        {
            if (_context.doctors is IQueryable<Doctor.Models.doctor> doctorsSet)
            {
                var doctors = doctorsSet.AsSingleQuery();
                return View(doctors.AsEnumerable());
            }
            throw new InvalidOperationException("doctors must be IQueryable<Doctor> or DbSet<Doctor>.");
        }

        public IActionResult ReservationsManagement(string? patientName)
        {
          
            IQueryable<Appointment>? query = _context.appointments as IQueryable<Appointment>
                ?? (_context.appointments as IEnumerable<Appointment>)?.AsQueryable();

            if (query == null)
            {
                throw new InvalidOperationException("appointments must be IQueryable<Appointment> or IEnumerable<Appointment>.");
            }

            if (!string.IsNullOrEmpty(patientName))
            {
                query = query.Where(a => a.PatientName == patientName);
            }

            var appointments = query.ToList();

            return View(appointments);
        }

        public IActionResult CompleteAppointment(Appointment model)
        {
            if (ModelState.IsValid)
            {
                // Use pattern matching for IDE0019
                if (_context.appointments is ICollection<Appointment> appointmentsSet)
                {
                    var appointment = new Appointment
                    {
                        DoctorId = model.DoctorId,
                        PatientName = model.PatientName,
                        time = model.time,
                        Date = model.Date,
                    };

                    appointmentsSet.Add(appointment);
                    _context.SaveChanges();

                    return RedirectToAction("ReservationsManagement");
                }
                throw new InvalidOperationException("appointments must be ICollection<Appointment> or DbSet<Appointment>.");
            }

            return View(model);
        }

        public ViewResult Book()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
