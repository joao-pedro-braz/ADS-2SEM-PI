using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace tokenkong
{
    class DataBase
    {
        const string SERVER = "localhost";
        const string DATABASE = "local";
        const string USER = "root";
        const string PASSWORD = "";

        string connection_string = $"SERVER={SERVER};DATABASE={DATABASE};UID={USER};PWD={PASSWORD};CharSet=utf8";

        MySqlConnection connection = null;

        public MySqlConnection connect()
        {
            this.connection = new MySqlConnection(this.connection_string);
            return connection;
        }

        public void close(MySqlConnection connection)
        {
            if (connection.State == ConnectionState.Open && connection.State.ToString() == "Open")
            {
                connection.Close();
            }
        }
    }
}
