using Dapper;
using Microsoft.Data.SqlClient;
using Model;
using Model.ModelsSpr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataAccessLayer
{
    public class BlockRepository : IRepository<Block>
    {
        public void Create(Block obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Block GetObject(int id)
        {
            throw new NotImplementedException();
        }

        public List<Block> GetObjects()
        {
            throw new NotImplementedException();
        }

        public void Update(Block obj)
        {
            throw new NotImplementedException();
        }
    }
}
