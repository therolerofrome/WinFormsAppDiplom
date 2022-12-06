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
    internal class ActivityTypesRepository : IRepository<ActivityTypes>
    {
        string connectionString = null;
        public ActivityTypesRepository(string conn)
        {
            connectionString = conn;
        }
        public void Create(ActivityTypes obj)
        {
            var sqlQuery = "INSERT INTO sprActiityTypes (Type) VALUES(@Type)";
        }

        public void Delete(int id)
        {
            var sqlQuery = "DELETE FROM sprActiityTypes WHERE Id = @id";
        }

        public ActivityTypes GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<ActivityTypes>("SELECT * FROM sprActiityTypes").FirstOrDefault();
            }
        }

        public List<ActivityTypes> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<ActivityTypes>("SELECT * FROM sprActiityTypes").ToList();
            }
        }

        public void Update(ActivityTypes obj)
        {
            var sqlQuery = "UPDATE sprActiityTypes SET Type = @Type";
        }
    }
}
