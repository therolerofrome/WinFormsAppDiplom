using Dapper;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;


namespace WinFormsAppDiplom
{
    public class CastTypes
    {
        public int id { get; set; }
        public string castname { get; set; }
    }
    public interface ICastTypesRepository
    {
        void Create(CastTypes castTypes);
        void Delete(int id);
        CastTypes Get(int id);
        List<CastTypes> GetCastTypes();
        void Update(CastTypes casttypes);
    }
    public class CastTypesRepository : ICastTypesRepository
    {
        string connectionString = null;
        public CastTypesRepository(string conn)
        {
            connectionString = conn;
        }
        public List<CastTypes> GetCastTypes()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<CastTypes>("SELECT * FROM CastTypes").ToList();
            }
        }
        public CastTypes Get(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<CastTypes>("SELECT * FROM sprCastTypes WHERE Id = @id", new { id }).FirstOrDefault();
            }
        }
        public void Create(CastTypes castTypes)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT sprObjects (Name, morph) VALUES(@Name, @morph)";//Поменять запрос?
                db.Execute(sqlQuery, castTypes);
            }
        }
        public void Update(CastTypes castTypes)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE OperationType SET Name = @Name, morph = @morph WHERE Id = @Id";//ZAPROS?
                db.Execute(sqlQuery, castTypes);
            }
        }
        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM sprObjets WHERE Id = @id";//zapros
                db.Execute(sqlQuery, new { id });
            }
        }
    }


}
