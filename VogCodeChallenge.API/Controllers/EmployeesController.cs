using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using maen_vog_backend_codechallenge.Services;
using maen_vog_backend_codechallenge.Business;
using maen_vog_backend_codechallenge.AccessLayer;

using maen_vog_backend_codechallenge.Models;

namespace maen_vog_backend_codechallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        // Use business layer to apply business rules on the models
        private EmployeesBL _employeesBL = new EmployeesBL();
        private DepartmentsBL _departmentsBL = new DepartmentsBL();

        // Use Access Layer to access the database
        private EmployeesAL _employessAccessLayer = new EmployeesAL();
        private DepartmentsAL _departmentAccessLayer = new DepartmentsAL();

        [HttpGet]
        public IActionResult Index()
        {
            // Let's retriece the data
            IList<Employee> employess =_employessAccessLayer.SelectListOfEmployees();

            // or we can as the access layer to retrieve the IEnumerable<Employee> using SelectEmployees()
            // IList<Employee> employess =_employessAccessLayer.SelectEmployees();

            //  Let's process the data
            _employeesBL.DoSomeBusiness(employess);

            // Let's return the  results
            return Ok(employess);
        }
        [HttpGet("departments/{id}")]
        public IActionResult Departments(int id)
        {
            // Let's retriece the data
            IList<Department> departments = _departmentAccessLayer.SelectListOfDepartments();

            //  Let's process the data
            _departmentsBL.DoSomeBusiness(departments);
            Department d = departments.Where(e => e.ID == id).FirstOrDefault();
            if (d is null)
            {
                // Not found
                return NotFound();
            }
            else
            {
                // Let's return the  results
                return Ok(d);
               
            }
        }

    }
}
