using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccessLayer
{
    public interface IRepositorySpr
    {
        void Create(AbstractSpr obj);
        void Delete(int id);
        AbstractSpr GetObject(int id);
        List<AbstractSpr> GetObjects();
        void Update(AbstractSpr obj);
    }
}
