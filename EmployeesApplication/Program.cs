using System;
using EmployeesService;

namespace EmployeesApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesService.EmployeesService employeesService = new EmployeesService.EmployeesService();
            var employees = employeesService.EmployeesSalary();
            Console.WriteLine("Employee Details that Has 2nd Highest Salary in the List...............");
            Console.WriteLine("Employee ID :" + employees.EmpId);
            Console.WriteLine("Employee Name :" + employees.EmpName);
            Console.WriteLine("Employee Department :" + employees.Department);
            Console.WriteLine("Employee 2nd highest Salary :" + employees.Salary);
        }
    }
}
