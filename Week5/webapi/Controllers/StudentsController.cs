﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public List<Student> Get()
        {
            return InMemory.students;
        }



    }
}
