using MasGlobal.EmployeesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MasGlobal.EmployeesWeb.Controllers {

    public class EmployeeController: Controller {

        public ActionResult Search() {

            return View();
        }

        [HttpPost]
        public ActionResult Search(string id) {
            var context = new EmployeesDbContext();
            context.Configuration.LazyLoadingEnabled = false;
            context.Configuration.ProxyCreationEnabled = false;

            var employees = context.Employees.Include(e => e.Contract).Where(e => e.Id == id | id == null | id == string.Empty).OrderBy(e=> e.Id).ToArray();
            return Json(employees.Select(e => new { e.Id, e.Created, e.Name, AnnualSalary = e.Contract.GetAnnualSalary(), e.Updated }));
        }

        public ActionResult Create() {
            //var context = new EmployeesDbContext();

            //context.Database.Delete();
            //context.Database.Create();

            //for(var cnt = 0; cnt < 100; cnt++) {
            //    var e = new Employee() {
            //        Id = cnt.ToString(),
            //        Name = "Petter" + cnt.ToString(),
            //        Created = DateTime.Now + new TimeSpan(0, cnt, cnt),
            //        Updated = DateTime.Now + new TimeSpan(cnt, cnt, cnt),
            //    };

            //    if(cnt % 2 == 0) {
            //        e.Contract = new HourlySalaryContract() { Id = cnt.ToString(), HourlySalary = cnt * new Random().Next(100) };
            //    }
            //    else {
            //        e.Contract = new MonthlySalaryContract() { Id = cnt.ToString(), MonthtlySalary = cnt * new Random().Next(100) };
            //    }

            //    context.Employees.Add(e);
            //}

            //context.SaveChanges();
            return View();
        }

    }

}