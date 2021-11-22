using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTGTest.DataAccessLayer.Services.ServicesPool
{
    public interface IServicePool
    {
        EmployeeService EmployeeService { get; }
    }
}
