using System;   
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repsitories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            AddEmployee(employeeRepository);
            GetEmployeeById(employeeRepository);


            var organizationRepository = new GenericRepository<Organization>();
            AddOrganizatations(organizationRepository);
            GetOrganizationById(organizationRepository);
            Console.ReadLine();
        }

        private static void GetOrganizationById(GenericRepository<Organization> organizationRepository)
        {
            var organization = organizationRepository.GetById(1);
            Console.WriteLine($"Organization with id 1: {organization.Name}");
        }

        private static void GetEmployeeById(GenericRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Employee with Id 2: {employee.Firstname } ");
        }

        private static void AddEmployee(GenericRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { Firstname = "Allen", GUID = Guid.NewGuid() });
            employeeRepository.Add(new Employee { Firstname = "Elon", GUID = Guid.NewGuid() });
            employeeRepository.Add(new Employee { Firstname = "Thomas", GUID = Guid.NewGuid() });

            employeeRepository.Save();
        }

        private static void AddOrganizatations(GenericRepository<Organization> organizationRepository)
        {
            organizationRepository.Add(new Organization { Name = "Tesla" });
            organizationRepository.Add(new Organization { Name = "Spacex" });
            organizationRepository.Add(new Organization { Name = "Google" });
            organizationRepository.Save();
        }
    }
}
