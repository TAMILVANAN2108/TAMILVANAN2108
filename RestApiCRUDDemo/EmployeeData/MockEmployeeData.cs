using RestApiCRUDDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCRUDDemo.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {


        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id=Guid.NewGuid(),
                Name="Employee1"
            },
            new Employee()
            {
                Id=Guid.NewGuid(),
                Name="Employee2"
            }

        };
        public Employee ADDemployee(Employee employee)
        {

            employee.Id=Guid.NewGuid();
            employees.Add(employee);
            return employee;

        }

        public void deleteemployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee Editemolyee(Employee employee)
        {
          var existingemployee=GetEmployee(employee.Id);
            existingemployee.Name= employee.Name;
            return existingemployee;
        }

        public Employee GetEmployee(Guid Id)
        {
            return employees.SingleOrDefault(x => x.Id == Id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    } 
}
