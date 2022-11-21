using Dapper;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace WinFormsAppDiplom
{
    public class OperationType
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public interface IOperationTypeRepository
    {
        void Create(OperationType operationType);
        void Delete(int id);
        OperationType Get(int id);
        List<OperationType> GetOperationTypes();
        void Update(OperationType operationType);
    }
    public class OperationTypeRepository : IOperationTypeRepository
    {
        string connectionString = null;
        public OperationTypeRepository(string conn)
        {
            connectionString = conn;
        }
        public List<OperationType> GetOperationTypes()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<OperationType>("SELECT * FROM OperationType").ToList();
            }
        }
        public OperationType Get(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<OperationType>("SELECT * FROM OperationType WHERE Id = @id", new { id }).FirstOrDefault();
            }
        }
        public void Create(OperationType operationType)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO OperationType (Name) VALUES(@Name)";
                db.Execute(sqlQuery, operationType);
            }
        }
        public void Update(OperationType operationType)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE OperationType SET Name = @Name WHERE Id = @Id";
                db.Execute(sqlQuery, operationType);
            }
        }
        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM OperationType WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
    }
}
