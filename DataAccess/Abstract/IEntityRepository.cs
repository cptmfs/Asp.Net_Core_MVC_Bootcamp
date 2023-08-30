using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>where T : class 
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        T GetByID(int id);
        IEnumerable<T> GetAll();
    }
}
