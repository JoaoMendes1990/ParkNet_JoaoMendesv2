using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ParkNet_JoaoMendes.Data.Entities
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }

        public int CustomerId { get; set; }

        public bool IsParked { get; set; }
        public bool IsCar { get; set; }
        public int PermitId { get; set; }

    }
}
