using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1_Demo.Data.Models
{
    // POCO Class => Plain old Clr object
    // We have 4 ways to map classes into tables
    // 1- By convention [Default behavoiur]
    // 2- 
    internal class Employee
    {
        public int Id { get; set; } // Oublic numeric property named as "Id"
        public string? EmployeeName { get; set; } // nvarchar(max)
        // .net 5 : reference type : allow null [Optional]
        // .net 6 : reference type : not allow null [Required]
        public decimal Salary { get; set; } // decimal(18,2)
        public int? Age { get; set; } // Nullable<int>
    }
}
