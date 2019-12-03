using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using tokenkong.models;

namespace tokenkong.dal
{
    class SalesDAL
    {
        public DataTable list()
        {
            try
            {
                DataBase dataBase = new DataBase();
                MySqlConnection connection = dataBase.connect();

                string sql = "";
                sql += "SELECT ";
                sql += "DATE(I.DATE) AS `Data`, ";
                sql += "I.AMOUNT AS `Valor`, ";
                sql += "I.DESCRIPTION AS `Observações`, ";
                sql += "U.NAME AS `Atendente`, ";
                sql += "C.NAME AS `Cliente` ";
                sql += "FROM INCOME AS I ";
                sql += "INNER JOIN CLIENT AS C ";
                sql += "ON C.ID = I.CLIENT_ID ";
                sql += "INNER JOIN USER AS U ";
                sql += "ON U.ID = I.USER_ID ";
                sql += "ORDER BY I.DATE DESC";

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

        public bool add(SaleModel sale)
        {
            bool result = false;

            MySqlTransaction transaction = null;
            DataBase dataBase = new DataBase();
            MySqlConnection connection = dataBase.connect();
            try{
                connection.Open();
                try
                {

                    string sql = "";
                    sql += "INSERT INTO INCOME ( ";
                    sql += "USER_ID, ";
                    sql += "CLIENT_ID, ";
                    sql += "AMOUNT, ";
                    sql += "DESCRIPTION, ";
                    sql += "`DATE` ";
                    sql += ") VALUES ( ";
                    sql += "@USER_ID, ";
                    sql += "@CLIENT_ID, ";
                    sql += "@AMOUNT, ";
                    sql += "@DESCRIPTION, ";
                    sql += "NOW() ";
                    sql += ") ";

                    transaction = connection.BeginTransaction();
                    using (MySqlCommand command = new MySqlCommand(sql, connection, transaction))
                    {

                        command.Connection = connection;
                        command.Transaction = transaction;
                        command.CommandText = sql;
                        command.Parameters.Add("@USER_ID", MySqlDbType.Int64).Value = sale.USER_ID;
                        command.Parameters.Add("@CLIENT_ID", MySqlDbType.Int64).Value = sale.CLIENT_ID;
                        command.Parameters.Add("@AMOUNT", MySqlDbType.Float).Value = sale.AMOUNT;
                        command.Parameters.Add("@DESCRIPTION", MySqlDbType.VarChar).Value = sale.DESCRIPTION;
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();
                        sale.ID = command.LastInsertedId;

                        if(sale.PRODUCTS.Count > 0){

                            sql = "";
                            sql += "INSERT INTO PRODUCT_INCOME ( ";
                            sql += "PRODUCT_ID, ";
                            sql += "INCOME_ID ";
                            sql += ") VALUES ";

                            for(int i=0; i < sale.PRODUCTS.Count; i++){

                                sql += "( ";
                                sql += "@PRODUCT_ID" + i.ToString() + ", ";
                                sql += "@INCOME_ID" + i.ToString() + " ";
                                sql += ") ";

                                if (i < sale.PRODUCTS.Count - 1)
                                {
                                    sql += ",";
                                }
                        
                                command.Parameters.Add("@PRODUCT_ID" + i.ToString(), MySqlDbType.Int64).Value = sale.PRODUCTS[i];
                                command.Parameters.Add("@INCOME_ID" + i.ToString(), MySqlDbType.Int64).Value = sale.ID;
                            }
                            command.CommandText = sql;
                            command.ExecuteNonQuery();
                            transaction.Commit();
                            result = true;
                        }
                        else
                        {
                            transaction.Rollback();
                            result = false;
                        }
                    }
                }
                catch(Exception error)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (MySqlException error2)
                    {
                        Console.WriteLine(error2);
                    }
                    Console.WriteLine(error);
                }
                connection.Close();
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
            
            return result;
        }

    }
}
