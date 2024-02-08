using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ParkNet_JoaoMendes.Data.Entities
{
    public class TariffTicket
    {
        [Key]
        public int TicketId { get; set; }
        public int ParkingSpaceId { get; set; }
        public int TicketDuration { get; set; }
        public int TicketPrice { get; set; }
    }
}
