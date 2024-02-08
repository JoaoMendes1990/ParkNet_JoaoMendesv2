using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ParkNet_JoaoMendes.Data.Entities
{
    public class Permit
    {
        [Key]
        public int PermitId { get; set; }
        public int vehicleId { get; set; }
        public int parkingSpaceId { get; set; }
        public int ParkId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }

    }
}
