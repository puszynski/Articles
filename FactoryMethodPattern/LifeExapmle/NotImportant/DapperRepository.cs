using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.LifeExapmle.NotImportant
{
    public class DapperRepository : IUserRepository
    {
        private readonly string _connectionString;
        public DapperRepository()
            => _connectionString = "FooConfigString";

        public IEnumerable<User> GetAll()
        {
            using (IDbConnection cnn = new SqliteConnection(_connectionString))
            {
                var output = cnn.Query<User>("select * from User", new DynamicParameters());
                return output;
            }
        }

        public User GetById(int id)
        {
            using (IDbConnection cnn = new SqliteConnection(_connectionString))
            {
                var output = cnn.QuerySingle<User>($"select * from User where ID = {id}", new DynamicParameters());
                return output;
            }
        }

        public User GetByUserName(string userName)
        {
            using (IDbConnection cnn = new SqliteConnection(_connectionString))
            {
                var output = cnn.QuerySingle<User>($"select * from User where Name = {userName}", new DynamicParameters());
                return output;
            }
        }
    }
}
