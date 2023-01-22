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
    public class ObjectsRepository : IRepository<objects>
    {
        string connectionString = null;
        public ObjectsRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(objects obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO spr_objects (name, morph) VALUES(@name, @morph)";
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM spr_objects WHERE id = @id";
            }
        }

        public objects GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<objects>("SELECT * FROM spr_objects").FirstOrDefault();
            }
        }

        public List<objects> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<objects>("SELECT * FROM spr_objects").ToList();
            }
        }

        public void Update(objects obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE spr_objects SET name = @name, morph = @morph";
            }
        }
    }
}
