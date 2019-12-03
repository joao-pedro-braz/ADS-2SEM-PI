using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using tokenkong.models;

namespace tokenkong
{
    class Auth
    {
        public UserModel login(string user, string pass)
        {
            UserModel result = null;
            DataBase dataBase = new DataBase();

            try
            {
                MySqlConnection connection = dataBase.connect();
                MySqlCommand command = null;
                command = new MySqlCommand($"SELECT * FROM USER WHERE PASSWORD = @pass AND EMAIL = @user", connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@pass", pass);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows){
                    while (reader.Read())
                    {
                        UserModel userModel = new UserModel();
                        userModel.ID = int.Parse(reader[reader.GetOrdinal("ID")].ToString());
                        userModel.EMAIL = reader[reader.GetOrdinal("EMAIL")].ToString();
                        userModel.NAME = reader[reader.GetOrdinal("NAME")].ToString();
                        userModel.ROLE = int.Parse(reader[reader.GetOrdinal("ROLE_ID")].ToString());

                        result = userModel;
                    }
                }
                connection.Close();

                if (connection.State == ConnectionState.Open && connection.State.ToString() == "Open")
                {
                    connection.Close();
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error: " + Convert.ToString(error), "Aviso");
            }
            return result;
        }

        public bool logout()
        {
            bool result = true;
            try
            {
                Properties.Settings.Default.Reset();
            }
            catch (MySqlException error)
            {
                result = false;
                MessageBox.Show("Error: " + Convert.ToString(error), "Aviso");
            }
            return result;
        }
    }
}
