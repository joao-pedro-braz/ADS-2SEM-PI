using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace tokenkong.dal
{
    class ClientsDAL
    {
        public DataTable list()
        {
            try
            {
                DataBase dataBase = new DataBase();
                MySqlConnection connection = dataBase.connect();

                string sql = "";
                sql += "SELECT ";
                sql += "* ";
                sql += "FROM CLIENT ";
                sql += "ORDER BY NAME ";

                MySqlCommand command = null;
                command = new MySqlCommand(sql, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataBase.close(connection);

                return dataTable;
            }
            catch (Exception Erro)
            {
                throw Erro;
            }
        }

        public MySqlDataAdapter list2()
        {
            try
            {
                DataBase dataBase = new DataBase();
                MySqlConnection connection = dataBase.connect();

                string sql = "";
                sql += "SELECT ";
                sql += "* ";
                sql += "FROM CLIENT ";
                sql += "ORDER BY NAME ";

                MySqlCommand command = null;
                command = new MySqlCommand(sql, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;

                dataBase.close(connection);

                return adapter;
            }
            catch (Exception Erro)
            {
                throw Erro;
            }
        }
    }
}
