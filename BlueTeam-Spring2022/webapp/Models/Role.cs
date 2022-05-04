using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebApp.Models
{
    public class Role
    {
        public int RoleID {get; set;}
        public string? RoleName {get; set;}
    }
}