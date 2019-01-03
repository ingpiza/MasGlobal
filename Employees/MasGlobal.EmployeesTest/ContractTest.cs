using System;
using MasGlobal.EmployeesData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasGlobal.EmployeesTest {

    [TestClass]
    public class ContractTest {

        [TestMethod]
        public void HourlySalaryTestMethod() {
            var contract = new HourlySalaryContract() { HourlySalary = 15 };

            Assert.AreEqual(120 * 15 * 12, contract.GetAnnualSalary(), "Error Hourly Salary");
        }

        [TestMethod]
        public void MonthlySalaryContractTestMethod() {
            var contract = new MonthlySalaryContract() { MonthtlySalary = 15 };

            Assert.AreEqual( 15 * 12, contract.GetAnnualSalary(), "Error Monthly Salary");
        }

    }

}
