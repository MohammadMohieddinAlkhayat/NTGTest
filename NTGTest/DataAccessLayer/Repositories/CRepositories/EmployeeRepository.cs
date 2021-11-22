using NTGTest.DataAccessLayer.Data;
using NTGTest.DataAccessLayer.Entities;
using NTGTest.DataAccessLayer.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTGTest.DataAccessLayer.Repositories.CRepositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext db) : base(db)
        {

        }
        public new IEnumerable<Employee> GetAll()
        {
            var x = _db.Employees.ToList();
           return x.AsEnumerable();
        }
    }
}
