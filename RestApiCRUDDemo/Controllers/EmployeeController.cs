using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiCRUDDemo.EmployeeData;
using RestApiCRUDDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCRUDDemo.Controllers
{
   
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeData employeeData1;

        public EmployeeController(IEmployeeData employeeData)
        {
            employeeData1 = employeeData; 
        }


        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(employeeData1.GetEmployees());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployee(Guid id)
        {
            var employe = employeeData1.GetEmployee(id);
            if (employe != null)
            {

                return Ok(employeeData1.GetEmployee(id));
            }
            return NotFound($"employye wid ID is Not Fount{id}");
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetEmployee(Employee employee)
        {

            employeeData1.ADDemployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host 
                + HttpContext.Request.Path + "/" + employee.Id, employee);
            
        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult deleteemployee(Guid id)
        {
              
            var employee = employeeData1.GetEmployee(id);
            if (employee != null)
            {

                employeeData1.deleteemployee(employee);
                return Ok();
            }
            return NotFound($"employye wid ID is Not Fount{id}");

        }
        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult eDITemployee(Guid id,Employee employee)
        {

            var existingemployee = employeeData1.GetEmployee(id);
            if (existingemployee != null)
            {

                employee.Id = existingemployee.Id;
                employeeData1.Editemolyee(employee);
               
            }
            return Ok(employee);
        }
    }
}
