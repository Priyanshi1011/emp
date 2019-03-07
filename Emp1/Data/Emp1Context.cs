using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Emp1.Models;

namespace Emp1.Models
{
    public class Emp1Context : DbContext
    {
        public Emp1Context (DbContextOptions<Emp1Context> options)
            : base(options)
        {
        }

        public DbSet<Emp1.Models.Department> Department { get; set; }

        public DbSet<Emp1.Models.Employee> Employee { get; set; }
    }
}
