using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace CRUDweb.Models
{
    public class DataAccess
    {
        private readonly IConfiguration Configuration;
        public DataAccess(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IDbConnection GetDapperConnection()
        {
            string connectionString = Configuration.GetConnectionString("MassDBString");
            IDbConnection dbConnection = new SqlConnection(connectionString);
            return dbConnection;

        }
    }
}