using Dapper;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;


namespace WinFormsAppDiplom
{
    public class Objects
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool morph { get; set; }
    }
    public interface IObjectsRepository
    {
        void Create(Objects objects);
        void Delete(int id);
        Objects Get(int id);
        List<Objects> GetObjects();
        void Update(Objects objects);
    }
    public class ObjectsRepository : IObjectsRepository
    {
        string connectionString = null;
        public ObjectsRepository(string conn)
        {
            connectionString = conn;
        }
        public List<Objects> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Objects>("SELECT * FROM sprObjects").ToList();
            }
        }
        public Objects Get(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Objects>("SELECT * FROM sprObjects WHERE Id = @id", new { id }).FirstOrDefault();
            }
        }
        public void Create(Objects objects)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT sprObjects (Name, morph) VALUES(@Name, @morph)";//Поменять запрос?
                db.Execute(sqlQuery, objects);
            }
        }
        public void Update(Objects objects)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE OperationType SET Name = @Name, morph = @morph WHERE Id = @Id";//ZAPROS?
                db.Execute(sqlQuery, objects);
            }
        }
        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM sprObjets WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
    }
}
