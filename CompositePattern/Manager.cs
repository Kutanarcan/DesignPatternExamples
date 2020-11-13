using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Manager : Employee
    {
        private string empName;
        private string empID;
        private string position;

        public Manager(string empName, string empID, string position)
        {
            this.empName = empName;
            this.empID = empID;
            this.position = position;
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine($"{empID} - {empName}");
        }
    }
}
