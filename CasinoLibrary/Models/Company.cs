using System;
using System.Collections.Generic;

namespace CasinoLibrary.Models
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public DateTime DateAdded { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Employee> Admins { get; set; }

    }
}
