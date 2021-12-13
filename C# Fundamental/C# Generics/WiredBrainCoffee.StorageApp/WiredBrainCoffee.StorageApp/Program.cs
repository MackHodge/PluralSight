using System;
using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repsitories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
            AddEmployee(employeeRepository);
            GetEmployeeById(employeeRepository);


            var organizationRepository = new ListRepository<Organization>();
            AddOrganizatations(organizationRepository);
            GetOrganizationById(organizationRepository);
            Console.ReadLine();
        }

        private static void GetOrganizationById(IRepository<Organization> organizationRepository)
        {
            var organization = organizationRepository.GetById(1);
            Console.WriteLine($"Organization with id 1: {organization.Name}");
        }

        private static void GetEmployeeById(IRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Employee with Id 2: {employee.Firstname } ");
        }

        private static void AddEmployee(IRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { Firstname = "Allen", GUID = Guid.NewGuid() });
            employeeRepository.Add(new Employee { Firstname = "Elon", GUID = Guid.NewGuid() });
            employeeRepository.Add(new Employee { Firstname = "Thomas", GUID = Guid.NewGuid() });

            employeeRepository.Save();
        }

        private static void AddOrganizatations(IRepository<Organization> organizationRepository)
        {
            organizationRepository.Add(new Organization { Name = "Tesla" });
            organizationRepository.Add(new Organization { Name = "Spacex" });
            organizationRepository.Add(new Organization { Name = "Google" });
            organizationRepository.Save();
        }
    }
}
