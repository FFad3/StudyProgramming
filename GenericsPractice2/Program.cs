using GenericsPractice2.Entities;
using GenericsPractice2.Repositories;
using System;

namespace GenericsPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            AddEmployees(employeeRepository);
            GetEmployeeById(employeeRepository);

            var organizationRepository = new GenericRepository<Organization>();
            AddOrganizations(organizationRepository);
            Console.ReadKey();
        }

        private static void GetEmployeeById(GenericRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine($"Employee with id 2 : {employee.FirstName}");
        }

        private static void AddEmployees(GenericRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { FirstName = "Thomas" });
            employeeRepository.Add(new Employee { FirstName = "Anna" });
            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Save();
        }

        private static void AddOrganizations(GenericRepository<Organization> organizationRepository)
        {
            organizationRepository.Add(new Organization { Name = "firma1" });
            organizationRepository.Add(new Organization { Name = "firma2" });
            organizationRepository.Add(new Organization { Name = "firma3" });
            organizationRepository.Save();
        }
    }
}
