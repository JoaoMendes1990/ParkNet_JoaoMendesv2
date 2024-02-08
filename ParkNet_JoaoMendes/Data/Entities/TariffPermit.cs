using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ParkNet_JoaoMendes.Data.Entities
{
    public class TariffPermit
    {
        [Key]
        public int PermitId { get; set; }
        public int ParkingSpaceId { get; set; }
        public int PermitDuration { get; set; }
        public int PermitPrice { get; set; }
    }
}
