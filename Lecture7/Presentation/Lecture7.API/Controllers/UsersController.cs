using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week7.Domain.Entities;
using Week7.Persitence.Contexts;

namespace Lecture7.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Week7_DbContext _context;

        public UsersController()
        {
            _context = new();
        }

        [HttpGet]
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}
