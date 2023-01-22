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
    public class ActivityRepository : IRepository<activity>
    {
        string connectionString = null;
        public void Create(activity obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO spr_activity (activity_name, objects, number_of_zoom, activity_type, description) VALUES(@activity_name, @objects, @number_of_zoom, @activity_type, @description)";
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM spr_activity WHERE id = @id";
            }
        }

        public activity GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<activity>("SELECT * FROM spr_activity").FirstOrDefault();
            }
        }

        public List<activity> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<activity>("SELECT * FROM spr_activity").ToList();
            }
        }

        public void Update(activity obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE sprBlock SET activity_name = @activity_name, objects = @objects, number_of_zoom = @number_of_zoom, activity_type = @activity_type, description = @description WHERE id = @id";
            }
        }
    }


}
