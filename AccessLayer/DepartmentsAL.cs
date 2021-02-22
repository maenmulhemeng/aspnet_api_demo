using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using maen_vog_backend_codechallenge.Services;
using maen_vog_backend_codechallenge.Models;

namespace maen_vog_backend_codechallenge.AccessLayer
{
    public class DepartmentsAL
    {
        public IEnumerable<Department> Departments { get; set; }
        private VirtualDatabase _database = new VirtualDatabase();

        public IList<Department> SelectListOfDepartments()
        {
            Departments = _database.ListAllDepartments();
            return Departments.ToList();
        }
    }
}
