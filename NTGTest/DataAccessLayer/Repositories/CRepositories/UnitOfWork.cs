using NTGTest.DataAccessLayer.Data;
using NTGTest.DataAccessLayer.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTGTest.DataAccessLayer.Repositories.CRepositories
{
    public class UnitOfWork : IUnitOfWork

    {
        ApplicationDbContext _dbContext;
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public Dictionary<Type, object> InitializedRepos { get; set; } = new Dictionary<Type, object>();

        public IEmployeeRepository EmployeeRepository { get => (IEmployeeRepository)GetRepo(typeof(EmployeeRepository));}

        private object GetRepo(Type type)
        {
            object repo = null;
            var initialized = InitializedRepos.TryGetValue(type, out repo);
            if (repo == null)
            {
                repo = Activator.CreateInstance(type, _dbContext);
                InitializedRepos[type] = repo;
            }
            return repo;
        }

       // public virtual IEmployeeRepository EmployeeRepository { get => (IEmployeeRepository)GetRepo(typeof(EmployeeRepository)); }
    }
}
