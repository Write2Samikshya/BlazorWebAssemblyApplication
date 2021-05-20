using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models
{
   public  class Employee
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }

        public int DepartmentID { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateofBirth { get; set; }

        public string Email { get; set; }

        public string Photopath { get; set; }

    }
}
