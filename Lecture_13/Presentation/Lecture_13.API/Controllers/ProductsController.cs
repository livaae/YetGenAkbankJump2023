using Lecture_13.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lecture_13.Persistence.DbContext;
using Lecture_13.Persistence.Repositories.ProductRepositories;

namespace Lecture_13.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private readonly Lecture_13_DbContext _context;

        //public ProductsController(Lecture_13_DbContext context)
        //{
        //    _context = context;
        //}
        private readonly ProductReadRepository _productReadRepository;

        public ProductsController(ProductReadRepository productReadRepository)
        {
              _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public List<Product> GetAll()
        {
        return _productReadRepository.GetAll();
        }
    }
}
