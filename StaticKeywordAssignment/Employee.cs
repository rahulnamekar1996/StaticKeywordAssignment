using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
    public class Employee
    {
        private int employee_id;
        private string name;
        private double salary;
        private static int count;

        public Employee( string empName, double empSalary)
        {
            count++;
            employee_id = count;
            name = empName;
            salary = empSalary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee ID: {employee_id}, Name: {name}, Salary: {salary}");
        }

        public static int TotalEmp()
        {
          
            
            return count; 
        }

    }
}
