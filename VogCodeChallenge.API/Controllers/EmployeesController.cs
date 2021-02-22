using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace maen_vog_backend_codechallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
       
        [HttpGet]
        public IActionResult Index()
        {
         
            return Ok("initialized");
        }
       
    }
}
