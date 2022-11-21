using Dapper;
using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataAccessLayer
{
    public class ObjectsRepository : IRepository<Objects>
    {
        string connectionString = null;
        public ObjectsRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(Objects obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Objects GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Objects>("SELECT * FROM sprObjects").FirstOrDefault();
            }
        }

        public List<Objects> GetObjects()
        {
            throw new NotImplementedException();
        }

        public void Update(Objects obj)
        {
            throw new NotImplementedException();
        }
    }
}
