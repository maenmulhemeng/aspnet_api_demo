using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maen_vog_backend_codechallenge.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(int id)
        {
            ID = id;
        }
        public Employee(int id, string fname, string lname)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string MailingAddress { get; set; }
   

    }
}
