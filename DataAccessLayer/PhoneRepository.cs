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
    internal class PhoneRepository : IRepository<phones>
    {
        string connectionString = null;
        public PhoneRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(phones obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO spr_phone (name, Activity, PhoneDescription) VALUES(@name, @MActivity, @PhoneDescription)";
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM spr_phone WHERE id = @id";
            }
        }

        public phones GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<phones>("SELECT * FROM spr_phone").FirstOrDefault();
            }
        }

        public List<phones> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<phones>("SELECT * FROM spr_phone").ToList();
            }
        }

        public void Update(phones obj)
        {
            var sqlQuery = "UPDATE spr_phone SET name = @name, activity = @activity, phone_description = @phone_description";
        }
    }
}
