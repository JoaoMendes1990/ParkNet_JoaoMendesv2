using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParkNet_JoaoMendes.Data.Entities;

namespace ParkNet_JoaoMendes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Todas entidades declaradas para serem mapeadas no banco de dados, utilizando o Entity Framework, falta os restantes passos
        public DbSet<Park> Parks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<ParkingSpace> ParkingSpaces { get; set; }
        public DbSet<Permit> Permit { get; set; }
        public DbSet<TariffPermit> TariffPermits { get; set; }
        public DbSet<TariffTicket> TariffTicket { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
