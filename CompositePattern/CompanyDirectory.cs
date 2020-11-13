using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class CompanyDirectory : Employee
    {
        List<Employee> employees = new List<Employee>();
        string directoryName;

        public CompanyDirectory(string directoryName)
        {
            this.directoryName = directoryName;
        }
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        public void RemoveEmployee(Employee emp)
        {
            employees.Remove(emp);
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine($"Inside {directoryName} Directory");
            foreach (var emp in employees)
            {
                emp.ShowEmployeeDetails();
            }
        }
    }
}
