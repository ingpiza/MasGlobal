using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.EmployeesData {

    [Table("Employees")]
    public class Employee {

        public String Id { get; set; }

        public DateTime Created { get; set; }

        [Required, MaxLength(64)]
        public String Name { get; set; }

        public Contract Contract { get; set; }

        public DateTime? Updated { get; set; }

    }
}
