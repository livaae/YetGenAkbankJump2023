using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week11.Domain.Entities;
using Week11.Persistence.Contexts;

namespace Week11.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        public PerfectAppDbContext _perfectAppDbContext;

        public BankAccountsController(PerfectAppDbContext perfectAppDbContext)
        {
            _perfectAppDbContext = perfectAppDbContext;
        }

        [HttpPost("[action]")]
        public void SetDefaultUsersData()
        {
            List<BankAccount> people = new()
{
    new BankAccount
    {
        Id = Guid.Parse("6B29FC40-CA47-1067-B31D-00DD010662DA"),
        CreatedOn = DateTime.UtcNow,
        CreatedByUserId = "1",
        FirstName = "James",
        LastName = "Smith"
    },

    new BankAccount
    {
        Id = Guid.Parse("6B29FC40-CA47-1067-B31D-00DD010662DA"),
        CreatedOn = DateTime.UtcNow,
        CreatedByUserId = "1",
        FirstName = "John",
        LastName = "Johnson"
    },

    new BankAccount
    {
        Id = Guid.Parse("6B29FC40-CA47-1067-B31D-00DD010662DA"),
        CreatedOn = DateTime.UtcNow,
        CreatedByUserId = "1",
        FirstName = "Alice",
        LastName = "Williams"
    }
};

            _perfectAppDbContext.People.AddRange(people);

            _perfectAppDbContext.SaveChanges();
        }

    }
}
