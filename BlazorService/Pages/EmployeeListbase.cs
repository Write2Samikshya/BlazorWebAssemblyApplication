using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorService.Pages
{
    public class EmployeeListbase:ComponentBase
    {

       public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees()
        {
            Employee e1 = new Employee
            {
                EmployeeID=1,
                EmpName="Samu1",
                Email="Samu@gmail.com",
                DateofBirth=new DateTime(2020,1,1),
                Gender=Gender.Female,
                DepartmentID = 111,
                Photopath="Images/flower1.jpg"
            };

            Employee e2 = new Employee
            {
                EmployeeID = 2,
                EmpName = "Samu2",
                Email = "Samu2@gmail.com",
                DateofBirth = new DateTime(2020, 2, 2),
                Gender = Gender.Female,
                DepartmentID = 112,
                Photopath = "Images/flower2.jpg"

            };

            Employees = new List<Employee> { e1, e2 };

        }


    }
}
