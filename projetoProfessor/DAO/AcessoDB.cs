using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace projetoProfessor.DAO
{
    public abstract class AcessoDB
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        protected bool AbrirConexao()
        {
            // server = "localhost";
            // database = "projetoProfessor";
            // uid = "root";
            // password = "1234";
            // string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnectionStringBuilder strCon = new MySqlConnectionStringBuilder();

            strCon.Server = "127.0.0.1";
            strCon.Port = 3306;
            strCon.Database = "projetoProfessor";
            strCon.UserID = "root";
            strCon.Password = "1234";
            strCon.SslMode = 0;

            connection = new MySqlConnection(strCon.ConnectionString);
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        protected bool FecharConexao()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }
    }
}