using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AirTicketWebApi.Models
{
    [Table("Feedback")]
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        public string Message { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
