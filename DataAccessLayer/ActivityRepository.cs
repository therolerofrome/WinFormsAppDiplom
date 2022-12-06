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
    public class ActivityRepository : IRepository<Activity>
    {
        string connectionString = null;
        public void Create(Activity obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO sprActivity (ActivityName, Objects, NumberOfZoom, ActivityType, Description) VALUES(@ActivityName, @Objects, @NumberOfZoom, @ActivityType, @Description)";
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM sprActivity WHERE Id = @id";
            }
        }

        public Activity GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Activity>("SELECT * FROM sprActivity").FirstOrDefault();
            }
        }

        public List<Activity> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Activity>("SELECT * FROM sprActivity").ToList();
            }
        }

        public void Update(Activity obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE sprBlock SET ActivityName = @ActivityName, Objects = @Objects, NumberOfZoom = @NumberOfZoom, ActivityType = @ActivityType, Description = @Description WHERE Id = @Id";
            }
        }
    }


}
