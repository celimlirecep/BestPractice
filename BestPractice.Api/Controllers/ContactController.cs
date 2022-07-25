using BestPractice.Api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPractice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IContactService _contactService;

        public ContactController(IConfiguration configuration, IContactService contactService)
        {
            _configuration = configuration;
            _contactService = contactService;
        }

        [HttpGet]
        public string Test()
        {
            return _configuration["test1"].ToString();

        }
        [HttpGet("{id}")]
        public IActionResult GetContactById(int id)
        {
            return Ok(_contactService.GetContactById(id));
        }
    }
}
