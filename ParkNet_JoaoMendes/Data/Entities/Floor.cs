using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ParkNet_JoaoMendes.Data.Entities
{
    public class Floor
    {
        [Key]
        public int FloorId { get; set; }
        public int ParkId { get; set; }
        public int ParkingSpaceId { get; set; }
        public int FloorNumber { get; set; }

    }
}
