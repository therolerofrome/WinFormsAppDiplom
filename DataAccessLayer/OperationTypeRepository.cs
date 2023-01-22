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
    public class OperationTypeRepository : IRepository<operation_type>
    {
        string connectionString = null;
        public OperationTypeRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(operation_type obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO spr_operation_type (operation_name) VALUES(@operation_name)";
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM spr_operation_type WHERE id = @id";
            }
        }

        public operation_type GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<operation_type>("SELECT * FROM spr_operation_type").FirstOrDefault();
            }
        }

        public List<operation_type> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<operation_type>("SELECT * FROM spr_operation_type").ToList();
            }
        }

        public void Update(operation_type obj)
        {
            var sqlQuery = "UPDATE spr_operation_type SET operation_name = @operation_name";
        }
    }
}
