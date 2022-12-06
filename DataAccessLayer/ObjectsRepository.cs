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
    public class ObjectsRepository : IRepository<Objects>
    {
        string connectionString = null;
        public ObjectsRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(Objects obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO sprObjects (Name, Morph) VALUES(@Name, @Morph)";
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM sprObjects WHERE Id = @id";
            }
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
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Objects>("SELECT * FROM sprObjects").ToList();
            }
        }

        public void Update(Objects obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE sprObjects SET Name = @Name, Morph = @Morph";
            }
        }
    }
}
