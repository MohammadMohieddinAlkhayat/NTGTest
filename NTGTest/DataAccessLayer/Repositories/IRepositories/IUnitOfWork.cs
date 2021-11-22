using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTGTest.DataAccessLayer.Repositories.IRepositories
{
  public interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get; }
    }
}
