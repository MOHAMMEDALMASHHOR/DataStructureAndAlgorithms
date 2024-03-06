using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeApp
{
    class Employee : IEnumerable<double> // Implementing IEnumerable<double> to allow iteration over salaries
    {
        // Properties of the Employee class
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        // List to store employees
        private List<Employee> employees = new List<Employee>();

        // Method to add an employee to the collection
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        // Implementation of IEnumerable<double>.GetEnumerator()
        public IEnumerator<double> GetEnumerator()
        {
            // Yielding each employee's salary from the internal list
            foreach (var employee in employees)
            {
                yield return employee.Salary;
            }
        }

        // Implementation of IEnumerable.GetEnumerator()
        // This method is required for the non-generic IEnumerable interface
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); // Calling the generic GetEnumerator method
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

            // Display employees' salaries
            Console.WriteLine("Employees' Salaries:");
            foreach (double salary in employees)
            {
                Console.WriteLine($"Salary: {salary}");
            }
        }
    }
}
