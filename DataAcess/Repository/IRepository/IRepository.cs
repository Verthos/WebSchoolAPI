using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(string procedure);
        void Add(string procedure, object entity);
        Task<IEnumerable<T>> GetFirstOrDefault(int id, string procedure);
        void Remove(string procedure, object entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}