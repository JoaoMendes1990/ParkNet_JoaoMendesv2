using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;



namespace ParkNet_JoaoMendes.Data.Entities
{
    public class Customer
    {
        //Properties
        [Key]
        public int CostumerId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        [Required]
        public string DriversLicense { get; set; }
        [Required]
        public string CreditCard { get; set; }

        public int VehicleId { get; set; }
        public int TransactionId { get; set; }

    }
}
