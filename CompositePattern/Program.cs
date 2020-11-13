using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev1 = new Developer("Adam","100","Developer");
            Developer dev2 = new Developer("Frank","101","Developer2");
            CompanyDirectory engineers = new CompanyDirectory("Engineers");
            engineers.AddEmployee(dev1);
            engineers.AddEmployee(dev2);

            Manager man1 = new Manager("Bob","200","Manager");
            Manager man2 = new Manager("Emily","201","Manager2");
            CompanyDirectory managers = new CompanyDirectory("Managers");
            managers.AddEmployee(man1);
            managers.AddEmployee(man2);

            CompanyDirectory directory = new CompanyDirectory("Company");

            directory.AddEmployee(engineers);
            directory.AddEmployee(managers);

            directory.ShowEmployeeDetails();

            Console.ReadKey();
        }
    }
}
