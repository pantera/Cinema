using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Cinema.Entities.Data
{
    public class Connection
    {
        private SqlConnection connection;
        private const string user = "sa;";
        private const string pass = "*******;";
        private const string dbName = "Cinema;";
        private const string conString = "Data Source=YANG-PC\\SQLEXPRESS;Initial Catalog=Cinema;Persist Security Info=True;User ID=sa; Password = ******* ";

        public Connection()
        {
            connection = new SqlConnection(conString);
        }

        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }

        public SqlConnection getConnection()
        {
            return connection;
        }

    }

}