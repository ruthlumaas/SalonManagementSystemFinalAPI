using System.ComponentModel.DataAnnotations;

namespace SalonManagementAPI.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }

        public DateTime Date { get; set; }
        public string Time { get; set; }

        public string Status { get; set; }
        public string Notes { get; set; }
    }
}
