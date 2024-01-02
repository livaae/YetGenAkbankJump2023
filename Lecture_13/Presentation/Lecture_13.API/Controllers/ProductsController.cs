using Lecture_13.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lecture_13.Persistence.DbContext;

namespace Lecture_13.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly Lecture_13_DbContext _context;

        public ProductsController(Lecture_13_DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
           var products = _context.Products.Where(x => x.Price >25).ToList();
            foreach (var product in products)
            {
                product.Price += 100;
            }
            _context.SaveChanges();
        }
    }
}
