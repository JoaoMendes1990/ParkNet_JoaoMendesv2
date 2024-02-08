using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ParkNet_JoaoMendes.Data.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public int VehicleId { get; set; }
        public int ParkingSpaceId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }

    }
}
