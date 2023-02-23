using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AirTicketWebApi.Models
{
    [Table("Admin")]
    public class Admin
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int AdminId { get; set; }

        [Required]
        
        public string? Name { get; set; }

        [Required]
        public long? ExtensionKey { get; set; }
    }
}
