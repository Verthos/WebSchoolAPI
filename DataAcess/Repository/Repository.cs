using DataAccess.DbAccess;
using DataAccess.Models;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ISqlDataAccess _db;
        public Repository(ISqlDataAccess db)
        {
            _db = db;
        }


        public void Add(string procedure, object entity)
        {
            _db.SaveData(storedProcedure: procedure, entity);

        }

        public Task<IEnumerable<T>> GetAll(string procedure)
        {
            return _db.LoadData<T, dynamic>(storedProcedure: procedure, new { });
        }


        public Task<IEnumerable<T>> GetFirstOrDefault(int id, string procedure)
        {
            return _db.LoadData<T, dynamic>(storedProcedure: procedure, new { Id = id });
        }

        public void Remove(string procedure, object objectentity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
