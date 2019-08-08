using ParkingWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParkingWebService.Controllers
{
    public class EmployeeController : ApiController
    {
        IList<Employee> employees = new List<Employee>()
        {
            new Employee()
                {
                    Id = 1, FirstName = "Mukesh Kumar", Email = "New Delhi", Phone = "IT"
                },
                new Employee()
                {
                     Id = 2, FirstName = "Mukesh Kumar1111", Email = "New Delhi", Phone = "IT"
                },
                new Employee()
                {
                     Id = 3, FirstName = "Mukesh Kumar111", Email = "New Delhi", Phone = "IT"
                },
                new Employee()
                {
                     Id = 4, FirstName = "Mukesh Kumar11", Email = "New Delhi", Phone = "IT"
                },
                new Employee()
                {
                     Id =5, FirstName = "Mukesh Kumar1", Email = "New Delhi", Phone = "IT"
                }
        };
        [HttpGet]
        [Route ("api/employee")]
        public IList<Employee> GetAllEmployees()
        {
            //Return list of all employees  
            return employees;
        }

        public Employee GetEmployeeDetails(int id)
        {
            //Return a single employee detail  
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return employee;
        }
    }
}
