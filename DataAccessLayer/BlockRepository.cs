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
        string connectionString = null;
        public void Create(Block obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO OperationType (IdPhone, Description) VALUES(@IdPhone, @Description)";
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM sprBlock WHERE Id = @id";
            }
        }

        public Block GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Block>("SELECT * FROM sprBlock").FirstOrDefault();
            }
        }

        public List<Block> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Block>("SELECT * FROM sprBlock").ToList();
            }
        }

        public void Update(Block obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE sprBlock SET IdPhone = @IdPhone, Description = @Description WHERE Id = @Id";
            }
        }
    }
}
