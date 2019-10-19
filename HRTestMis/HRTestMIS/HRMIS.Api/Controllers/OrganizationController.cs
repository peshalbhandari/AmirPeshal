using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMIS.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMIS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly HRTestMISContext hrTestMISContext;

        public OrganizationController(HRTestMISContext hrTestMISContext)
        {
            this.hrTestMISContext = hrTestMISContext;
        }

        [HttpGet("List")]
        public IActionResult List()
        {
            return Ok(hrTestMISContext.SetupOrganization);
        }

        
    }
}