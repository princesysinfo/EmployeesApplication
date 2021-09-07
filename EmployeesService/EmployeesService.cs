using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmplyeesEntity.Entity;

namespace EmployeesService
{
    public class EmployeesService
    {
        public EmployeesModel EmployeesSalary()
        {
            List<EmployeesModel> employees = new List<EmployeesModel>()
            {
               new EmployeesModel() { EmpId = 101,EmpName ="Sumanth",Department="IT",Salary=50000 },
               new EmployeesModel() { EmpId = 101,EmpName ="Amit",Department="OPERATION",Salary=40000 },
               new EmployeesModel() { EmpId = 101,EmpName ="Prem",Department="FINANCE",Salary=45000},
               new EmployeesModel() { EmpId = 101,EmpName ="Ravi",Department="TRANSPORT",Salary=35000 }
            };

             return employees.OrderByDescending(e => e.Salary).Skip(1).FirstOrDefault();
        }
    }

}
