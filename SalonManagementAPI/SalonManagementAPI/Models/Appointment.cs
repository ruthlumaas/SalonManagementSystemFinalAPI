using System.ComponentModel.DataAnnotations;

namespace SalonManagementAPI.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int ServiceId { get; set; }

        public DateTime AppointmentDate { get; set; }
    }
}
