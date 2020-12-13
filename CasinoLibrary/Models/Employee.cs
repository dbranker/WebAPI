using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoLibrary.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool isActive { get; set; }
        public bool isOwner { get; set; }

    }
}
