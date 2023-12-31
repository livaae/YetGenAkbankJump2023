﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week10_1.Application.Services;


namespace Week10_1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IConfigurationService _configuration;
        public CustomersController(IConfigurationService configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public void Get(string name)
        {
            //ConfigurationService.GetInstance().GetValue(name);
            _configuration.GetValue(name);
        }
    }
}
