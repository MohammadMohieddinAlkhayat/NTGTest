using Microsoft.EntityFrameworkCore;
using NTGTest.DataAccessLayer.Data;
using NTGTest.DataAccessLayer.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTGTest.DataAccessLayer.Repositories.CRepositories
{
    public class BaseRepository<DbModel> : IBaseRepository<DbModel> where DbModel : class
    {

        #region protected Attributes
        protected ApplicationDbContext _db { get; }
        private DbSet<DbModel> _dbSet { get; }
        #endregion

        protected IQueryable<DbModel> DBQueryable
        {
            get;
            set;
        }

        public BaseRepository(ApplicationDbContext db)
        {
            this._db = db;
            _dbSet = db?.Set<DbModel>();
            DBQueryable = _dbSet.AsQueryable();

            //loadFirstLevel();
        }
        public void Delete(int id)
        {
            DbModel obj = this.GetById(id);
            this.Delete(obj);
        }
        public void Delete(DbModel obj)
        {
            _dbSet.Attach(obj);
            _dbSet.Remove(obj);
        }

        public IEnumerable<DbModel> GetAll()
        {
            return _dbSet.AsEnumerable();
        }

        public DbModel Insert(DbModel newObj)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<DbModel> added = _dbSet.Add(newObj);
            return added.Entity;
        }

        public void Update(DbModel newObj)
        {
            _db.Entry(newObj).State = EntityState.Modified;
        }

        public DbModel GetById(int id)
        {
            Microsoft.EntityFrameworkCore.Metadata.IProperty keyProperty = _db.Model.FindEntityType(typeof(DbModel)).FindPrimaryKey().Properties[0];
            return DBQueryable.FirstOrDefault(e => EF.Property<int>(e, keyProperty.Name) == (int)id);

        }
    }
}
