using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.EmployeesData {

    [Table("Contracts")]
    public abstract class Contract {

        public String Id { get; set; }

        [Required]
        public Employee Employee { get; set; }

        public abstract decimal GetAnnualSalary();

    }

    [Table("HourlySalaryContracts")]
    public class HourlySalaryContract: Contract {

        public decimal HourlySalary { get; set; }

        public override decimal GetAnnualSalary() {
            return 120 * HourlySalary * 12;
        }

    }
    [Table("MonthlySalaryContracts")]

    public class MonthlySalaryContract: Contract {

        public decimal MonthtlySalary { get; set; }

        public override decimal GetAnnualSalary() {
            return MonthtlySalary * 12;
        }

    }

}
