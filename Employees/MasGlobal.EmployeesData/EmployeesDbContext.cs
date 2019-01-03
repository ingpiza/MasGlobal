using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.EmployeesData { 

    public class EmployeesDbContext: DbContext {

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Contract> Contracts { get; set; }

    }

}
