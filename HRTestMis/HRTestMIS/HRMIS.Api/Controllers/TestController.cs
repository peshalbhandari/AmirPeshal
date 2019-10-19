﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                new
                {
                    Name=AppDomain.CurrentDomain.FriendlyName,
                    Date=DateTime.Now.ToLongDateString(),
                    Guid=Guid.NewGuid()
                });
        }
    }
}