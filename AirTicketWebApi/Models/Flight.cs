using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AirTicketWebApi.Models
{
    [Table("Flight")]
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }

        public string FlightName { get; set; }

        public string Source { get; set; }

        public string Destination { get; set; }

        public string DepartureTime { get; set; }

        public string AraivalTime { get; set; }

        public double GeneralFare { get; set; }

        public double PremiumPlus { get; set; }
    }
}
