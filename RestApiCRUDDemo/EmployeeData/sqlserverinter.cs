

using RestApiCRUDDemo.EmployeeDbContext;
using RestApiCRUDDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiCRUDDemo.EmployeeData
{
    public class sqlserverinter : IEmployeeData
    {
        private EmployeeContext _emloyeeDbContext;
        public sqlserverinter(EmployeeContext employeeContext)
        {
            _emloyeeDbContext = employeeContext;
        }

        public Employee ADDemployee(Employee employee)
        {
           employee.Id=Guid.NewGuid();  
      _emloyeeDbContext.emp1.Add(employee);
            _emloyeeDbContext.SaveChanges();
            return employee;
        }

        public void deleteemployee(Employee employee)
        {
             _emloyeeDbContext.Remove(employee);
            _emloyeeDbContext.SaveChanges(true);
            
        }

        public Employee Editemolyee(Employee employee)
        {
            var exixstingemployee = _emloyeeDbContext.emp1.Find(employee.Id);
            if (exixstingemployee != null)
            {
                exixstingemployee.Name=employee.Name;
                _emloyeeDbContext.emp1.Update(exixstingemployee);
                _emloyeeDbContext.SaveChanges();
            }
            return employee;
        }

        public Employee GetEmployee(Guid Id)
        {
            var employee = _emloyeeDbContext.emp1.Find(Id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _emloyeeDbContext.emp1.ToList();


        }
    }
      
}
