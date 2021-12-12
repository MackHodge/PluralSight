using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repsitories
{
   public class EmployeeRepository
    {
        private readonly List<Employee> employees = new ();
        public void Add(Employee employee ) {
            employees.Add(employee);
        }

        public void Save() {
            foreach (Employee employee in employees)
            {
                System.Console.WriteLine(employee);
            }
        }
    }
}
