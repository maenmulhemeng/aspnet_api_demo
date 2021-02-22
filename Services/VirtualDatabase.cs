using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using maen_vog_backend_codechallenge.Models;

namespace maen_vog_backend_codechallenge.Services
{
    public class VirtualDatabase
    {
        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> employess = new Employee[]
            {
                new Employee(1,"Maen","Mulhem"),
                new Employee(2,"Employee 2", "test 2"),
                new Employee(3, "Employee 3", "test 3")
            };
            
            return employess;
            
        }
        public IList<Employee> ListAll()
        {
            IList<Employee> employess = new List<Employee>()
            {
                new Employee(1,"Maen","Mulhem"),
                new Employee(2,"Employee 2", "test 2"),
                new Employee(3, "Employee 3", "test 3")
            };

            return employess;

        }

        // Samples for Departments entities
        public IList<Department> ListAllDepartments()
        {
            IList<Department> Departments = new List<Department>()
            {
                new Department(1,"D 1","Calgary"),
                new Department(2,"D 2", "Vancouver"),
                new Department(3, "D 3", "NY")
            };

            return Departments;

        }


    }
}
