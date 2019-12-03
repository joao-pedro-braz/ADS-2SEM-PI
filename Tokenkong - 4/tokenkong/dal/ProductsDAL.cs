using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using tokenkong.models;

namespace tokenkong.dal
{
    class ProductsDAL
    {
        public MySqlDataAdapter list()
        {
            try
            {
                DataBase dataBase = new DataBase();
                MySqlConnection connection = dataBase.connect();

                string sql = "";
                sql += "SELECT ";
                sql += "PRODUCT.`ID`, ";
                sql += "PRODUCT.`NAME`, ";
                sql += "PRODUCT.QUANTITY, ";
                sql += "PRODUCT.PRICE, ";
                sql += "PRODUCT.COST, ";
                sql += "PRODUCT.DESCRIPTION, ";
                sql += "PRODUCT.IMAGE, ";
                sql += "PROVIDER.`NAME` AS PROVIDER ";
                sql += "FROM PRODUCT ";
                sql += "INNER JOIN PROVIDER ";
                sql += "ON PROVIDER.ID = PRODUCT.PROVIDER_ID ";

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

        public bool add( ProductModel product)
        {
            bool result = false;
            try
            {
                DataBase dataBase = new DataBase();
                MySqlConnection connection = dataBase.connect();

                string sql = "";
                sql += "INSERT INTO PRODUCTS ( ";
                sql += "`NAME`, ";
                sql += "QUANTITY, ";
                sql += "PRICE, ";
                sql += "COST, ";
                sql += "DESCRIPTION ";
                sql += ") VALUES ( ";
                sql += "@NAME, ";
                sql += "@QUANTITY, ";
                sql += "@PRICE, ";
                sql += "@COST, ";
                sql += "@DESCRIPTION, ";
                sql += "@IMAGE ) ";

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = sql;

                command.Parameters.Add("@NAME", MySqlDbType.VarChar).Value = product.NAME;
                command.Parameters.Add("@QUANTITY", MySqlDbType.Int64).Value = product.QUANTITY;
                command.Parameters.Add("@PRICE", MySqlDbType.Float).Value = product.PRICE;
                command.Parameters.Add("@COST", MySqlDbType.Float).Value = product.COST;
                command.Parameters.Add("@DESCRIPTION", MySqlDbType.VarChar).Value = product.DESCRIPTION;
                command.Parameters.Add("@IMAGE", MySqlDbType.VarChar).Value = product.IMAGE;

                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            return result;
        }
    }
}
