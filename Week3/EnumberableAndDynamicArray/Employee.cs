using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeApp
{
    class Employee : IEnumerable<Employee>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        private List<Employee> employees = new List<Employee>();

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return employees.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create some employees
            Employee employee1 = new Employee { Name = "John", Age = 30, Salary = 50000 };
            Employee employee2 = new Employee { Name = "Alice", Age = 25, Salary = 60000 };

            // Create the employee collection
            Employee employees = new Employee();
            employees.Add(employee1);
            employees.Add(employee2);

            // Display employees
            Console.WriteLine("Employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
            }
        }
    }
}
