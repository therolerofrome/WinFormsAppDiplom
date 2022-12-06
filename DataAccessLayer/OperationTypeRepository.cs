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
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO sprOperationType (OperationName) VALUES(@OperationName)";
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM sprOperationType WHERE Id = @id";
            }
        }

        public OperationType GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<OperationType>("SELECT * FROM sprOperationType").FirstOrDefault();
            }
        }

        public List<OperationType> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<OperationType>("SELECT * FROM sprOperationType").ToList();
            }
        }

        public void Update(OperationType obj)
        {
            var sqlQuery = "UPDATE sprOperationType SET OperationName = @OperationName";
        }
    }
}
