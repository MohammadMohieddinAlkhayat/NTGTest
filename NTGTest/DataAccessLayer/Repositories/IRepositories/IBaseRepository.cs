using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTGTest.DataAccessLayer.Repositories.IRepositories
{
   public interface IBaseRepository<DbModel> where DbModel : class
   {
        DbModel GetById(int id);
        IEnumerable<DbModel> GetAll();
        DbModel Insert(DbModel newObj);
        void Update(DbModel newObj);
        void Delete(int id);


    }
}
