using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirTicketWebApi.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public string? NameOnCard { get; set; }

        [Required]
        public int CardNumber { get; set; }

        [Required]
        public int CVVCode { get; set; }

        [Required]
        [StringLength(6),MinLength(5),MaxLength(6)]
        public string? ExpiryDate { get; set; }

        [Required]
        public int TicketId { get; set; }
        public Ticket? Ticket { get; set; }
    }
}
