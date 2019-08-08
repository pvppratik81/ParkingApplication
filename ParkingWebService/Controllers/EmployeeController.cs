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
                    id = 1, name = "Mukesh Kumar", email = "New Delhi", phone = "IT"
                },
                new Employee()
                {
                     id = 2, name = "Mukesh Kumar1111", email = "New Delhi", phone = "IT"
                },
                new Employee()
                {
                     id = 3, name = "Mukesh Kumar111", email = "New Delhi", phone = "IT"
                },
                new Employee()
                {
                     id = 4, name = "Mukesh Kumar11", email = "New Delhi", phone = "IT"
                },
                new Employee()
                {
                     id =5, name = "Mukesh Kumar1", email = "New Delhi", phone = "IT"
                },
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
            var employee = employees.FirstOrDefault(e => e.id == id);
            if (employee == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return employee;
        }
    }
}
