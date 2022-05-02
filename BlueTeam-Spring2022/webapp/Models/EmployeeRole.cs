using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebApp.Models
{
    public class Employee
    {
        public int EmployeeRoleID {get; set;}
        public string? EmployeeName {get; set;}
    }

    public class EmployeeRole
    {
        public int RoleID {get; set;}
        public int EmployeeID {get; set;}
        public Role? Role {get; set;}
        public Employee? Employee {get; set;}
    }
}