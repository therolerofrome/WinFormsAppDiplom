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
    internal class ActivityTypesRepository : IRepository<activity_types>
    {
        string connectionString = null;
        public ActivityTypesRepository(string conn)
        {
            connectionString = conn;
        }
        public void Create(activity_types obj)
        {
            var sqlQuery = "INSERT INTO sprActiityTypes (Type) VALUES(@Type)";
        }

        public void Delete(int id)
        {
            var sqlQuery = "DELETE FROM sprActiityTypes WHERE Id = @id";
        }

        public activity_types GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<activity_types>("SELECT * FROM sprActiityTypes").FirstOrDefault();
            }
        }

        public List<activity_types> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<activity_types>("SELECT * FROM sprActiityTypes").ToList();
            }
        }

        public void Update(activity_types obj)
        {
            var sqlQuery = "UPDATE sprActiityTypes SET Type = @Type";
        }
    }
}
