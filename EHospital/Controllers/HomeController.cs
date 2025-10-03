using System.Diagnostics;
using EHospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EHospital.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context = new();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult BookAppointment()
        {
            var doctors = _context.doctors.AsSingleQuery();

            return View(doctors.AsEnumerable());
        }

        public IActionResult ReservationsManagement(string? patientName)
        {
            var query = _context.appointments.AsQueryable();

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
                // ЪЭцэс ViewModel см Appointment
                var appointment = new Appointment
                {
                    DoctorId = model.DoctorId, 
                    PatientName = model.PatientName,
                    StartTime = model.StartTime,
                    EndTime = model.EndTime,
                };

                
                _context.appointments.Add(appointment);
                _context.SaveChanges();

                return RedirectToAction("ReservationsManagement");
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
