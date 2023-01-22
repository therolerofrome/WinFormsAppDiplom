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
    public class BlockRepository : IRepository<block>
    {
        string connectionString = null;
        public void Create(block obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO operation_type (id_phone, description) VALUES(@id_phone, @description)";
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM spr_block WHERE id = @id";
            }
        }

        public block GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<block>("SELECT * FROM spr_block").FirstOrDefault();
            }
        }

        public List<block> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<block>("SELECT * FROM spr_block").ToList();
            }
        }

        public void Update(block obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE spr_block SET id_phone = @id_phone, description = @description WHERE id = @id";
            }
        }
    }
}
