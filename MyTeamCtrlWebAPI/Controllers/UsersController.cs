﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyTeamCtrlWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(new { Name="Ivan", LastName="n/a"});
        }
    }
}
