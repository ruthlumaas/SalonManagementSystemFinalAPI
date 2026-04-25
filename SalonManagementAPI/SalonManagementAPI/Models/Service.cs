using System.ComponentModel.DataAnnotations;

namespace SalonManagementAPI.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        public string ServiceName { get; set; }

        public decimal Price { get; set; }
    }
}
