using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ParkNet_JoaoMendes.Data.Entities
{
    public class Park
    {
        [Key]
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string FloorID { get; set; }
    }
}
