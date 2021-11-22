using NTGTest.DataAccessLayer.Entities;
using NTGTest.DataAccessLayer.Repositories.IRepositories;
using NTGTest.DataAccessLayer.Services.ServicesPool;
using System.Collections.Generic;
using System.Linq;

namespace NTGTest.DataAccessLayer.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository repository, ServicePool otherServices)
        {
            _employeeRepository = repository;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.GetAll();
        }

    }
}
