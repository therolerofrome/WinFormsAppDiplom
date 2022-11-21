using Dapper;
using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OperationTypeRepository : IRepository<OperationType>
    {
        string connectionString = null;
        public OperationTypeRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(OperationType obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OperationType GetObject(int id)
        {
            string s = "";
            throw new NotImplementedException();
        }

        public List<OperationType> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<OperationType>("SELECT * FROM OperationType").ToList();
            }
        }

        public void Update(OperationType obj)
        {
            throw new NotImplementedException();
        }
    }
}
