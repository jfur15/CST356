﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;


namespace webapi.Controllers
{
    [Route("api/[controller]")]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public List<Person> Get()
        {
            return InMemory.persons;
        }

    }
}
