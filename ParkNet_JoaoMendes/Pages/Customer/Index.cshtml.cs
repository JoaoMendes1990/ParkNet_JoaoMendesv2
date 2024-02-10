using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;


namespace ParkNet_JoaoMendes.Pages.Customer;

public class IndexModel : PageModel
{
    private readonly ParkNet_JoaoMendes.Data.ApplicationDbContext _context;

    public IndexModel(ParkNet_JoaoMendes.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<ViewCostumer> Customer { get; set; } = default!; //Qua

    public async Task OnGetAsync()
    {
        Customer = await _context.Customers.ToListAsync();
    }
}



public class ViewCostumer
{
    public int CostumerId { get; set; }
    public string Name { get; set; }
    public DateTime DateofBirth { get; set; }

    public string DriversLicense { get; set; }

    public string CreditCard { get; set; }

    public int VehicleId { get; set; }
    public int TransactionId { get; set; }

}
