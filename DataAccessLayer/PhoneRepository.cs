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
    internal class PhoneRepository : IRepository<Phones>
    {
        string connectionString = null;
        public PhoneRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(Phones obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO sprPhone (Name, Activity, PhoneDescription) VALUES(@Name, @MActivity, @PhoneDescription)";
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM sprPhone WHERE Id = @id";
            }
        }

        public Phones GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Phones>("SELECT * FROM sprPhone").FirstOrDefault();
            }
        }

        public List<Phones> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Phones>("SELECT * FROM sprPhone").ToList();
            }
        }

        public void Update(Phones obj)
        {
            var sqlQuery = "UPDATE sprPhone SET Name = @Name, Activity = @Activity, PhoneDescription = @PhoneDescription";
        }
    }
}
