using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database.Entities;
using Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ILogger _logger;

        public StudentsController(IStudentService studentService, ILoggerFactory loggerFactory)
        {
            _studentService = studentService;
            _logger = loggerFactory.CreateLogger("Controllers.StudentsController");
        }

        [HttpGet]
        public ActionResult<List<StudentDto>> GetAllStudents()
        {

            return _studentService.GetAllStudents();
        }



    }
}
