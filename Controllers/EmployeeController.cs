using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    [EnableCors()]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id  =1,
                    Name = "Mark",
                    Email = "m@gmail.com"
                },
                new Employee()
                {
                    Id  =2,
                    Name = "Paul",
                    Email = "p@gmail.com"
                },
                new Employee()
                {
                    Id  =3,
                    Name = "Watson",
                    Email = "w@gmail.com"
                },
            };
            return Ok(employees);
        }

        [DisableCors]
        [HttpPost]
        public string Post()
        {
            return "Post";
        }
    }
}
