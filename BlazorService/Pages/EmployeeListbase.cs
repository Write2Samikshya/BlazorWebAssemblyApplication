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

        IEnumerable<Employee> Employees { get; set; }



    }
}
