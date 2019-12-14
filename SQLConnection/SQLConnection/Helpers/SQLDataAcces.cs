using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using SQLConnection.Models;

namespace SQLConnection.Helpers
{
    public class SQLDataAcces
    {
        public static List<PersonModel> GetPeople()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyData;" +
                "Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection db = new SqlConnection(connectionString);

            List<PersonModel> output =  db.Query<PersonModel>("Select * from dbo.People").ToList();

            return output;
        }
    }
}
