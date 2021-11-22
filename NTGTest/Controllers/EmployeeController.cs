using Microsoft.AspNetCore.Mvc;
using NTGTest.DataAccessLayer.Entities;
using NTGTest.DataAccessLayer.Repositories.CRepositories;
using NTGTest.DataAccessLayer.Repositories.IRepositories;
using NTGTest.DataAccessLayer.Services.ServicesPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTGTest.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Employee> Index()
        {
            return _unitOfWork.EmployeeRepository.GetAll().ToArray(); 
        }
    }
}
