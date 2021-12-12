using System;   
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repsitories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepositoryWithRemove<Employee>();
            employeeRepository.Add(new Employee { Firstname = "Allen" , GUID = Guid.NewGuid() });
            employeeRepository.Add(new Employee { Firstname = "Elon", GUID = Guid.NewGuid() });
            employeeRepository.Add(new Employee { Firstname = "Thomas", GUID = Guid.NewGuid() });
            
            employeeRepository.Save();

            var organizationRepository = new GenericRepository<Organization ,int>();

            organizationRepository.Add(new Organization { Name = "Tesla"});
            organizationRepository.Add(new Organization { Name = "Spacex" });
            organizationRepository.Add(new Organization { Name = "Google" });
            organizationRepository.Save();


            Console.ReadLine();
        }
    }
}
