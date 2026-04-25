using Microsoft.AspNetCore.Mvc;
using SalonManagementAPI.Data;
using SalonManagementAPI.Models;
using System;
using System.Linq;

namespace SalonManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ServiceController(AppDBContext context)
        {
            _context = context;
        }

        // GET ALL SERVICES
        [HttpGet]
        public IActionResult GetServices()
        {
            return Ok(_context.Services.ToList());
        }

        // ADD SERVICE (ADMIN)
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();

            return Ok(service);
        }
    }
}