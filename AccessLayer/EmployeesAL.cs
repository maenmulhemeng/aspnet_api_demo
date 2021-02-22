using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using maen_vog_backend_codechallenge.Services;
using maen_vog_backend_codechallenge.Models;

namespace maen_vog_backend_codechallenge.AccessLayer
{

    public class EmployeesAL
    {
        public IEnumerable<Employee> Employesses { get; set; }
        private VirtualDatabase _database = new VirtualDatabase();
       
        public IList<Employee> SelectListOfEmployees()
        {   
            Employesses = _database.ListAll();
            return Employesses.ToList();
        }

        public IEnumerable<Employee> SelectEmployees()
        {
            Employesses = _database.GetAll();
            return Employesses;
        }

    }
}
