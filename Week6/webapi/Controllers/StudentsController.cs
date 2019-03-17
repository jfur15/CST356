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
    public class StudentsController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public StudentsController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

         [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return Ok(_dbContext.Student.Include(p => p.Person).ToList());
        }



    }
}
