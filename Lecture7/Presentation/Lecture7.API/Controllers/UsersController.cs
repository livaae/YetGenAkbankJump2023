﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week7.Domain.Entities;
using Week7.Persistence.Contexts;

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

       [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            return Ok(_context.Users.ToList());
        }

        

        [HttpPost("[action]")]
        
        public IActionResult CreateUser([FromBody] CreateUserRequest createUserRequest)
        {
            User user = new()
            {
                FirstName = createUserRequest.FirstName,
                LastName = createUserRequest.LastName,
            };

            _context.Users.Add(user);

            //_context.SaveChanges();

            return Ok();
        }

        [HttpGet("[action]")]
        public string GetSomething(string name)
        {
            return name.Substring(0, 2);
        }
    }
}
