using ParkNet_JoaoMendes.Data.Entities;

namespace ParkNet_JoaoMendes.Data
{
    public class ParkNetRepo
    {
        private readonly ApplicationDbContext _ctx;
        public ParkNetRepo(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public Customer Add(Customer customers)
        {
            _ctx.Customers.Add(customers);
            _ctx.SaveChanges();
            return customers;

        }
    }
}
