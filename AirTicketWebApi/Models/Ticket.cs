using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AirTicketWebApi.Models
{
    [Table("Ticket")]
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [Required]
        
        public string PassengerName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        
        public string PassengerEmail { get; set; }

        [Required]
        
        public string PassengerPhone { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string JourneyDate { get; set; }

        [Required]
        public double TotalFare { get; set; }

        public bool Status { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        [Required]
        public int FlightId { get; set; }

        public Flight? Flight { get; set; }
    }
}
