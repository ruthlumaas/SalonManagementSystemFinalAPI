using Microsoft.AspNetCore.Mvc;
using SalonManagementAPI.Data;
using SalonManagementAPI.Models;
using System;
using System.Linq;

namespace SalonManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly AppDBContext _context;

        public AppointmentController(AppDBContext context)
        {
            _context = context;
        }

        // BOOK APPOINTMENT
        [HttpPost]
        public IActionResult Book(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();

            return Ok("Appointment booked successfully");
        }

        // GET ALL APPOINTMENTS (ADMIN)
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Appointments.ToList());
        }

        // GET APPOINTMENTS BY CUSTOMER
        [HttpGet("customer/{id}")]
        public IActionResult GetByCustomer(int id)
        {
            var data = _context.Appointments
                .Where(x => x.CustomerId == id)
                .ToList();

            return Ok(data);
        }
    }
}