using RestApiCRUDDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCRUDDemo.EmployeeData
{
  public   interface IEmployeeData
    {
        //getemployee details
        List<Employee> GetEmployees();
        //get single employee data
            Employee GetEmployee(Guid Id);
 
        // add employee data
        Employee ADDemployee(Employee employee);


        //delete employe data 
         void deleteemployee(Employee employee);


        Employee Editemolyee(Employee employee);

    }
}
