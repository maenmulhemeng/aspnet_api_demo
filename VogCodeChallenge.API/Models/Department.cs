using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maen_vog_backend_codechallenge.Models
{
    public class Department
    {
        public Department()
        {

        }
        public Department(int id)
        {
            ID = id;
        }
        public Department(int id, string name, string address)
        {
            ID = id;
            Name = name;
            Address = address;
        }
        public int ID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public IList<Employee> Employees { get; set; }
    }
}
