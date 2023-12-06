using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week10_1.Infrastructure.Services;

namespace Week10_1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public CustomersController()
        {
            
        }

        [HttpGet]
        public void Get(string name)
        {
            ConfigurationService.GetInstance().GetValue(name);
        }
    }
}
