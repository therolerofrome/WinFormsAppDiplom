using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<T>
    {
        void Create(T obj);
        void Delete(int id);
        T GetObject(int id);
        List<T> GetObjects();
        void Update(T obj);
    }
}
