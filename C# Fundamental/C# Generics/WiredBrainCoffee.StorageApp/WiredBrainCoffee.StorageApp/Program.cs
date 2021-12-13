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
           // ItemAdded<Employee> itemAdded = new ItemAdded<Employee>(EmployeeAdded);
            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext(), EmployeeAdded);

          //  ItemAdded<Manager> managerAdded = itemAdded;

            AddEmployee(employeeRepository);
            GetEmployeeById(employeeRepository);
            AddManagers(employeeRepository);
            //Contravariance 
            IWriteRepsitory<Manager> repo = new SqlRepository<Employee>(new StorageAppDbContext());

            var organizationRepository = new ListRepository<Organization>();
            AddOrganizatations(organizationRepository);
            GetOrganizationById(organizationRepository);

            WriteAllToConsole(employeeRepository);
            WriteAllToConsole(organizationRepository);
            //Covariance 
            IReadRepository<IEnity> repo1 = new ListRepository<Organization>();

            Console.ReadLine();
        }

        private static void EmployeeAdded(Employee employee)
        {

            Console.WriteLine($"Employee added => {employee.Firstname }");
        }

        private static void AddManagers(IWriteRepsitory<Manager> managerRepository)
        {
            var MarkManager = new Manager { Firstname = "Mark Z." };
            var MarkManagerCopy = MarkManager.Copy<Manager>();
            managerRepository.Add(MarkManager);
            if (MarkManagerCopy is not null)
            {
                MarkManagerCopy.Firstname += "_Copy";
                managerRepository.Add(MarkManagerCopy);
            }

            managerRepository.Add(MarkManager);

            managerRepository.Add(new Manager { Firstname = "Steve J." });

            managerRepository.Save();
        }

        private static void WriteAllToConsole(IReadRepository<IEnity> Repository)
        {
            var items = Repository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
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
            var employees = new[]
            {
               new Employee { Firstname = "Allen", GUID = Guid.NewGuid() },
               new Employee { Firstname = "Elon", GUID = Guid.NewGuid() },
               new Employee { Firstname = "Thomas", GUID = Guid.NewGuid() }

            };

            employeeRepository.Addbatch(employees);
        }

        private static void AddOrganizatations(IRepository<Organization> organizationRepository)
        {
            var organizations = new[]
            {
                  new Organization { Name = "Tesla" },
                 new Organization { Name = "Spacex" },
                 new Organization { Name = "Google" }

             };
            organizationRepository.Addbatch<Organization>(organizations);

        }


    }
}
