using System;   
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repsitories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new EmployeeRepository();
            employeeRepository.Add(new Employee { Firstname = "Allen" , GUID = Guid.NewGuid() });
            employeeRepository.Add(new Employee { Firstname = "Elon", GUID = Guid.NewGuid() });
            employeeRepository.Add(new Employee { Firstname = "Thomas", GUID = Guid.NewGuid() });
            employeeRepository.Save();

            Console.ReadLine();
        }
    }
}
