using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database;

using Microsoft.Extensions.Configuration;
namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public PersonsController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

         [HttpGet]
        public List<Person> GetAllPersons()
        {
           return _dbContext.Person.Include(p => p.Student).ToList();
        }



    }
}
