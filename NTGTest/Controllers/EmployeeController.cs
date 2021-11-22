using Microsoft.AspNetCore.Mvc;
using NTGTest.DataAccessLayer.Entities;
using NTGTest.DataAccessLayer.Services.ServicesPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTGTest.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IServicePool allServices;
        public EmployeeController(IServicePool Services)
        {
            allServices = Services;
        }

        [HttpGet]
        public IEnumerable<Employee> Index()
        {
            return allServices.EmployeeService.GetEmployees().ToArray();
        }
    }
}
