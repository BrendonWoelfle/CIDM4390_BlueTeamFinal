#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp1.Models;

namespace WebApp1.Data
{
    public class ApbetProjectContext : DbContext
    {
        public ApbetProjectContext (DbContextOptions<ApbetProjectContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp1.Models.Instructor> Instructor { get; set; }
    }
}
